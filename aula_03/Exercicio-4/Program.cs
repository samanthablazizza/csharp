using System.Runtime.Intrinsics.X86;

namespace Exercicio_4
{/*O programa deverá ler dois números float: numero1 e numero2, e na sequência ler o Código da operação matemática 
(número inteiro de 1 a 4). A seguir, mostre na tela o resultado da operação entre os 2 números. Caso a operação seja diferente do 
intervalo 1 a 4, mostre a mensagem Operação Inválida!*/
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2;
            int? op;

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.WriteLine("Digite o número referente à operação que deseja realizar: ");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine($"O resultado da soma é: {numero1 + numero2}");
                    break;

                case 2:
                    Console.WriteLine($"O resultado da subtração é: {numero1 - numero2}");
                    break;

                case 3:
                    Console.WriteLine($"O resultado da multiplicação é: {numero1 * numero2}");
                    break;

                case 4:
                    Console.WriteLine($"O resultado da divisão é: {numero1 / numero2}");
                    break;

                default:
                    Console.WriteLine("Operação Inválida!");
                    break;

            }


        }
    }
}