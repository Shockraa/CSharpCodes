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
        PrintSorted(seq); // Method to sort
    }
    static void PrintSorted(List<int> seq)
    {
        seq.Sort();
        Console.WriteLine("Sorted order: ");
        foreach (int num in seq)
        {
            Console.WriteLine(num);
        }

    }


}
