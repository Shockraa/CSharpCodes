using System;

public class ReverterNum
{
    public static void Main()
    {
       //Write a method that prints the digits of a given decimal number in a reversed order. For example 256, must be printed as 652.
       //Ex feito para treinar métodos :)
        Console.WriteLine("Digite um número inteiro para ser revertido:");
        int numero = int.Parse(Console.ReadLine());
        int[] array = NumeroParaArray(numero);
        int[] reverso = ReverterArray(array);
        foreach (int num in reverso)
        {
            Console.Write(num);
        }


    }

    public static int[] NumeroParaArray(int numero)
    {
        string numeroString = numero.ToString();
        int[] array = new int[numeroString.Length];
        for (int i = 0; i < numeroString.Length; i++)
        {
            array[i] = int.Parse(numeroString[i].ToString());
        }

        return array;
    }
    public static int[] ReverterArray(params int[] array)
    {
        int[] reverso = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            reverso[i] = array[array.Length - i - 1];
        }
        return reverso;

    }
}
