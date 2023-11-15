using System;
using System.IO;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        string path = "exemplo.txt";
        string finalPath = "destino.txt";
        
        int size = FindSize(path);

        int[,] matrix = FillMatrix(size, path);

        int maxSum = FindSum(size, matrix);

        using(StreamWriter writer = new StreamWriter(finalPath))
        {
            writer.WriteLine("Max sum: " + maxSum);
        }
        
    }
    static int FindSize(string path)
    {
        using(StreamReader reader = new StreamReader(path))
        {
           return int.Parse(reader.ReadLine());
        }
    }
    static int[,] FillMatrix(int size, string path)
    {
        int[,] matrix = new int[size, size];
        using(StreamReader reader = new StreamReader(path))
        {
           reader.ReadLine(); //Pula a primeira linha que especifica o tamanho
           
           for(int i = 0; i < size; i++)
           {
            string[] line = reader.ReadLine().Split(' ');
            for(int j = 0; j < size; j++)
             {
                matrix[i,j] = int.Parse(line[j]);
            
             }
           }
        }
        return matrix;
    }
    static int FindSum (int size, int[,] matrix)
    {
        int temp;
        int total = 0;

         for(int i = 0; i < size - 1; i++)
           {
            for(int j = 0; j < size - 1; j++)
             {
                temp = matrix[i,j] + matrix[i + 1,j] + matrix[i,j + 1] + matrix[i + 1,j + 1];
                if(temp > total)
                {
                    total = temp;
                }
            
             }
           }
        return total;
    }
}
