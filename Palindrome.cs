using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Insira uma frase para encontrar palavras palíndromes:");
        string frase = Console.ReadLine();

        string[] palavras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string palavra in palavras)
        {
            if (Verificar(palavra))
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

        return palavra == palavraReversa;
    }
}
