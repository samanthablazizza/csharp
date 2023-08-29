namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Breno");
            fila.Enqueue("Eduardo");
            fila.Enqueue("Júlia");
            fila.Enqueue("Leonardo");
            fila.Enqueue("Gaspar");

            fila.Dequeue();//tira o primeiro elemento da fila, no caso, o Breno

            foreach (var nome in fila)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nQuem é o primeiro da fila? " + fila.Peek());
            Console.WriteLine("\nO Gaspar entrou na fila? " + fila.Contains("Gaspar"));
            Console.WriteLine("\nNúmero de pessoas na fila? " + fila.Count);
        }
    }
}