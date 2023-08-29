namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();

            //adicionar novos elementos
            notas.Add(7.0);
            notas.Add(5.0);
            notas.Add(4.0);
            notas.Add(7.0);
            notas.Add(10.0);

            foreach (double nota in notas)//lista todos os elementos
            {
                Console.WriteLine(nota);
            }
            Console.WriteLine("\nPosição da nota 4.0: " + notas.IndexOf(4.0));

            Console.WriteLine("\nA nota 4.0 existe? " + notas.Contains(4.0));//checar se o elemento existe

            notas.Remove(4.0);//remove o 4.0 da lista
            Console.WriteLine();

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }
            Console.WriteLine("\nPosição da nota 10.0: " + notas.IndexOf(10.0));//na primeira lista é uma posição,
                                                                                //após remover o 4.0 o 10. muda de posição
        
            Console.WriteLine("\nQuantos elementos tem a lista: " + notas.Count);//tamanho da lista

            notas.Sort();//ordena os elementos na ordem crescente
            Console.WriteLine();

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            notas.Reverse();//ordena os elementos na ordem decrescente
            Console.WriteLine();

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            notas[0] = 9.0;//troca a nota que está no índice 0, no caso o 10.0, pela nota 9.0
            Console.WriteLine();

            foreach (var nota in notas)//var cria um tipo de dado implícito, se a variável notaS é do tipo double a variável nota também será double
            {
                Console.WriteLine(nota);
            }

        }

    }
}