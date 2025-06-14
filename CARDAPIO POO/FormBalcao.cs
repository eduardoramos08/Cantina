﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CARDAPIO_POO;

namespace CARDAPIO_POO
{
    public partial class FormBalcao : Form
    {
        public FormBalcao()
        {
            InitializeComponent();

        }

        
            
        


        private void FormBalcao_Load(object sender, EventArgs e)
        {
            foreach (var pedido in Repositorio.listaPedidos)
            {

                {
                    ListViewItem item = new ListViewItem(pedido.Nome);
                    item.SubItems.Add(pedido.status.ToString());
                    item.SubItems.Add(pedido.date.ToString("dd/MM/yyyy HH:mm"));
                    item.Tag = pedido;
                    listViewPedidos.Items.Add(item);
                }
            }
        }

        private void btnMarcarConcluido_Click(object sender, EventArgs e)
        {
            if (listViewPedidos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um pedido para finalizar.");
                return;
            }


            ListViewItem itemSelecionado = listViewPedidos.SelectedItems[0];
            Pedido pedidoSelecionado = (Pedido)itemSelecionado.Tag;

            pedidoSelecionado.status = Pedido.statusPedido.Finalizado;

            

            ListViewItem itemFinalizado = new ListViewItem(pedidoSelecionado.Nome);
            itemFinalizado.SubItems.Add(pedidoSelecionado.status.ToString());
            itemFinalizado.SubItems.Add(pedidoSelecionado.date.ToString("dd/MM/yyyy HH:mm"));
            itemFinalizado.Tag = pedidoSelecionado;

            listViewFinalizados.Items.Add(itemFinalizado);
        }




        private void btnVerDetalhes_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = null;

            if (listViewPedidos.SelectedItems.Count > 0)
            {
                pedidoSelecionado = (Pedido)listViewPedidos.SelectedItems[0].Tag;
            }

            else if (listViewFinalizados.SelectedItems.Count > 0)
            {
                pedidoSelecionado = (Pedido)listViewFinalizados.SelectedItems[0].Tag;
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
                detalhes += $" - {item.ProdutoAdicionado.Descricao.TrimEnd(' ', '-')} | Qtde: {item.QuantidadeNoCarrinho} | Subtotal: R$ {(item.ProdutoAdicionado.Preco * item.QuantidadeNoCarrinho):F2}\n";
            }

            detalhes += $"\nTotal: R$ {pedidoSelecionado.Total:F2}";

            MessageBox.Show(detalhes, "Detalhes do Pedido");
        }

        private void listViewPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewFinalizados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
