using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        /*Write a program that reads from the console a sequence of positive
          integer numbers. The sequence ends when empty line is entered.
          Calculate and print the sum and the average of the sequence. Keep
          the sequence in List<int>.*/
        
        List<int> seq = new List<int>(); //Creates list
        int num = 1; //Gives a temp number

        while (true)
        {
            Console.WriteLine("Insert a number (insert empty line to stop)");

            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input)) //Only works w strings
            {
                break;
            }

            try
            {
                num = int.Parse(input); //Converts the input into int and adds to the list
                seq.Add(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input, please a number...");
            }
        }
        CalculateSum(seq); // Methods to calculate and display
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
