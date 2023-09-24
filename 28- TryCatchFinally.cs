using System;

public class Program
{
    public static void Main()
    {
        double num = 0.0;
        try
        {
            Console.WriteLine("Insira um número para saber a raiz quadrada");
            num = double.Parse(Console.ReadLine());
            num = Math.Sqrt(num);

            if (double.IsNaN(num))
            {
                throw new Exception("Não é um número válido.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("É para dar um número!");
        }
        finally
        {
            if (!double.IsNaN(num))
            {
                Console.WriteLine("Raiz quadrada: " + num);
            }
            Console.WriteLine("Good bye");
        }
    }
}
