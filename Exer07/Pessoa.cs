namespace Exer07
{
    public class Pessoa
    {
        private string nome;
        public string Nome
        {
            get
            {
                return this.nome;
            }
        }
        private Pessoa pai;
        public Pessoa Pai
        {
            get
            {
                return this.pai;
            }
            set
            {
                this.pai = value;
            }
        }
        private Pessoa mae;
        public Pessoa Mae
        {
            get
            {
                return this.mae;
            }
            set
            {
                this.mae = value;
            }
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
        }
    }
}