using Exercicio_Produto.Classe2;

namespace Exercicio_Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            classeProduto produto = new classeProduto("Notebook", "Intel Core i7", "8GB RAM 256SSD", "Asus", 2950);

            produto.Visualizar();

          
        }
    }
}