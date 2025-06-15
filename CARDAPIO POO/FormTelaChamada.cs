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
    public partial class FormTelaChamada : Form
    {
        public FormTelaChamada()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormTelaChamada_Load(object sender, EventArgs e)
        {
            foreach (var pedidos in Repositorio.listaPedidos)
            {
                ListViewItem item = new ListViewItem(pedidos.Nome);
                item.Tag = pedidos;
                listViewPedidoPreparando.Items.Add(item);
            }
        }

        private void listViewPedidosPreparando_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMarcarConcluido_Click(object sender, EventArgs e)
        {
            if (listViewPedidoPreparando.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um pedido ");
                return;
            }

            ListViewItem itemselecionado = listViewPedidoPreparando.SelectedItems[0];
            Pedido pedidoselecionado = (Pedido)itemselecionado.Tag;

            ListViewItem itemfinalizado = new ListViewItem(pedidoselecionado.Nome);
            itemfinalizado.Tag = pedidoselecionado;
            listViewPedidosProntos.Items.Add(itemfinalizado);

            
        }
    }
}
