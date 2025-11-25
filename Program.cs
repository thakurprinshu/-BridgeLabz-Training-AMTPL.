using basics.Collections;

class Program
{
    static void Main(string[] args)
    {
        Queue q = new Queue();

        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);
        q.Enqueue(40);

        Console.WriteLine("Original Queue:");
        q.Print();

        q.Reverse();

        Console.WriteLine("Reversed Queue:");
        q.Print();
    }
}
