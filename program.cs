using System;

public class Program
{
    public static void Main()
    {
        Random random = new Random();

        string[] frase = {"The product is excellent. ", "This is a great product. ", " I use this product constantly. ", " This is the best product from this category. "};
        string[] hist = {"Now I feel better. " , "I managed to change. " , "It made some miracle. " , "I can’t believe it, but now I am feeling great. " , " You should try it , too. I am very satysfied. "}; 
        string[] nome = {"Dayan ", "Stella ", "Hellen ", "Kate "};
        string[] sobrenome = {"Johnson ", "Peterson ", "Charls "};
        string[] cidade = {"London ", "Paris ", "Berlin ", "New York ", "Madrid "};

        int index1 = random.Next(0, frase.Length);
        int index2 = random.Next(0, hist.Length);
        int index3 = random.Next(0, nome.Length);
        int index4 = random.Next(0, sobrenome.Length);
        int index5 = random.Next(0, cidade.Length);

        string resposta = frase[index1] + hist[index2] + nome[index3] + sobrenome[index4] + cidade[index5];
        Console.WriteLine(resposta);
        }
    }
