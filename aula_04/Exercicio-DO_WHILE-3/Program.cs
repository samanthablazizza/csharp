namespace Exercicio_DO_WHILE_3
{/*Escreva um algoritmo em C#, que leia números inteiros via teclado, até que o número zero seja digitado. Ao final, mostre na tela
  a soma de todos os números digitados, que sejam positivos.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, soma = 0;

            do
            {
                Console.WriteLine("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero > 0)
                    soma += numero;
            }
            while           
               (numero != 0);
                                
            Console.WriteLine($"A soma dos números positivos é de: {soma}");
        }
    }
}