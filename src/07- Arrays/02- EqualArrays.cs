using System;

public class ArrayIguais
{
    public static void Main()
    {
        /*Write a program, which reads two arrays from the console and checks 
          whether they are equal (two arrays are equal when they are of equal 
          length and all of their elements, which have the same index, are equal)*/


        Console.WriteLine("Qual é a largura em número inteiro do primeiro array?");
        int n = int.Parse(Console.ReadLine());
        int[] array1 = new int[n]; //Inicializa primeiro array sem conteúdo
        for (int i = 0; i < n; i++) //Loop que preenche o primeiro array
        {
            Console.WriteLine("Insira os elementos da posição {0} do array", i);
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Qual é a largura em número inteiro do segundo array?");
        int a = int.Parse(Console.ReadLine()); //Inicializa segundo array
        if (a != n) //Verifica a largura
        {
            Console.WriteLine("Os arrays não são iguais por terem largura diferente.");
            return; //Fecha o código
        }

        int[] array2 = new int[a]; //Declara segundo array caso a largura seja a mesma
        for (int i = 0; i < a; i++) //Preenche array
        {
            Console.WriteLine("Insira os elementos da posição {0} do array", i);
            array2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++) //Loop para checar o conteúdo e dizer se possuem ou não o mesmo conteúdo
        {
            if (array1[i] != array2[i])
            {
                Console.WriteLine("O array tão tem os conteúdos iguais, portanto não são iguais."); 
                return;
            }
        }
        Console.WriteLine("Os arrays são iguais :D");
    }
}
