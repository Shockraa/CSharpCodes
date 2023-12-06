using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        /*Using the Queue<T> class, write a program which by given N prints on the
          console the first 50 elements of the sequence  (the sequence is on the book) */
        
        Console.WriteLine("Give a number");
        int N = int.Parse(Console.ReadLine());

        DoSequence(N);
    }

    static void DoSequence(int N)
    {
        int count = 1;

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(N);

        while (count <= 50)
        {
            int current = queue.Dequeue();
            Console.Write(current + " ");

            queue.Enqueue(current + 1);
            queue.Enqueue(2 * current + 1); 
            queue.Enqueue(current + 2);

            count += 3; //Equivalent to the enqueue methods
        }
    }

}
