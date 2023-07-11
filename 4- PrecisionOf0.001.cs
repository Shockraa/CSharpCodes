using System;

class Precision
{
    static void Main()
    {
        /* Write a program that calculates the sum (with precision of 0.001) of
        the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + … */

         double resultado = 1.0;
         double total = 1.0;
         double precisao = 0.001;
         int denominador = 2;
 
        while (resultado > precisao)
        {
            resultado = 1.0 / denominador;
            if (denominador % 2 == 0)
            {
                total += resultado;
            }
            else
            {
                total -= resultado;
            }
            denominador++;
        }
            Console.WriteLine("Sum: " + total);
    }
}
