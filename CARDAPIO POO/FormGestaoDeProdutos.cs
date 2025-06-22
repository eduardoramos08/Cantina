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
    public partial class FormGestaoDeProdutos : Form
    {
        public FormGestaoDeProdutos()
        {
            InitializeComponent();
        }
        List<Produto> listaProdutosCardapio = new List<Produto>();
        List<Estoque> produtosEstoque = new List<Estoque>();


        private void listViewCardapio_Click(object sender, EventArgs e)
        {
            listViewEstoque.SelectedItems.Clear();
        }

        private void listViewEstoque_Click(object sender, EventArgs e)
        {
            listViewCardapio.SelectedItems.Clear();
        }
        public void CarregarCardapio(ListView listViewCardapio, List<Produto> listaProdutosCardapio)
        {
            listaProdutosCardapio.Clear();
            listViewCardapio.Items.Clear();

            if (File.Exists("cardapio.txt"))
            {
                var linhas = File.ReadAllLines("cardapio.txt");

                foreach (var linha in linhas)
                {
                    var colunas = linha.Split(';');

                    if (colunas.Length == 5)
                    {
                        Produto produto = new Produto
                        {
                            Codigo = int.Parse(colunas[0]),
                            Descricao = colunas[1],
                            Quantidade = int.Parse(colunas[2]),
                            Preco = decimal.Parse(colunas[3], CultureInfo.InvariantCulture),
                            IsChapa = bool.Parse(colunas[4])
                        };

                        listaProdutosCardapio.Add(produto);

                        ListViewItem item = new ListViewItem(produto.Codigo.ToString());
                        item.SubItems.Add(produto.Descricao);
                        item.SubItems.Add(produto.Quantidade.ToString());
                        item.SubItems.Add(produto.Preco.ToString("F2"));
                        item.Tag = produto;

                        listViewCardapio.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo cardapio.txt não encontrado.");
            }
        }
            public void CarregarEstoque(ListView listViewEstoque, List<Estoque> produtosEstoque)
        {
            produtosEstoque.Clear();
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
                            Preco = decimal.Parse(colunas[4], CultureInfo.InvariantCulture),
                            Custo = decimal.Parse(colunas[5], CultureInfo.InvariantCulture),
                        };

                        produtosEstoque.Add(produto);

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
                MessageBox.Show("Arquivo estoque.txt não encontrado!");
            }
        }

        private void FormGestaoDeProdutos_Load(object sender, EventArgs e)
        {
            CarregarCardapio(listViewCardapio, listaProdutosCardapio);
            CarregarEstoque(listViewEstoque, produtosEstoque);

        }
        private void listViewCardapio_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewEstoque.SelectedItems.Clear();
            if (listViewCardapio.SelectedItems.Count > 0)
            {
                DataValidadeTxt.Visible = false;
                CustoTxt.Visible = false;
                label5.Visible = false;
                label3.Visible = false;

                ListViewItem item = listViewCardapio.SelectedItems[0];

                CodigoTxt.Text = item.SubItems[0].Text;
                DescricaoTxt.Text = item.SubItems[1].Text;
                QuantidadeTxt.Text = item.SubItems[2].Text;
                PrecoTxt.Text = item.SubItems[3].Text;
            }
            else
            {
                CodigoTxt.Clear();
                DescricaoTxt.Clear();
                QuantidadeTxt.Clear();
                PrecoTxt.Clear();
                DataValidadeTxt.Clear();
                CustoTxt.Clear();


                DataValidadeTxt.Visible = true;
                CustoTxt.Visible = true;
                label5.Visible = true;
                label3.Visible = true;
            }
        }


        private void listViewEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewCardapio.SelectedItems.Clear();
            if (listViewEstoque.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewEstoque.SelectedItems[0];

                CodigoTxt.Text = item.SubItems[0].Text;
                DescricaoTxt.Text = item.SubItems[1].Text;
                DataValidadeTxt.Text = item.SubItems[2].Text;
                QuantidadeTxt.Text = item.SubItems[3].Text;
                PrecoTxt.Text = item.SubItems[4].Text;
                CustoTxt.Text = item.SubItems[5].Text;
            }
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            if (listViewEstoque.SelectedItems.Count == 0 && listViewCardapio.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para editar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(CodigoTxt.Text) || string.IsNullOrWhiteSpace(DescricaoTxt.Text) || string.IsNullOrWhiteSpace(QuantidadeTxt.Text) || string.IsNullOrWhiteSpace(PrecoTxt.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de editar.");
                return;
            }

            if (listViewEstoque.SelectedItems.Count > 0)
            {
                ListViewItem itemSelecionadoEstoque = listViewEstoque.SelectedItems[0];

                foreach (ListViewItem item in listViewEstoque.Items)
                {
                    if (item != itemSelecionadoEstoque && item.SubItems[0].Text == CodigoTxt.Text)
                    {
                        MessageBox.Show("Já existe outro produto com este código no estoque.");
                        return;
                    }
                }

                itemSelecionadoEstoque.SubItems[0].Text = CodigoTxt.Text;
                itemSelecionadoEstoque.SubItems[1].Text = DescricaoTxt.Text;
                itemSelecionadoEstoque.SubItems[2].Text = DataValidadeTxt.Text;
                itemSelecionadoEstoque.SubItems[3].Text = QuantidadeTxt.Text;
                itemSelecionadoEstoque.SubItems[4].Text = PrecoTxt.Text;
                itemSelecionadoEstoque.SubItems[5].Text = CustoTxt.Text;
            }

            if (listViewCardapio.SelectedItems.Count > 0)
            {
                ListViewItem itemSelecionadoCardapio = listViewCardapio.SelectedItems[0];

                foreach (ListViewItem item in listViewCardapio.Items)
                {
                    if (item != itemSelecionadoCardapio && item.SubItems[0].Text == CodigoTxt.Text)
                    {
                        MessageBox.Show("Já existe outro produto com este código no cardápio.");
                        return;
                    }
                }

                itemSelecionadoCardapio.SubItems[0].Text = CodigoTxt.Text;
                itemSelecionadoCardapio.SubItems[1].Text = DescricaoTxt.Text;
                itemSelecionadoCardapio.SubItems[2].Text = QuantidadeTxt.Text;
                itemSelecionadoCardapio.SubItems[3].Text = PrecoTxt.Text;

                MessageBox.Show("Item editado com sucesso no cardápio!");
            }
        }

        private void AdicionarcardapioBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CodigoTxt.Text) ||
                string.IsNullOrWhiteSpace(DescricaoTxt.Text) ||
                string.IsNullOrWhiteSpace(QuantidadeTxt.Text) ||
                string.IsNullOrWhiteSpace(PrecoTxt.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de adicionar.");
                return;
            }

            if (!int.TryParse(CodigoTxt.Text, out int codigo))
            {
                MessageBox.Show("Digite um código válido");
                return;
            }

            foreach (ListViewItem produto in listViewCardapio.Items)
            {
                if (produto.SubItems[0].Text == CodigoTxt.Text)
                {
                    MessageBox.Show("Já existe outro produto com este código no cardápio.");
                    return;
                }
            }

            if (!int.TryParse(QuantidadeTxt.Text, out int quantidade))
            {
                MessageBox.Show("Digite uma quantidade válida");
                return;
            }

            if (!decimal.TryParse(PrecoTxt.Text, out decimal preco))
            {
                MessageBox.Show("Digite um preço válido");
                return;
            }

            ListViewItem item = new ListViewItem(codigo.ToString());
            item.SubItems.Add(DescricaoTxt.Text);
            item.SubItems.Add(quantidade.ToString("N0"));
            item.SubItems.Add(preco.ToString("N2"));
            item.SubItems.Add("False");

            listViewCardapio.Items.Add(item);
        }

        private void adicionarEstoqueBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CodigoTxt.Text) || string.IsNullOrWhiteSpace(DescricaoTxt.Text) || string.IsNullOrWhiteSpace(QuantidadeTxt.Text) || string.IsNullOrWhiteSpace(PrecoTxt.Text) || string.IsNullOrWhiteSpace(DataValidadeTxt.Text) || string.IsNullOrWhiteSpace(CustoTxt.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de adicionar.");
                return;
            }
            if (!int.TryParse(CodigoTxt.Text, out int codigo))
            {
                MessageBox.Show("Digite um codigo valido");
                return;
            }

            if (!int.TryParse(QuantidadeTxt.Text, out int quantidade))
            {
                MessageBox.Show("digite uma quantidade valida");
                return;
            }

            if (!decimal.TryParse(PrecoTxt.Text, out decimal preco))
            {
                MessageBox.Show("digite um preco valido");
                return;
            }

            if (!decimal.TryParse(CustoTxt.Text, out decimal custo))
            {
                MessageBox.Show("digite um custo valido");
                return;
            }

            foreach (ListViewItem produto in listViewEstoque.Items)
            {
                if (produto.SubItems[0].Text == CodigoTxt.Text)
                {
                    MessageBox.Show("Já existe outro produto com este código no estoque.");
                    return;
                }
            }

            ListViewItem item = new ListViewItem(codigo.ToString());
            item.SubItems.Add(DescricaoTxt.Text);
            item.SubItems.Add(DataValidadeTxt.Text);
            item.SubItems.Add(quantidade.ToString());
            item.SubItems.Add(preco.ToString("F2"));
            item.SubItems.Add(custo.ToString("F2"));

            listViewEstoque.Items.Add(item);
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            string caminhoDoArquivo = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string localProdutosCardapio = Path.Combine(caminhoDoArquivo, "cardapio.txt");
            string localProdutosEstoque = Path.Combine(caminhoDoArquivo, "estoque.txt");
            string ischapa = isChapa.Checked.ToString().ToLower();

            if (isChapa.CheckState == CheckState.Checked)
            {
                string NovaLinhaCardapio = $"{CodigoTxt.Text};{DescricaoTxt.Text};{QuantidadeTxt.Text};{PrecoTxt.Text};true";
                File.AppendAllLines(localProdutosCardapio, new[] { NovaLinhaCardapio });
            }

            else 
            {
                string NovaLinhaCardapio = $"{CodigoTxt.Text};{DescricaoTxt.Text};{QuantidadeTxt.Text};{PrecoTxt.Text};false";
                File.AppendAllLines(localProdutosCardapio, new[] { NovaLinhaCardapio });
            }

            string novaLinhaEstoque = $"{CodigoTxt.Text};{DescricaoTxt.Text};{DataValidadeTxt.Text};{QuantidadeTxt.Text};{PrecoTxt.Text};{CustoTxt.Text}";
            File.AppendAllLines(localProdutosEstoque, new[] { novaLinhaEstoque });

            MessageBox.Show("Dados foram salvos");

            
        }
    }
}
