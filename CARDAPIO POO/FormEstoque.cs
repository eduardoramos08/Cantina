using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            var produtosNoEstoque = new List<Estoque>
    {
        new Estoque { Codigo = 1, Descricao = "Pão de queijo", DataValidade = "30/06", Quantidade = 20, Preco = 6, Custo = 4.00m },
        new Estoque { Codigo = 2, Descricao = "Coxinha", DataValidade = "30/06", Quantidade = 20, Preco = 5, Custo = 2.50m },
        new Estoque { Codigo = 3, Descricao = "Risole", DataValidade = "30/06", Quantidade = 20, Preco = 4, Custo = 2.50m },
        new Estoque { Codigo = 4, Descricao = "Esfiha de calabresa", DataValidade = "30/06", Quantidade = 20, Preco = 4.00m, Custo = 2.5m },
        new Estoque { Codigo = 5, Descricao = "Pastel de carne", DataValidade = "30/06", Quantidade = 20, Preco = 6.00m, Custo = 4.00m },
        new Estoque { Codigo = 6, Descricao = "Pastel de queijo", DataValidade = "30/06", Quantidade = 20, Preco = 6.50m, Custo = 4.50m },
        new Estoque { Codigo = 7, Descricao = "Hambúrguer simples", DataValidade = "30/06", Quantidade = 20, Preco = 8.00m, Custo = 5.00m },
        new Estoque { Codigo = 8, Descricao = "Hambúrguer com queijo", DataValidade = "30/06", Quantidade = 20, Preco = 9.00m, Custo = 6.00m },
        new Estoque { Codigo = 9, Descricao = "X - Tudo", DataValidade = "30/06", Quantidade = 20, Preco = 12.00m, Custo = 7.00m }
    };

            foreach (Estoque produtos in produtosNoEstoque)
            {
                ListViewItem item = new ListViewItem(produtos.Codigo.ToString());
                item.SubItems.Add(produtos.Descricao);
                item.SubItems.Add(produtos.DataValidade);
                item.SubItems.Add(produtos.Quantidade.ToString());
                item.SubItems.Add(produtos.Preco.ToString("F2"));
                item.SubItems.Add(produtos.Custo.ToString("F2"));

                item.Tag = produtos;
                listViewEstoque.Items.Add(item);
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
