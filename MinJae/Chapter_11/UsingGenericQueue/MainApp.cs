namespace MinJae.Chapter_11.UsingGenericQueue;

public class MainApp
{
    static void _Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        while (queue.Count > 0)
            Console.WriteLine(queue.Dequeue());
    }
}