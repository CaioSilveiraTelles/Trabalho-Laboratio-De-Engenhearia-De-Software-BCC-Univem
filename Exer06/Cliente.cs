namespace Exer06
{
    public class Cliente
    {
        private string nome;
        public string Nome
        {
            get
            {
                return this.nome;
            }
        }
        private string cpf;
        public string Cpf
        {
            get
            {
                return this.cpf;
            }
        }
        private int idade;
        public int Idade
        {
            get
            {
                return this.idade;
            }
        }
        
        public Cliente(string nome, string cpf, int idade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
        }

        public string DadosCliente()
        {
            return $"Nome: {this.nome}. CPF: {this.cpf}. Idade: {this.idade}";
        }
    }
}