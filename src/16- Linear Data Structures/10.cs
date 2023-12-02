using System;
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
        HashSet<int> check = new HashSet<int>();
        queue.Enqueue(N);
        check.Add(N);

        while (current != M)
        {
            current = queue.Dequeue();
            Console.Write(current + " ");

            if (current * 2 <= M && !check.Contains(current * 2))
            {
                queue.Enqueue(current * 2);
                check.Add(current * 2);
            }
            if (current + 2 <= M && !check.Contains(current + 2))
            {
                queue.Enqueue(current + 2);
                check.Add(current + 2);
            }
            if (current + 1 <= M && !check.Contains(current + 1))
            {
                queue.Enqueue(current + 1);
                check.Add(current + 1);
            }
        }
    }
}
