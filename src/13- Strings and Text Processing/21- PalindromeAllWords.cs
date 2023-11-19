using System;

public class Program
{
    public static void Main()
    {
        /*Write a program that extracts from a text all words which are
          palindromes, such as ABBA", "lamal", "exe".*/
        Console.WriteLine("Insert a sentence:");
        string frase = Console.ReadLine();

        string[] palavras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries); //Remover spaces to add on the array

        foreach (string palavra in palavras)
        {
            if (Verificar(palavra)) //Method below to verify if the word is palindrome
            {
                Console.WriteLine(palavra); //Display the word
            }
        }
    }

    public static bool Verificar(string palavra)
    {
        palavra = palavra.Replace(" ", "").ToLower(); //Necessary conversion
        char[] arr = palavra.ToCharArray(); 
        Array.Reverse(arr);
        string palavraReversa = new string(arr);

        return palavra == palavraReversa; //Retonra the comparision of both arrays
    }
}

