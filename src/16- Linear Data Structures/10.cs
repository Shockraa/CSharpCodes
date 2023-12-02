using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Give N");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Give M");
        int M = int.Parse(Console.ReadLine());

        DoSequence(N, M);
    }

    static void DoSequence(int N, int M)
    {
        int current = 0;

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(N);

        while (current != M)
        {
            current = queue.Dequeue();
            Console.Write(current + " ");

            queue.Enqueue(current * 2);
            queue.Enqueue(current + 2);
            queue.Enqueue(current + 1);

        }
    }

}
