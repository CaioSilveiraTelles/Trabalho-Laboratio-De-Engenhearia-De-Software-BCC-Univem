namespace Exer06
{
    public class Item
    {
        private Produto produto;
        public Produto Produto
        {
            get
            {
                return this.produto;
            }
        }
        private int quantidade;
        public int Quantidade
        {
            get
            {
                return this.quantidade;
            }
        }
        public Item(Produto produto, int quantidade)
        {
            this.produto = produto;
            this.quantidade = quantidade;
        }

    }
}