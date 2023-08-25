using System.Runtime.Intrinsics.X86;

namespace Exercicio_2
{/*Para doar sangue é necessário ter entre 18 e 69 anos. Pessoas com idade entre 60 e 69 anos, só podem doar se não for a sua primeira
doação. Escreva um Algoritmo em C# que obtenha via teclado o nome do doador (string), a idade (inteiro) do doador e se é a primeira
doação (bool). Conforme as Regras para a doação, mostre na tela se o doador está Apto ou Não Apto para doar sangue*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int idade;
            bool primeiraDoacao;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine($"Olá {nome}, seja bem vinde!");

            Console.WriteLine("Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("É a primeira vez que você doa sangue?");
            Console.WriteLine("true - sim");
            Console.WriteLine("false - não");
            primeiraDoacao = Convert.ToBoolean(Console.ReadLine());


            if (idade >= 18 && idade <= 60)
            {
                Console.WriteLine($"{nome}, você está apto(a) a doar sangue");
            }
            else if (idade > 60 && idade <= 69 && primeiraDoacao == true)
            {
                Console.WriteLine($"{nome}, você NÃO está apto(a) a doar sangue");
            }
            else if (idade > 60 && idade <= 69 && primeiraDoacao == false)
            {
                Console.WriteLine($"{nome}, você está apto(a) a doar sangue");
            }
            else
            {
                Console.WriteLine($"{nome}, você NÃO está apto(a) a doar sangue");
            }

            {

            }
        }
    }
}


