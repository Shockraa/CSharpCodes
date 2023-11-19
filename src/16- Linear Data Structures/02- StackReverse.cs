using System;
using System.Text.RegularExpressions;
using System.Collections;
public class Program
{
    public static void Main()
    {
        int counter = 0;
        Stack<int> stack = new Stack<int>();
        while (true)
        {
            try
            {
                Console.WriteLine("Insert a number to add (insert empty line or a letter to stop)");
                int num = int.Parse(Console.ReadLine());
                stack.Push(num);
                counter++;
            }
            catch (FormatException)
            {
                break;
            }

        }
        Console.WriteLine("Reverse order:");
        while (stack.Count > 0)
        {
            int display = stack.Pop();
            Console.WriteLine(display);
        }



    }


}
