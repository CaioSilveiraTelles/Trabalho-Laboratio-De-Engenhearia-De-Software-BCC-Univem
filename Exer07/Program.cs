using System;

namespace Exer07
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = SetPessoa();
            Console.WriteLine("-------------------------");
            GetPessoa(pessoa);
        }

        static Pessoa SetPessoa()
        {
            Pessoa pessoa;
            
            Console.WriteLine($"Digite o nome da pessoa!");
            string nome = Console.ReadLine();
            pessoa = new Pessoa(nome);

            Console.WriteLine($"Incluir dados da Mãe do(a) {nome}? S - Sim");
            string op1 = Console.ReadLine();
            if(op1.Equals("S"))
            {   
                pessoa.Mae = SetPessoa();
            }

            Console.WriteLine($"Incluir dados do Pai do(a) {nome}? S - Sim");
            string op2 = Console.ReadLine();
            if(op2.Equals("S"))
            {
                pessoa.Pai = SetPessoa();
            }

            return pessoa;            
        }

        static void GetPessoa(Pessoa pessoa)
        {
            Console.WriteLine(pessoa.Nome);

            if(pessoa.Mae != null)
            {
                Console.Write($"Mãe de {pessoa.Nome} -> ");
                GetPessoa(pessoa.Mae);
            }

            if(pessoa.Pai != null)
            {
                Console.Write($"Pai de {pessoa.Nome} -> ");
                GetPessoa(pessoa.Pai);
            }         
        }
    }
}
