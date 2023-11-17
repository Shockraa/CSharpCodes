using System;
					
public class Program
{
	public static void Main()
	{
    /*Write a program that converts a given string into the form of array of
Unicode escape sequences in the format used in the C# language.
Sample input: "Test". Result: "\u0054\u0065\u0073\u0074".*/

		Console.WriteLine("Give string");
		string str = Console.ReadLine();
		char[] arr = str.ToCharArray();
		ushort[] ushortArray = new ushort[arr.Length];
		
		for (int i = 0; i < arr.Length; i++)
		{
			ushortArray[i] = arr[i]; 
		}
		foreach (int cont in ushortArray)
		{
			Console.WriteLine("U+{0:x4}", cont);
		}
		
	}
}
