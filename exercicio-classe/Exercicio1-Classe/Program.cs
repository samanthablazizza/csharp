using Exercicio1_Classe.Classe1;

namespace Exercicio1_Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            classeCliente cliente = new classeCliente( 123, "Helena", 28 , "Indígena", "Desenvolvedora de Software");

            cliente.Visualizar();
        }
    }
}