using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARDAPIO_POO
{
    public partial class FormEstoque : Form
    {

        public FormEstoque()
        {
            InitializeComponent();
        }

        private void CarregarEstoque()
        {
            listViewEstoque.Items.Clear();

            if (File.Exists("estoque.txt"))
            {
                var linhas = File.ReadAllLines("estoque.txt");
                foreach (var linha in linhas)
                {
                    var colunas = linha.Split(';');
                    if (colunas.Length >= 6)
                    {
                        Estoque produto = new Estoque
                        {
                            Codigo = int.Parse(colunas[0]),
                            Descricao = colunas[1],
                            DataValidade = colunas[2],
                            Quantidade = int.Parse(colunas[3]),
                            Preco = decimal.Parse(colunas[4].Replace(",", "."), CultureInfo.InvariantCulture),
                            Custo = decimal.Parse(colunas[5].Replace(",", "."), CultureInfo.InvariantCulture)
                        };

                        ListViewItem item = new ListViewItem(produto.Codigo.ToString());
                        item.SubItems.Add(produto.Descricao);
                        item.SubItems.Add(produto.DataValidade);
                        item.SubItems.Add(produto.Quantidade.ToString());
                        item.SubItems.Add(produto.Preco.ToString("F2"));
                        item.SubItems.Add(produto.Custo.ToString("F2"));

                        item.Tag = produto;
                        listViewEstoque.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo estoque.txt não encontrado.");
            }
        }


        private void FormEstoque_Load(object sender, EventArgs e)
        {
            quantidadeTxt.Text = "1";
            quantidadeTxt.Focus();
            CarregarEstoque();
        }


        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            if (listViewEstoque.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para adicionar");
                return;
            }

            var itemSelecionado = listViewEstoque.SelectedItems[0];
            var produtoDoEstoque = (Estoque)itemSelecionado.Tag;

            if (!int.TryParse(quantidadeTxt.Text, out int quantidadeAdicionadaEstoque) || quantidadeAdicionadaEstoque <= 0)
            {
                MessageBox.Show("Digite Uma Quantidade Valida");
                quantidadeTxt.Clear();
                quantidadeTxt.Focus();
                return;
            }

            produtoDoEstoque.Quantidade += quantidadeAdicionadaEstoque;
            itemSelecionado.SubItems[3].Text = produtoDoEstoque.Quantidade.ToString();

            if (produtoDoEstoque.Quantidade <= 5)
            {
                MessageBox.Show($"Estoque do {produtoDoEstoque.Descricao} está acabando!");
            }
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            if (listViewEstoque.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para adicionar");
                return;
            }

            var itemSelecionado = listViewEstoque.SelectedItems[0];
            var produtoDoEstoque = (Estoque)itemSelecionado.Tag;

            if (!int.TryParse(quantidadeTxt.Text, out int quantidadeAdicionadaEstoque) || quantidadeAdicionadaEstoque <= 0)
            {
                MessageBox.Show("Digite Uma Quantidade Valida");
                quantidadeTxt.Clear();
                quantidadeTxt.Focus();
                return;
            }

            produtoDoEstoque.Quantidade -= quantidadeAdicionadaEstoque;
            itemSelecionado.SubItems[3].Text = produtoDoEstoque.Quantidade.ToString();

            if (produtoDoEstoque.Quantidade <= 5)
            {
                MessageBox.Show($"Estoque do {produtoDoEstoque.Descricao} está acabando!");
            }
        }


        private void salvarBtn_Click(object sender, EventArgs e)
        {
            string caminhoDoArquivo = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string localProdutosEstoque = Path.Combine(caminhoDoArquivo, "estoque.txt");

            using (StreamWriter writer = new StreamWriter(localProdutosEstoque, false))
            {
                foreach (ListViewItem item in listViewEstoque.Items)
                {
                    string codigo = item.SubItems[0].Text;
                    string descricao = item.SubItems[1].Text;
                    string dataValidade = item.SubItems[2].Text;
                    string quantidade = item.SubItems[3].Text;

                    string preco = item.SubItems[4].Text.Replace(",", ".");
                    string custo = item.SubItems[5].Text.Replace(",", ".");

                    string linha = $"{codigo};{descricao};{dataValidade};{quantidade};{preco};{custo}";
                    writer.WriteLine(linha);
                }
            }

            MessageBox.Show("Alterações salvas com sucesso.");
        }



    }
}

