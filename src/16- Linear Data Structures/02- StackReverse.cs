using System;
using System.Text.RegularExpressions;
using System.Collections;
public class Program
{
    public static void Main()
    {
        /* Write a program, which reads from the console N integers and prints
         them in reversed order. Use the Stack<int> class. */
        Stack<int> stack = new Stack<int>(); //Creates a stack
        while (true)
        {
            try
            {
                Console.WriteLine("Insert a number to add (insert empty line or a letter to stop)");
                int num = int.Parse(Console.ReadLine());
                stack.Push(num); //Puts the number at the top
            }
            catch (FormatException)
            {
                break; //Breaks the loop when the input isn't a number
            }

        }
        Console.WriteLine("Reverse order:");
        while (stack.Count > 0) //Loop to print numbers
        {
            int display = stack.Pop();
            Console.WriteLine(display); 
        }



    }


}
