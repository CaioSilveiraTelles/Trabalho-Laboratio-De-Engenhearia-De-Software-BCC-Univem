using System;
using Figgle;

namespace Exer06
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] arrayProdutos = new Produto[1000];
            int contProduto = 0;

            string opcao = "";
            string opcao2 = "";

            Console.WriteLine(FiggleFonts.Standard.Render("Supermercado 0 ou 1"));
            do
            {
                Console.WriteLine("1  - Cadastrar Produtos");
                Console.WriteLine("2  - Fazer Venda");
                Console.WriteLine("99 - Sair");

                opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                    {
                        Console.WriteLine("Informe o nome do produto:");
                        string descricao = Console.ReadLine();

                        Console.WriteLine("Informe o preço do produto:");
                        double preco = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de estoque do produto:");
                        int quantidade = Convert.ToInt32(Console.ReadLine());

                        arrayProdutos[contProduto] = new Produto(descricao, preco, quantidade);
                        contProduto++;
                        break;
                    }
                    case "2":
                    {
                        if(contProduto > 0)
                        {
                            Console.WriteLine("Informe o nome do cliente:");
                            string nome = Console.ReadLine();

                            Console.WriteLine("Informe o CPF do cliente:");
                            string cpf = Console.ReadLine();

                            Console.WriteLine("Informe a idade do cliente:");
                            int idade = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Quantos itens deseja comprar?");
                            int maxItens = Convert.ToInt32(Console.ReadLine());

                            Cliente cliente = new Cliente(nome, cpf, idade);
                            Pedido pedido = new Pedido(cliente, maxItens);

                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("---------- Produtos disponíveis ----------");
                            Console.WriteLine("------------------------------------------");

                            for(int i = 0; i < contProduto; i++)
                            {
                                Console.WriteLine(arrayProdutos[i].MostrarProduto());
                            }

                            do
                            {
                                Console.WriteLine("1  - Escolher um produto");                            
                                Console.WriteLine("2  - Confirmar venda"); 
                                Console.WriteLine("99 - Sair");
                                opcao2 = Console.ReadLine();

                                switch(opcao2)
                                {
                                    case "1":
                                    {
                                        Console.WriteLine("Digite a descrição exata do produto:");
                                        string nomeProduto = Console.ReadLine();

                                        Console.WriteLine("Digite a quantidade produto:");
                                        int quantidade = Convert.ToInt32(Console.ReadLine());

                                        for(int i = 0; i < contProduto; i++)
                                        {
                                            if(arrayProdutos[i].Descricao == nomeProduto)
                                            {
                                                if(arrayProdutos[i].Estoque >= quantidade)
                                                {
                                                    arrayProdutos[i].Estoque = arrayProdutos[i].Estoque - quantidade;
                                                    pedido.SetItem(arrayProdutos[i], quantidade);
                                                    Console.WriteLine("Item incluido com sucesso!");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Quantidade no estoque não disponível");
                                                    break;
                                                }
                                            }
                                        }

                                        Console.WriteLine("------------------------------------------");
                                        Console.WriteLine("---------- Produtos disponíveis ----------");
                                        Console.WriteLine("------------------------------------------");

                                        for(int i = 0; i < contProduto; i++)
                                        {
                                            Console.WriteLine(arrayProdutos[i].MostrarProduto());
                                        }

                                        break;
                                    } 
                                    case "2":
                                    {
                                        Console.WriteLine(FiggleFonts.Standard.Render("Extrato"));

                                        Console.WriteLine(FiggleFonts.Standard.Render("Cliente"));
                                        Console.WriteLine(pedido.Cliente.DadosCliente());

                                        Console.WriteLine(FiggleFonts.Standard.Render("Produtos"));
                                        for(int i = 0; i < pedido.ContItens; i++)
                                        {
                                            Console.WriteLine($"Produto: {pedido.Itens[i].Produto.Descricao}\tQuantidade: {pedido.Itens[i].Quantidade}");
                                        }

                                        Console.WriteLine(FiggleFonts.Standard.Render("Valor Total"));
                                        Console.WriteLine(string.Format("R$ {0,0:###,###.00}", pedido.ValorTotal()));
                                        opcao2 = "99";

                                        break;
                                    }

                                }
                            }while(opcao2 != "99");
                        }
                        else
                        {
                            Console.WriteLine("Cadastre primeiro algum produto para fazer a venda!");
                        }
                        break;
                    }
                }
            }while(opcao != "99");
        }
    }
}
