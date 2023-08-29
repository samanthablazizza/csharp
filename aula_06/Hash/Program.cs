namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setNomes = new HashSet<string>()
            {
                "Allan",
                "Robson",
                "João",
                "Ingrid",
                "Allan",
                "Robson",
            };

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            setNomes.Add("Samantha");
            setNomes.Add(null);//adicona elementos nulos
            setNomes.Add("Júlia");

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nO nome Júlia existe? " + setNomes.Contains("Júlia"));

            setNomes.Remove("João");
            Console.WriteLine();

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            List<string> hashlist = setNomes.ToList();//para ordenar pode ser necessário converter para uma list,
                                                      //quando não for necessário é possível usar o Sorted.Set

            hashlist.Sort();

            foreach (var hash in hashlist)
            {
                Console.WriteLine(hash);
            }
        }
    }
}