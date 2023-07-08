using System;

namespace Hexadecimal
{
    internal class Program
    {
        static void Main()
        {
            /* Initialize a variable of type int with a value of 256 in
            hexadecimal format (256 is 100 in a numeral system with base 16). */
            int valor3 = 256 % 16;
            int valor2 = 16 % 16;
            int valor1 = 1 % 16;
            
            valor1.ToString();
            valor2.ToString();
            valor3.ToString();

            Console.Write(valor1);
            Console.Write(valor2);
            Console.Write(valor3);
            Console.ReadKey();
        }
    }
}
