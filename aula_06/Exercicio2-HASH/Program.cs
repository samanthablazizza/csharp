namespace Exercicio2_HASH
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> numeros = new HashSet<int>();

            Console.WriteLine("Digite 10 números inteiros: ");
            for (var indice = 0; indice < 10; indice++)
            {
                int numero = 0;
                numero = Convert.ToInt32(Console.ReadLine());
                numeros.Add(numero);

            }
            Console.WriteLine();
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}