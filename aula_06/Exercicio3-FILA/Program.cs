using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace Exercicio3_FILA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();
            int opcao;
            string? cliente;

            while (true)
            {

            Console.WriteLine("******************************************************");
            Console.WriteLine("\n    1 - Adicionar cliente na fila    ");
            Console.WriteLine("    2 - Listar todos os clientes     ");
            Console.WriteLine("    3 - Retirar cliente da fila      ");
            Console.WriteLine("    0 - Sair                        \n");
            Console.WriteLine("******************************************************");
            Console.Write("\nEntre com a opção desejada: ");
            opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 0)
                {
                Console.WriteLine("\nPrograma Finalizado!");
                System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:

                        Console.Write("\nDigite o nome do cliente: ");
                        cliente = Console.ReadLine();
                        fila.Enqueue(cliente);

                        Console.WriteLine("Cliente adicionado com sucesso!");
                        break;

                    case 2:

                        Console.WriteLine("\nLista de clientes na fila: ");

                        foreach (var pessoa in fila)
                        {
                            Console.WriteLine(pessoa);
                        }
                        break;

                    case 3:
    
                        if (fila.Count == 0)
                        {
                            Console.WriteLine("\nA fila está vazia!");
                        }
                        else
                        {
                            fila.Dequeue();
                            Console.WriteLine("\nCliente removido da fila com sucesso!");
                        }
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;

                }    
            }
        }
    }
}


