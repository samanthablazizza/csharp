using System;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Exercicio_1_VETOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]? vetor = new int[10];
            float soma = 0, media = 0;
            
            for (int indice = 0; indice < 10; indice++)
            {
                Console.Write($"vertor [{indice}] = ");
                vetor[indice] = Convert.ToInt32(Console.ReadLine());
                soma += vetor[indice];
                media = soma / 10;

            }
            Console.WriteLine("\n");
            for (int indice = 0; indice < 10; indice++)
            {

                if (indice % 2 != 0)
                   Console.WriteLine($"Está em um índice ímpar do vetor: {vetor[indice]}");
            }
            Console.WriteLine("\n");
            for (int indice = 0; indice < 10; indice++)
            {
                if (vetor[indice] % 2 == 0)
                    Console.WriteLine($"São elementos pares do vetor: {vetor[indice]}");
            }
            Console.WriteLine($"\nA soma dos elementos é: {soma}");            
            Console.WriteLine($"\nA média dos elementos é: {media}");
            
        }

    }

}
