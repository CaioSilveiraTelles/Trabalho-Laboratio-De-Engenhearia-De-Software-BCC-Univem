namespace Exer06
{
    public class Pedido
    {
        private int contItens = 0;
        public int ContItens
        {
            get
            {
                return this.contItens;
            }
        }
        private Item[] itens;
        public Item[] Itens
        {
            get
            {
                return this.itens;
            }
        }        
        private Cliente cliente;
        public Cliente Cliente
        {
            get
            {
                return this.cliente;
            }
        }        

        public Pedido(Cliente cliente, int maxItens)
        {
            this.cliente = cliente;
            this.itens = new Item[maxItens];
        }

        public void SetItem(Produto produto, int quantidade)
        {
            itens[contItens] = new Item(produto, quantidade);
            contItens++;
        }

        public double ValorTotal()
        {
            double valorTotal = 0;

            for(int i = 0; i < itens.Length; i++)
            {
                valorTotal += itens[i].Produto.Preco * itens[i].Quantidade;
            }

            return valorTotal;
        }
    }
}