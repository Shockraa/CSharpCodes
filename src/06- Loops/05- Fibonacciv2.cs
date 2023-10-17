using System;

class FibonacciV2
{
    static void Main()
    {
        /* Write a program that reads from the console number N and print the sum 
           of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 
           13, 21, 34, 55, 89, 144, 233, 377, … */

        int n = int.Parse(Console.ReadLine()); //num dado
        int n1 = 0;
        int n2 = 1;
        int n3 = n1 + n2; //fibonacci

        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);

        for (int i = 0; i <= int.MaxValue; i++) //  (int.MaxValue = valor máximo da variável int)
        {
            n1 = n2;
            n2 = n3;
            n3 = n1 + n2;

            if (n3 > n) //checa se a sequência de fibonacci ultrapassa o num dado
            {
                break;
            }
            Console.WriteLine(n3);
        }
    }
} 
