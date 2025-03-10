namespace z532512345
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TwoWayLists<int> test=new TwoWayLists<int>();
            test.AddFirst(5);
            test.AddLast(4);
            test.AddLast(3);
            test.AddLast(2);
            Reverse<int>.Print(test);
            Reverse<int>.Reverser(test.head);
            Reverse<int>.Print(test);
        }
     
    }
}
