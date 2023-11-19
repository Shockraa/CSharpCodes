using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> seq = new List<int>();
        int num = 1;

        while (true)
        {
            Console.WriteLine("Insert a number (insert empty line to stop)");

            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }

            try
            {
                num = int.Parse(input);
                seq.Add(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input, please a number...");
            }
        }
        CalculateSum(seq);
        CalculateAverage(seq);
    }
    static void CalculateSum(List<int> seq)
    {
        int sum = 0;

        foreach (int num in seq)
        {
            sum += num;
        }
        Console.WriteLine("Sum of the sequence: " + sum);

    }
    static void CalculateAverage(List<int> seq)
    {
        double sum = 0;
        double counter = 0;
        foreach (int num in seq)
        {
            sum += num;
            counter++;
        }
        double average = sum / counter;
        Console.WriteLine("Average of the sequence: " + average);
    }

}
