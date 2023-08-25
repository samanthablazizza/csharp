namespace Exercicio_3
{/*leia o Nome do Colaborador (string), o Código do Cargo do Colaborador (número inteiro de 1 a 6) e o Salário (número float).
  A seguir, mostre na tela o Nome do Colaborador, o Cargo e o novo Salário reajustado.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            float? salario, reajuste, novoSalario;
            int? cargo;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("1 - Gerente");
            Console.WriteLine("2 - Vendedor");
            Console.WriteLine("3 - Supervisor");
            Console.WriteLine("4 - Motorista");
            Console.WriteLine("5 - Estoquista");
            Console.WriteLine("6 - Técnico de TI");

            Console.WriteLine("Digite o número referente ao seu cargo: ");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o seu salario: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    reajuste = (salario * 10) / 100;
                    break;
                case 2:
                    reajuste = (salario * 7) / 100;
                    break;
                case 3:
                    reajuste = (salario * 9) / 100;
                    break;
                case 4:
                    reajuste = (salario * 6) / 100;
                    break;
                case 5:
                    reajuste = (salario * 5) / 100;
                    break;
                case 6:
                    reajuste = (salario * 8) / 100;
                    break;
                default:
                    reajuste = (salario * 12) / 100;
                    break;
            }
            novoSalario = salario + reajuste;
            Console.WriteLine($"{nome}, o cargo {cargo} teve o salário reajustado para R$ {novoSalario}");

        }
    }
}