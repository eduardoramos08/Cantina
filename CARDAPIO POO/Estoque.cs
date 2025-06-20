using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARDAPIO_POO
{
    public class Estoque
    {
        private int codigo;
        private string descricao;
        private int quantidade;
        private decimal preco;
        private decimal custo;
        private string dataValidade;


        public Estoque()
        {
            codigo = 0;
            descricao = string.Empty;
            quantidade = 0;
            preco = 0;
            custo = 0;
            dataValidade = string.Empty;

        }

        public Estoque(int codigo, string descricao, int quantidade, decimal preco, decimal custo, double total, string dataValidade)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.preco = preco;
            this.custo = custo;
            this.dataValidade = dataValidade;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public decimal Custo
        {
            get { return custo; }
            set { custo = value; }
        }
        public string DataValidade
        {
            get { return dataValidade; }
            set { dataValidade = value; }
        }

        public override string ToString()
        {
            return $"{Codigo} - {Descricao} / {DataValidade} / {Quantidade} un. - Preço: {Preco:F2} | Custo: {Custo:F2}";
        }
    }
}
