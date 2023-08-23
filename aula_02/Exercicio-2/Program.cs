using System;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, media;

            Console.WriteLine("Informe o valor da sua primeira nota: ");
            nota1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe o valor da sua segunda nota: ");
            nota2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe o valor da sua terceira nota: ");
            nota3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe o valor da sua quarta nota: ");
            nota4 = Convert.ToSingle(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("Sua média final é de: " + media);

        }
    }
}