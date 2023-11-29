using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int[] array = {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2};
        AddValues(array);

        foreach(int num in array) //Display Original Array
        {
            Console.Write(num + " ");
        }

    }
    static void AddValues(int[] array)
    {
        int[] occurrences = new int[1001];

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
