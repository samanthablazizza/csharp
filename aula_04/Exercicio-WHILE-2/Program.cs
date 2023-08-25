namespace Exercicio_WHILE_2
{/*Escreva um algoritmo em C#, que leia a idade de várias pessoas (números inteiros), via teclado e mostre na tela o total de pessoas 
 cuja idade seja menor que 21 anos e o total de pessoas cuja idade, seja maior que 50 anos. A leitura dos dados deve ser finalizada 
 ao digitar uma idade negativa.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int idade = 0, menor = 0, maior = 0; 

            

            while (idade >= 0)
            {
                Console.WriteLine("Digite o seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade >=0 && idade< 21)
                    menor++;

                if (idade > 50)
                    maior++;     

            }

            Console.WriteLine($"A quantidade de pessoas menores de 21 anos é de: {menor}");
            Console.WriteLine($"A quantidade de pessoas maiores de 50 anos é de: {maior}");
        
        }
    }
}