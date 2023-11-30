using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int[] array = {2, 2, 3, 3, 2, 3, 4, 3, 3};
        List<int> list = new List<int>();

        foreach (int num in array) //Display Original Array
        {
            list.Add(num);
        }
        list.Sort();

        Console.WriteLine("The majorant is: " + FindMajorant(list));

    }

    static int FindMajorant(List<int> list)
    {
        int currentNumber = list[0];
        int counter = 1;

        for (int i = 1; i < list.Count; i++)
        {
            if (currentNumber == list[i])
            {
                counter++;
                if (counter >= (list.Count / 2 + 1))
                {
                    break;
                }
            }
            else
            {
                currentNumber = list[i];
                counter = 1;
            }
            if (i >= (list.Count / 2 + 1) && list[i] != currentNumber)
            {
                throw new Exception("There's no majorant!");
            }
        }
        return currentNumber;

    }

}
