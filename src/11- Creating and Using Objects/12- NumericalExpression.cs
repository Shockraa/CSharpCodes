using System;
using System.Data;

public class Program
{
    public static void Main()
    {
        //Write a program, which calculates the value of a given numeral expression given as a string.

        Console.WriteLine("Insira uma expressão numérica");
        string conta = Console.ReadLine();
        DataTable dt = new DataTable();

            object resultado = dt.Compute(conta, "");
            Console.WriteLine("Resultado: " + resultado);
        
    }
}
