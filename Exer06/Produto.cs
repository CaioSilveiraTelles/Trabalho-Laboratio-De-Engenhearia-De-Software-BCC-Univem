namespace Exer06
{
    public class Produto
    {
        private string descricao;
        public string Descricao
        {
            get
            {
                return this.descricao;
            }
        }
        private double preco;

        public double Preco
        {
            get
            {
                return this.preco;
            }
        }
        private int estoque;

        public int Estoque
        {
            get
            {
                return this.estoque;
            }
            set
            {
                this.estoque = value;
            }
        }

        public Produto(string descricao, double preco, int estoque)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.estoque = estoque;
        }

        public string MostrarProduto()
        {
            return $"Descrição: {this.descricao}\tPreço: {string.Format("R$ {0,0:###,###.00}",this.preco)}\tQtd. Estoque: {this.estoque}";
        }
    }
}