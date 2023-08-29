namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Breno");
            pilha.Push("Eduardo");
            pilha.Push("Júlia");
            pilha.Push("Leonardo");
            pilha.Push("Gaspar");

            pilha.Pop();//tira o último elemento da pilha, no caso, o Gaspar

            foreach (var nome in pilha)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nQuem é o primeiro da pilha? " + pilha.Peek());
            Console.WriteLine("\nO Gaspar entrou na pilha? " + pilha.Contains("Gaspar"));
            Console.WriteLine("\nNúmero de pessoas na pilha? " + pilha.Count);
        }
    }
}