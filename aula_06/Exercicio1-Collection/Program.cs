namespace Exercicio1_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> cores = new List<string>();           

            Console.WriteLine("Digite cinco cores: ");
            for (var indice = 0; indice < 5; indice++)
            {
                string? cor;
                cor = Console.ReadLine();
                cores.Add(cor);
            }

            cores.Sort();//ordena os elementos na ordem crescente
            Console.WriteLine();

            foreach (var cor in cores)
            {
                Console.WriteLine(cor);
            }

        }
    }
}