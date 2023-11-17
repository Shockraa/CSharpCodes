using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Insira uma string");
		string str = Console.ReadLine();
		char pad = '*';
		Console.WriteLine(str.PadRight(20, pad));
	}
}
