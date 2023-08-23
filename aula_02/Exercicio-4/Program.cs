namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, calculo;

            Console.WriteLine("Informe o primeiro número: ");
            n1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            n2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe o terceiro número: ");
            n3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe o quarto número: ");
            n4 = Convert.ToSingle(Console.ReadLine());

            calculo = (n1 * n2) - (n3 * n4);
            Console.WriteLine("A diferença do produto entre os número 1 e 2 pelo produto dos números 3 e 4 é de: " + calculo);


        }
    }
}