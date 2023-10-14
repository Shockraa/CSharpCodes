using System;

public class Program
{
    public static void Main()
    {
        /*Write a program that extracts from a text all words which are
          palindromes, such as ABBA", "lamal", "exe".*/
        Console.WriteLine("Insira uma frase para encontrar palavras palíndromes:");
        string frase = Console.ReadLine();

        string[] palavras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries); //Remover espaços e adicionar no array

        foreach (string palavra in palavras)
        {
            if (Verificar(palavra)) //Ativa método para verificar palavra palindrome 
            {
                Console.WriteLine(palavra); 
            }
        }
    }

    public static bool Verificar(string palavra)
    {
        palavra = palavra.Replace(" ", "").ToLower(); //Necessário
        char[] arr = palavra.ToCharArray(); 
        Array.Reverse(arr);
        string palavraReversa = new string(arr);

        return palavra == palavraReversa; //Retonra a comparação dos dois arrays
    }
}

