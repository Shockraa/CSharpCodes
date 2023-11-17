using System;

public class Program
{
    public static void Main()
    {
        /* Write a program that takes a positive integer from the console and prints
        the square root of this integer. If the input is negative or invalid print
        "Invalid Number" in the console. In all cases print "Good Bye". */

        
        double num = 0.0;
        try
        {
            Console.WriteLine("Give a number");
            num = double.Parse(Console.ReadLine());
            num = Math.Sqrt(num);

            if (double.IsNaN(num))
            {
                throw new Exception("Not a valid number!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("I said, give a number!");
        }
        finally
        {
            if (!double.IsNaN(num))
            {
                Console.WriteLine("Square root: " + num);
            }
            Console.WriteLine("Good bye");
        }
    }
}
