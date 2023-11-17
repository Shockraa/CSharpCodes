using System;
using System.IO;

public class FileParseException : Exception //Exception personalizada herda Exception
{
    public string FileName { get; }

    public int RowNumber { get; }

    public FileParseException(string fileName, int rowNumber) //Nome do arquivo e numero da linha, guarda na exceção personalizada
    {
        FileName = fileName;
        RowNumber = rowNumber;
    }

    public override string Message
{
    get
    {
        return $"Erro com o arquivo '{FileName}' na linha {RowNumber}. Não possui um integer."; //Mensagem
    }
}
}

public class Program
{
    public static void Main()
    {
        string arquivo = "exemplo.txt"; //Coloque o seu arquivo aqui :)
        int numLinha = 0;

        try
        {
            using (TextReader reader = new StreamReader(arquivo)) //Leitor
            {
                string line;
                while ((line = reader.ReadLine()) != null) //Enquanto
                {
                    numLinha++;
                    if (!int.TryParse(line, out _)) //Conversor para verificar se tem algum numero inteiro
                    {
                        throw new FileParseException(arquivo, numLinha);
                    }
                    Console.WriteLine(line);
                }
            }
        }
        catch (FileParseException ex)
        {
            Console.WriteLine(ex.Message); //Mostra mensagem pois não achou um inteiro no arquivo
        }
    }
}
