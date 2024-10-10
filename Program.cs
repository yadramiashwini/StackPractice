namespace StackPractice
{
    internal class stack
    {
        static void Main(string[] args)
        {
           var names = new Stack<string>();
            names.Push("ash");
            names.Push("pooja");
            names.Push("sonyyy");
            names.Push("bhagya");
            Console.WriteLine("names present in stack are:");
            foreach (var name in names)
            {
               
                Console.WriteLine(name);
            }

            Console.WriteLine("last element is:"+names.Peek());
            Console.WriteLine("popping element is:"+names.Pop());
            Console.WriteLine("after popping elements are:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-------------------------------");
            var names1 = new Queue<string>();
            names1.Enqueue("ashwini");
            names1.Enqueue("spanadana");
            names1.Enqueue("samarth");
            Console.WriteLine("displaying queue elements:");
            foreach(var names2 in names1)
            {
                Console.WriteLine(names2);
            }
            Console.WriteLine("last element is:"+names1.Peek());
            Console.WriteLine("dequeuing element is:"+names1.Dequeue());
            Console.WriteLine("displaying after dequeing elements are:");
            foreach (var names2 in names1)
            {
                Console.WriteLine(names2);
            }

        }
    }
}
