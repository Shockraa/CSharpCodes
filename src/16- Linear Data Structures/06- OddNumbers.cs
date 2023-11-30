using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        //Write a program that removes from a given sequence all numbers that appear an odd count of times.
        int[] array = {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2};
        array = InsertValues(array);

        foreach(int num in array) //Display
        {
            Console.Write(num + " ");
        }

    }
    static int[] InsertValues(int[] array)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>(); //Fast book solution
        List<int> list = new List<int>();
        foreach (int num in array)
        {
            if (dictionary.ContainsKey(num)) 
            {
                dictionary[num]++;
            }
            else
            {
                dictionary[num] = 1; //Creates key and count
            }
        }
        foreach (var num in array)
        {
            if (dictionary[num] % 2 == 0)
            {
                list.Add(num);
            }
        }
        return list.ToArray();

    }
    

}
