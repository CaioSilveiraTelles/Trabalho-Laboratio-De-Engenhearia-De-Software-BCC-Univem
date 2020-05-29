using System;

namespace Exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculos[] veiculos = new Veiculos[1000];
            int contVeiculos = 0;

            CabinePedagio[] cabines = new CabinePedagio[1000];
            int contCabines = 0;

            string opcao = "";

            do
            {   
                Console.WriteLine("1 - Criar Automóvel");
                Console.WriteLine("2 - Criar Caminhão");
                Console.WriteLine("3 - Criar Motocicleta");
                Console.WriteLine("4 - Criar Cabine Pedágio");
                Console.WriteLine("5 - Listar Automóveis");
                Console.WriteLine("6 - Listar Cabines Pedágio");
                Console.WriteLine("7 - Passar Veículo (escolher veículo e cabine)");
                Console.WriteLine("8 - Sair");
                opcao = Console.ReadLine();

                if(opcao == "1" || opcao == "2" || opcao == "3")
                {
                    Console.WriteLine("Digite a placa:");
                    string placa = Console.ReadLine();

                    int numEixos = 0;
                    if(opcao != "3")
                    {
                        Console.WriteLine("Digite o número de eixos:");
                        numEixos = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("Digite o saldo do veículo:");
                    double saldo = Convert.ToDouble(Console.ReadLine());

                    switch(opcao)
                    {
                        case "1":
                        {
                            veiculos[contVeiculos++] = new Automovel(placa, numEixos, saldo);
                            break;
                        }
                        case "2":
                        {
                            veiculos[contVeiculos++] = new Caminhao(placa, numEixos, saldo);
                            break;
                        }
                        case "3":
                        {
                            veiculos[contVeiculos++] = new Motocicleta(placa, saldo);
                            break;
                        }
                    }
                }
                else if(opcao == "4")
                {
                    Console.WriteLine("Digite o valor por eixo:");
                    double valorEixo = Convert.ToDouble(Console.ReadLine());
                    cabines[contCabines++] = new CabinePedagio(valorEixo);
                }
                else if(opcao == "5")
                {
                    Console.WriteLine("Listar Veículos");
                    for(int i = 0; i < contVeiculos; i++)
                    {
                        Console.WriteLine($"{i} - Tipo: {veiculos[i].GetType()}\tPlaca: {veiculos[i].GetPlaca()}\tNum. Eixos: {veiculos[i].GetNumEixos()}\tSaldo: {veiculos[i].GetSaldo()}");
                    }
                }
                else if(opcao == "6")
                {
                    Console.WriteLine("Listar Cabines");
                    for(int i = 0; i < contCabines; i++)
                    {
                        Console.WriteLine($"{i} - Valor Eixo: {cabines[i].GetValorEixo()}\t Saldo: {cabines[i].GetSaldo()}");
                    }
                }
                else if(opcao == "7")
                {
                    Console.WriteLine("Escolha uma cabine de pedágio:");
                    int cabine = Convert.ToInt32(Console.ReadLine());

                    if(cabine >= contCabines)
                    {
                        Console.WriteLine("Cabine inválida");
                    }
                    else
                    {
                        Console.WriteLine("Escolha uma veículo:");
                        int veiculo = Convert.ToInt32(Console.ReadLine());

                        if(veiculo >= contVeiculos)
                        {
                            Console.WriteLine("Veículo inválido");
                        }
                        else
                        {
                            if(!cabines[cabine].Pedagio(veiculos[veiculo]))
                            {
                                Console.WriteLine("Saldo do veículo não é o suficiente.");
                            }
                        }
                    }                    
                }
            }while(opcao != "8");
        }
    }
}