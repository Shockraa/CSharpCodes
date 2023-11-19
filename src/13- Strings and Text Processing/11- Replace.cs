using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        /*A string is given, composed of several "forbidden" words separated by
                  commas. Also a text is given, containing those words. Write a program
                  that replaces the forbidden words with asterisks.*/

        Console.WriteLine("Insert a sentence");
        string sentence = Console.ReadLine();
        Console.WriteLine("Insert words to replace with *, separate with comma please");
        string censura = Console.ReadLine();

        string resultado = Censurar(sentence, censura); //Method that does the work

        Console.WriteLine(resultado); //Display
    }

    static string Censurar(string text, string censura) 
    {

        string[] wordsArray = censura.Split(',');


        string seq = string.Join("|", wordsArray);  //Operator to diferenciate sequence


        string result = Regex.Replace(text, seq, match => new string('*', match.Length)); //Replaces the words

        return result;
    }

}

