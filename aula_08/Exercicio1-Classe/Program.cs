using Exercicio1_Classe.Classe1;

namespace Exercicio1_Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            classeCliente cliente = new classeCliente( 123, "Helena", 28 , "Indígena", "Desenvolvedora de Software");

            cliente.Visualizar();

            PessoaFisica fisica = new PessoaFisica("123456789-12", "9 9999-9999");

            fisica.Visualizar();

            PessoaJuridica juridica = new PessoaJuridica("XX.XXX.XXX/0001-XX", "Empresa de Mentira");

            juridica.Visualizar();
        }
    }
}