using System;

class MaiorMenorNum
{
    static void Main()
    {
        // Write a program that reads from the console a series of integers and prints the smallest and largest of them.

        int min = int.MaxValue; //valores invertidos para que seja possível a comparação
        int max = int.MinValue;
        bool fim = false; // variavel que inicializa o loop infinito
        while (fim == false)
        {
            Console.WriteLine("Insira um num de cada vez");
            int num = int.Parse(Console.ReadLine());

            if (num > max) //primeira comparação
            {
                max = num;

            }
            if (num < min) //segunda comparação (obs o primeiro número dado estabelece o conteúdo das variáveis min e max)
            {
                min = num;

            }

            Console.WriteLine("Continuar? Y/N"); //Independente da letra, só fecha quando "N" é digitado
            string r = Console.ReadLine();
            if (r == "N")
            {
                fim = true;
            }
        }
        Console.WriteLine("Menor num: " + min); //Resposta
        Console.WriteLine("Maior num: " + max);
    }
