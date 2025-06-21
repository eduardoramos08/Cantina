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



        private void FormEstoque_Load(object sender, EventArgs e)
        {
            quantidadeTxt.Text = "1";
            quantidadeTxt.Focus();

            List<Estoque> produtosEstoque = new List<Estoque>();

            if (File.Exists("estoque.txt"))
            {
                var linhasDoArquivo = File.ReadLines("estoque.txt");

                foreach (var linha in linhasDoArquivo)
                {
                    var colunasDoListView = linha.Split(';');

                    if (colunasDoListView.Length >= 5)
                    {
                        Estoque produtosNoEstoque = new Estoque
                        {
                            Codigo = int.Parse(colunasDoListView[0]),
                            Descricao = colunasDoListView[1],
                            DataValidade = colunasDoListView[2],
                            Quantidade = int.Parse(colunasDoListView[3]),
                            Preco = decimal.Parse(colunasDoListView[4], CultureInfo.InvariantCulture),
                            Custo = decimal.Parse(colunasDoListView[5], CultureInfo.InvariantCulture),
                        };

                        produtosEstoque.Add(produtosNoEstoque);

                        ListViewItem item = new ListViewItem(produtosNoEstoque.Codigo.ToString());
                        item.SubItems.Add(produtosNoEstoque.Descricao);
                        item.SubItems.Add(produtosNoEstoque.DataValidade);
                        item.SubItems.Add(produtosNoEstoque.Quantidade.ToString());
                        item.SubItems.Add(produtosNoEstoque.Preco.ToString("F2"));
                        item.SubItems.Add(produtosNoEstoque.Custo.ToString("F2"));

                        listViewEstoque.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo estoque.txt não encontrado!");
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
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

        private void btnRemover_Click(object sender, EventArgs e)
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
    }
}
