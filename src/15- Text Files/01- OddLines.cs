using System;
using System.IO;
					
public class Program
{
	public static void Main()
    {
        try
        {
            //Write a program that reads a text file and prints its odd lines on the console.
		
            StreamReader reader = new StreamReader("exemplo.txt"); //Insira o caminho para o arquivo aqui
            string line = reader.ReadLine(); //Lê proxima linha NO TEXTO
            int lineNum = 1;

            while (line != null)
            {
                if (lineNum % 2 == 0)
                {
                    Console.WriteLine(line); //Mostra as linhas pares do arquivo
                }
                line = reader.ReadLine();
                lineNum++;
            }

            reader.Close();
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"O arquivo não existe: {e.Message}");
        }
    }
}
