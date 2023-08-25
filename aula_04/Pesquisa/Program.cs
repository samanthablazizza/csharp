namespace Pesquisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome, continua = "S";
            int idade, esporte, futebol = 0, voleiM18 =0, basqueteMen18=0;

            do
            {
                Console.WriteLine("Digite o seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine("Digite o seu esporte favorito: (1 - Futebol/2 - Vôlei/3 - Basquete/4 - Outros)");
                    esporte = Convert.ToInt32(Console.ReadLine());
                }
                while (esporte < 1 || esporte > 4);

                if (esporte == 1)
                    futebol++;

                if (esporte == 2)
                    voleiM18++;

                if (esporte == 3)
                    basqueteMen18++;

                Console.WriteLine("Deseja Continuar (S/N) ");
                continua = Console.ReadLine().ToUpper();

            } while(continua.Equals("S"));

            Console.WriteLine($"Total de pessoas que gostam de futebol: {futebol}");
            Console.WriteLine($"Total de pessoas que gostam de vôlei maiores de 18 anos: {voleiM18}");
            Console.WriteLine($"Total de pessoas que gostam de basquete menores de 18 anos: {basqueteMen18}");
        }
    }
}