using System;

public class ReverterNum
{
    public static void Main()
    {
       //Write a method that prints the digits of a given decimal number in a reversed order. For example 256, must be printed as 652.
       //Ex feito para treinar métodos :)
        Console.WriteLine("Digite um número inteiro para ser revertido:");
        int numero = int.Parse(Console.ReadLine());
        int[] array = NumeroParaArray(numero); //Método que passa o número para o array
        int[] reverso = ReverterArray(array); //Método para reverter
        foreach (int num in reverso) //Escreve o array revertido
        {
            Console.Write(num);
        }


    }

    public static int[] NumeroParaArray(int numero)
    {
        string numeroString = numero.ToString(); //Converte o num em string para que ele tenha uma largura definida
        int[] array = new int[numeroString.Length]; //Passa a largra
        for (int i = 0; i < numeroString.Length; i++) 
        {
            array[i] = int.Parse(numeroString[i].ToString()); //Preenche
        }

        return array;
    }
    public static int[] ReverterArray(params int[] array)
    {
        int[] reverso = new int[array.Length]; 
        for (int i = 0; i < array.Length; i++)
        {
            reverso[i] = array[array.Length - i - 1]; //Processo para reverter
        }
        return reverso;

    }
}
