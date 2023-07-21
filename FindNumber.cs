using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Qual é a largura do array?");
        int n = int.Parse(Console.ReadLine());

        int[] array = GetValoresArray(n);

        Console.WriteLine("Qual número deseja achar no array?");
        int achar = int.Parse(Console.ReadLine());
        int quantidade = GetRepeticao(achar, n, array);
        Console.WriteLine("O número que você escolheu repete {0} vezes no array dado" , quantidade);
    }
    public static int[] GetValoresArray(int n)
    {
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Insira o valor da posição {0}:" , i);
            array[i] = int.Parse(Console.ReadLine());
        }

        return array;
    }
    public static int GetRepeticao(int achar, int n, params int[] array)
    {
        int quantidade = 0;
        for (int i = 0; i < n; i++)
        {
            if (array[i] == achar)
            {
                quantidade++;
            }
        }
        return quantidade;
    }
}
