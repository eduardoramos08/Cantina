using System.Globalization;
using static CARDAPIO_POO.Pedido;

namespace CARDAPIO_POO;

public partial class Form1 : Form
{

    decimal total = 0;
    string nomeDoCliente = "";
    List<ItemPedido> produtos1 = new List<ItemPedido>();


    public Form1()
    {
        InitializeComponent();
    }
    private void CarregarCardapio()
    {
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

    private void SalvarCardapio()
    {
        List<string> linhas = new List<string>();

        foreach (ListViewItem item in listViewCardapio.Items)
        {
            var produto = (Produto)item.Tag;
            string linha = string.Join(";",
                produto.Codigo,
                produto.Descricao,
                produto.Quantidade,
                produto.Preco.ToString(CultureInfo.InvariantCulture),
                produto.IsChapa.ToString()
            );
            linhas.Add(linha);
        }

        File.WriteAllLines("cardapio.txt", linhas);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        comboBoxFormaPagamento.Items.AddRange(new string[] { "Dinheiro", "Cartão de Débito", "Cartão de Crédito", "Pix", "Vale Alimentação" });
        comboBoxFormaPagamento.SelectedIndex = 3;
        quantidadeTxt.Text = "1";

        CarregarCardapio();
    }


    private void adicionarBtn_Click(object sender, EventArgs e)
    {
        if (listViewCardapio.SelectedItems.Count == 0)
        {
            MessageBox.Show("Selecione o item do cardápio para adicionar.");
            return;
        }

        var itemSelecionado = listViewCardapio.SelectedItems[0];
        var produtoCardapio = (Produto)itemSelecionado.Tag;

        if (!int.TryParse(quantidadeTxt.Text, out int quantidadeDesejada) || quantidadeDesejada <= 0)
        {
            MessageBox.Show("Digite uma quantidade válida.");
            quantidadeTxt.Focus();
            return;
        }

        if (produtoCardapio.Quantidade < quantidadeDesejada)
        {
            MessageBox.Show($"Quantidade insuficiente no estoque. Estoque disponível: {produtoCardapio.Quantidade}");
            return;
        }

        if (produtoCardapio.Quantidade <= 5 && (produtoCardapio.Quantidade - quantidadeDesejada) < 5)
        {
            MessageBox.Show($"Aviso: Estoque de {produtoCardapio.Descricao.TrimEnd(' ', '-')} está acabando");
        }

        ListViewItem lviExistente = null;

        foreach (ListViewItem item in listViewCarrinho.Items)
        {
            if (item.Tag is ItemPedido ip && ip.ProdutoAdicionado.Codigo == produtoCardapio.Codigo)
            {
                ip.QuantidadeNoCarrinho += quantidadeDesejada;
                item.SubItems[1].Text = ip.QuantidadeNoCarrinho.ToString();
                item.SubItems[3].Text = (ip.ProdutoAdicionado.Preco * ip.QuantidadeNoCarrinho).ToString("F2");
                lviExistente = item;
                break;
            }
        }

        if (lviExistente == null)
        {
            var novoItem = new ItemPedido
            {
                ProdutoAdicionado = produtoCardapio,
                QuantidadeNoCarrinho = quantidadeDesejada
            };

            produtos1.Add(novoItem);

            var lviNovo = new ListViewItem(produtoCardapio.Descricao.TrimEnd(' ', '-'))
            {
                Tag = novoItem
            };

            lviNovo.SubItems.Add(quantidadeDesejada.ToString());
            lviNovo.SubItems.Add(produtoCardapio.Preco.ToString("F2"));
            lviNovo.SubItems.Add((produtoCardapio.Preco * quantidadeDesejada).ToString("F2"));

            listViewCarrinho.Items.Add(lviNovo);
        }

        total += produtoCardapio.Preco * quantidadeDesejada;
        totalTxt.Text = $"Total do Pedido: R$ {total:F2}";

        produtoCardapio.Quantidade -= quantidadeDesejada;
        itemSelecionado.SubItems[2].Text = produtoCardapio.Quantidade.ToString();

        quantidadeTxt.Text = "1";
    }
    private void removerBtn_Click(object sender, EventArgs e)
    {
        if (listViewCarrinho.SelectedItems.Count == 0)
        {
            MessageBox.Show("Selecione o item do carrinho.");
            return;
        }

        if (!int.TryParse(quantidadeTxt.Text, out int quantidade) || quantidade <= 0)
        {
            MessageBox.Show("Digite uma quantidade válida para remover.");
            quantidadeTxt.Focus();
            return;
        }

        var itemSelecionadoLVI = listViewCarrinho.SelectedItems[0];
        var itemCarrinho = (ItemPedido)itemSelecionadoLVI.Tag;

        if (quantidade > itemCarrinho.QuantidadeNoCarrinho)
        {
            MessageBox.Show($"Quantidade inválida. Máximo que pode ser removido: {itemCarrinho.QuantidadeNoCarrinho}");
            return;
        }

        total -= itemCarrinho.ProdutoAdicionado.Preco * quantidade;
        totalTxt.Text = $"Total do Pedido: R$ {total:F2}";

        itemCarrinho.QuantidadeNoCarrinho -= quantidade;
        itemSelecionadoLVI.SubItems[1].Text = itemCarrinho.QuantidadeNoCarrinho.ToString();
        itemSelecionadoLVI.SubItems[3].Text = (itemCarrinho.ProdutoAdicionado.Preco * itemCarrinho.QuantidadeNoCarrinho).ToString("F2");

        Produto produto = itemCarrinho.ProdutoAdicionado;
        produto.Quantidade += quantidade;

        foreach (ListViewItem lvi in listViewCardapio.Items)
        {
            if ((Produto)lvi.Tag is Produto p && p.Codigo == produto.Codigo)
            {
                lvi.SubItems[2].Text = p.Quantidade.ToString();
                break;
            }
        }

        if (itemCarrinho.QuantidadeNoCarrinho == 0)
        {
            listViewCarrinho.Items.Remove(itemSelecionadoLVI);
            produtos1.Remove(itemCarrinho);
        }

        AtualizarTroco();
    }

    private void finalizarBtn_Click(object sender, EventArgs e)
    {
        string dataHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        if (string.IsNullOrWhiteSpace(nomeDoCliente))
        {
            MessageBox.Show("Por favor, insira o nome do cliente.");
            nomeTxt.Focus();
            return;
        }

        if (listViewCarrinho.Items.Count == 0)
        {
            MessageBox.Show("O carrinho está vazio. Adicione itens para finalizar a compra.");
            return;
        }

        string formaPagamento = comboBoxFormaPagamento.SelectedItem.ToString();
        decimal valorRecebido = 0m;
        decimal troco = 0m;

        switch (formaPagamento)
        {
            case "Dinheiro":
                if (!decimal.TryParse(dinheiroRecebidoTxt.Text, out valorRecebido) || valorRecebido < total)
                {
                    MessageBox.Show("Valor recebido inválido ou insuficiente.");
                    dinheiroRecebidoTxt.Focus();
                    return;
                }
                troco = valorRecebido - total;
                break;

            case "Cartão de Débito":
            case "Cartão de Crédito":
            case "Pix":
            case "Vale Alimentação":
                dinheiroRecebidoTxt.Enabled = false;
                valorRecebido = total;
                break;
        }

        string itensCompradosStr = "Itens Comprados:\n";
        foreach (ListViewItem lvi in listViewCarrinho.Items)
        {
            ItemPedido item = (ItemPedido)lvi.Tag;
            itensCompradosStr += $"{item.ProdutoAdicionado.Descricao.TrimEnd(' ', '-')} - Qtd: {item.QuantidadeNoCarrinho} - Subtotal: R$ {(item.ProdutoAdicionado.Preco * item.QuantidadeNoCarrinho):F2}\n";
        }

        MessageBox.Show(
            $"Compra finalizada!\n\n" +
            $"Cliente: {nomeDoCliente}\n" +
            $"Data e Hora: {dataHora}\n" +
            $"Forma de Pagamento: {formaPagamento}\n" +
            $"\n{itensCompradosStr}\n" +
            $"Total: R$ {total:F2}\n" +
            (formaPagamento == "Dinheiro" ? $"Valor Recebido: R$ {valorRecebido:F2}\nTroco: R$ {troco:F2}" : ""),
            "Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information);



        Pedido pedido = new Pedido
        {
            Nome = nomeTxt.Text,
            carrinho = produtos1,
            date = DateTime.Now,
            Total = total,
            status = btnViagem.Checked ?
            (statusPedido)Enum.Parse(typeof(statusPedido), "Viagem") :
            (statusPedido)Enum.Parse(typeof(statusPedido), "Preparando"),
            FormaPagamento = comboBoxFormaPagamento.SelectedItem.ToString()

        };

        Repositorio.listaPedidos.Add(pedido);
        produtos1 = new List<ItemPedido>();
        LimparCampos();
        SalvarCardapio();   

    }

    private void quantidadeTxt_TextChanged(object sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(quantidadeTxt.Text))
        {
            if (!int.TryParse(quantidadeTxt.Text, out int quantidade) || quantidade < 0)
            {

            }
        }
    }

    private void LimparCampos()
    {

        total = 0;
        totalTxt.Text = "Seu total é R$ 0,00";
        listViewCarrinho.Items.Clear();
        dinheiroRecebidoTxt.Clear();
        Troco.Text = "R$ 0,00";
        nomeTxt.Clear();
        nomeDoCliente = "";
        quantidadeTxt.Text = "1";
        comboBoxFormaPagamento.SelectedIndex = 3;
    }



    private void dinheiroRecebido_TextChanged(object sender, EventArgs e)
    {
        AtualizarTroco();
    }

    private void AtualizarTroco()
    {
        decimal valorRecebido;

        if (string.IsNullOrWhiteSpace(dinheiroRecebidoTxt.Text))
        {
            Troco.Text = "R$ 0,00";
            return;
        }

        if (!decimal.TryParse(dinheiroRecebidoTxt.Text, out valorRecebido) || valorRecebido < 0)
        {
            Troco.Text = "Valor inválido";
            return;
        }

        if (valorRecebido < total)
        {
            Troco.Text = "Valor insuficiente.";
            return;
        }

        decimal trocoCalculado = valorRecebido - total;
        Troco.Text = "R$" + trocoCalculado.ToString("F2");
    }


    private void TrocoTxt_TextChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void nomeTxt_TextChanged(object sender, EventArgs e)
    {
        nomeDoCliente = nomeTxt.Text.Trim();
    }
    private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

    private void comboBoxFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBoxFormaPagamento.SelectedItem == null) return;

        string formaPagamento = comboBoxFormaPagamento.SelectedItem.ToString();

        if (formaPagamento == "Dinheiro")
        {
            dinheiroRecebidoTxt.Enabled = true;
            dinheiroRecebidoTxt.Visible = true;
            Troco.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            AtualizarTroco();
        }
        else
        {
            dinheiroRecebidoTxt.Enabled = false;
            dinheiroRecebidoTxt.Visible = false;
            Troco.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            dinheiroRecebidoTxt.Clear();
            Troco.Text = "R$ 0,00";
        }
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void cardapioTxt_Click(object sender, EventArgs e)
    {

    }

    private void Troco_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        FormBalcao formBalcao = new FormBalcao();
        formBalcao.Show();
    }

    private void btnViagem_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {

    }

    private void listViewCardapio_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void listViewCarrinho_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        FormCozinha formCozinha = new FormCozinha();
        formCozinha.ShowDialog();
    }

    private void btnTelaChamada_Click(object sender, EventArgs e)
    {
        FormTelaChamada formTelaChamada = new FormTelaChamada();
        formTelaChamada.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        FormEstoque formestoque = new FormEstoque();
        formestoque.ShowDialog();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        FormGestaoDeProdutos formGestaoDePedidos = new FormGestaoDeProdutos();
        formGestaoDePedidos.ShowDialog();
        CarregarCardapio();
    }

    

}


