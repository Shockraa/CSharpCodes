using System;
using System.Collections.Generic;

public class Program
    {
        public static void Main()
        {
            List<int> list = new List<int> {1, 4, -6, 7, 6, -2, -9}; //Insert your array here

            List<int> result = FindPositiveNum(list);

            foreach(int num in result)
            {
                Console.WriteLine(num);
            }
        }
  
        static List<int> FindPositiveNum (List<int> list)
        {
            List<int> sublist = new List<int>();
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > 0)
                {
                    sublist.Add(list[i]);
                }
            }
            return sublist;
        }
    }
