using System;

class Fibonacci 
{
    static void Main()
    {
        /* Write a program that prints on the console the first 100 numbers in the
                    Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … */

        int n1 = 0;
        int n2 = 1;
        int n3 = n1 + n2;
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        for (int i = 0; i <= 100; i++) //  (100 = contador)
        {
            n1 = n2;
            n2 = n3;
            n3 = n1 + n2;
            Console.WriteLine(n3);
        }
    }
} 
