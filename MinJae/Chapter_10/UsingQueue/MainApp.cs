namespace MinJae.Chapter_10.UsingQueue;
using System.Collections;

public class MainApp
{
    static void _Main(string[] args)
    {
        Queue que = new Queue();
        que.Enqueue(1);
        que.Enqueue(2);
        que.Enqueue(3);
        que.Enqueue(4);
        que.Enqueue(5);

        while (que.Count > 0)
            Console.WriteLine(que.Dequeue());
    }
}