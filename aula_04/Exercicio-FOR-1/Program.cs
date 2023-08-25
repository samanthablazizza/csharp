using System.ComponentModel.Design;

namespace Exercicio_FOR_1
{/*Escreva um algoritmo em C#, que leia 10 números inteiros via teclado e mostre na tela quantos números 
 são pares e quantos número são ímpares.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int inteiro, numero, par = 0, impar = 0;

            for (inteiro = 1; inteiro <= 10; inteiro++)
            {
                Console.Write($"Digite o {inteiro}º número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                    par = par + 1;

                else
                    impar = impar + 1;
            }

                Console.WriteLine($"A quantidade de números pares é de: {par}");
                Console.WriteLine($"A quantidade de números ímpares é de: {impar}");
            
        }
                
    }
}