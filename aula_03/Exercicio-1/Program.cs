namespace Exercicio_1
{/*Algoritmo que leia um número inteiro via teclado e mostre na tela uma mensagem indicando se este número é par ou ímpar e se o número é
 positivo ou negativo*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
  

            if (numero % 2 == 0 && numero >=0) 
            {
                Console.WriteLine($"{numero} é um número par e positivo!");
            }
            else if (numero % 2 == 0 && numero < 0)
            {
                Console.WriteLine($"{numero} é um número par e negativo!");
            }
            else if (numero % 2 != 0 && numero >= 0)
            {
                Console.WriteLine($"{numero} é um número ímpar e positivo!");
            }
            else
            {
                Console.WriteLine($"{numero} é um número ímpar e negativo!");
            }
                


        }
    }
}