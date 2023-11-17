using System;
					
public class Program
{
	public static void Main()
	{
                /*Write a program that reads a string from the console (20 characters
                  maximum) and if shorter complements it right with "*" to 20 characters.*/
		
		Console.WriteLine("Insira uma string");
		string str = Console.ReadLine();
		char pad = '*';
		Console.WriteLine(str.PadRight(20, pad));
	}
}
