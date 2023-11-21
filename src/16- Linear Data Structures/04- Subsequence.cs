using System;
using System.Collections.Generic;

public class Program
{
	public static void Main(string[] args)
	{
                /* Write a method that finds the longest subsequence of equal numbers
                  in a given List<int> and returns the result as new List<int>. Write a
                  program to test whether the method works correctly. */
		
		List<int> list = new List<int> {1, 4, 6, 7, 6, 2, 9, 5, 3, 2, 1, 5, 6, 7, 2, 2, 2, 2, 4, 4, 4, 7, 8, 33, 14 }; //Insert your array here
		
		List<int> result = FindLongestSub(list);
		foreach (int num in result)
		{
			Console.WriteLine(num);
		}

	}

	static List<int> FindLongestSub(List<int> list)
	{
		int current = 0;
		int before = 0;
		int start = 0;
		int tempLength = 1;
		int length = 1;
		for (int i = 0; i < list.Count - 1; i++)
		{
			current = list[i];
			if (before == current)
			{
				tempLength++;
				if (tempLength > length)
				{
					start = current;
					length = tempLength;
				}
			}
			else
			{
				tempLength = 1;
			}

			before = current;
		}

		List<int> sub = new List<int>();
		for (int i = 0; i < length; i++)
		{
			sub.Add(start);
		}

		return sub;
	}
}

