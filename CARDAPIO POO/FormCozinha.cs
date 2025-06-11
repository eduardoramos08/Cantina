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
    public partial class FormCozinha : Form
    {
        public FormCozinha()
        {
            InitializeComponent();
        }

        private void btnMarcarConcluido_Click(object sender, EventArgs e)
        {
            if (listViewPedidosCozinha.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um pedido para finalizar.");
                return;
            }


            ListViewItem itemSelecionado = listViewPedidosCozinha.SelectedItems[0];
            Pedido pedidoSelecionado = (Pedido)itemSelecionado.Tag;

            pedidoSelecionado.status = Pedido.statusPedido.Cozinha_Finalizou;


            ListViewItem itemFinalizado = new ListViewItem(pedidoSelecionado.Nome);
            itemFinalizado.SubItems.Add(pedidoSelecionado.status.ToString());
            itemFinalizado.SubItems.Add(pedidoSelecionado.date.ToString("dd/MM/yyyy HH:mm"));
            itemFinalizado.Tag = pedidoSelecionado;

            listViewFinalizadoCozinha.Items.Add(itemFinalizado);
        }




        private void listViewPedidosCozinha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void btnVerDetalhes_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = null;

            if (listViewPedidosCozinha.SelectedItems.Count > 0)
            {
                pedidoSelecionado = (Pedido)listViewPedidosCozinha.SelectedItems[0].Tag;
            }

            else if (listViewFinalizadoCozinha.SelectedItems.Count > 0)
            {
                pedidoSelecionado = (Pedido)listViewFinalizadoCozinha.SelectedItems[0].Tag;
            }
            else
            {
                MessageBox.Show("Selecione um pedido para ver os detalhes.");
                return;
            }

            string detalhes = $"Cliente: {pedidoSelecionado.Nome}\n";
            detalhes += $"Data: {pedidoSelecionado.date:dd/MM/yyyy HH:mm}\n";
            detalhes += $"Status: {pedidoSelecionado.status}\n";
            detalhes += $"Forma de Pagamento: {pedidoSelecionado.FormaPagamento}\n";
            detalhes += $"\nItens:\n";

            foreach (var item in pedidoSelecionado.carrinho)
            {
                if (item.ProdutoAdicionado.IsChapa)
                {
                    detalhes += $" - {item.ProdutoAdicionado.Descricao.TrimEnd(' ', '-')} | Qtde: {item.QuantidadeNoCarrinho} | Subtotal: R$ {(item.ProdutoAdicionado.Preco * item.QuantidadeNoCarrinho):F2}\n";
                }
            }

            MessageBox.Show(detalhes, "Detalhes do Pedido");
        }

        private void listViewFInalizadoCozinha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCozinha_Load(object sender, EventArgs e)
        {
            foreach (var pedido in Repositorio.listaPedidos)
            {
                if (pedido.status != Pedido.statusPedido.Preparando && pedido.status != Pedido.statusPedido.Viagem)
                    continue;

                bool temItemDaChapa = pedido.carrinho.Any(item => item.ProdutoAdicionado.IsChapa);

                if (temItemDaChapa)
                {
                    ListViewItem lvi = new ListViewItem(pedido.Nome);
                    lvi.SubItems.Add(pedido.status.ToString());
                    lvi.SubItems.Add(pedido.date.ToString("HH:mm:ss"));
                    lvi.Tag = pedido;
                    listViewPedidosCozinha.Items.Add(lvi);
                }
            }
            
        }
    }
}
