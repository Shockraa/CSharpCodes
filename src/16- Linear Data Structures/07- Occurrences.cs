using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        //Write a program that finds in a given array of integers (in the range [0…1000]) how many times each of them occurs.
        int[] array = {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2};
        AddValues(array);

        foreach(int num in array) //Display Original Array (ignore)
        {
            Console.Write(num + " ");
        }

    }
    static void AddValues(int[] array)
    {
        int[] occurrences = new int[1001]; //Value from exercise

        foreach (var num in array)
        {
            occurrences[num]++;
        }

        for (int i = 0; i < occurrences.Length; i++)
        {
            if (occurrences[i] != 0)
            {
                Console.WriteLine("Number: " + i + " Occurrences: " + occurrences[i]);
            }
        }

    }
    

}
