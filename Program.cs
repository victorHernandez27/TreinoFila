using System;

namespace TreinoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            FilaPessoa filaPessoa = new FilaPessoa();
            do
            {
                Console.Clear();
                opcao = Menu();

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        filaPessoa.Push(InserirCliente());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        filaPessoa.Pop();                        
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        filaPessoa.Print();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Quantidade de pessoas na fila:" + filaPessoa.quantidade);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        filaPessoa.BuscaNome(BuscaNome());

                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Invalida!Tente Novamente!");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 6);
        }

        private static string BuscaNome()
        {
            string nomeBusca;
            Console.WriteLine("=====MENU BUSCA=====");
            Console.WriteLine("Digite o nome a ser buscado:");
            nomeBusca = Console.ReadLine();

            return nomeBusca;
        }

        private static Pessoa InserirCliente()
        {
            int senha = 0;
            string nome;
            Console.WriteLine("=====Ficha de Cliente=====");
            Console.WriteLine("Numero do senha:");
            senha = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();

            return new Pessoa(nome, senha); 
        }

        private static int Menu()
        {
            int opcaoMenu = 0;
            Console.WriteLine("=====MENU=====");
            Console.WriteLine("1-Inserir\n2-Remover\n3-Imprimir Fila\n4-Quantidade de Pessoas na Fila\n5-Buscar Por Nome\n6-sair");
            opcaoMenu = int.Parse(Console.ReadLine());

            return opcaoMenu;
        }
    }
}
