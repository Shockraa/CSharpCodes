using System;

class MatrizEspiral
{
    static void Main()
    {
		//  Write a program that for a given number n, outputs a matrix in the form of a spiral:

        int n = int.Parse(Console.ReadLine()); //Valor usuário
        int[,] matrix = new int[n, n]; //Faz Matriz de acordo com o valor recebido (linha e coluna)
        FillMatrix(matrix, n); //Função para preencher matriz
        PrintMatrix(matrix, n); //Função para mostrar matriz na tela
    }

    static void FillMatrix(int[,] matrix, int n)
    {
        int valorAtual = 1;
        int lin = 0;
        int col = 0;
        int linAumento = 0;
        int colAumento = 1;

        for (int i = 0; i < n * n; i++)
        {
            matrix[lin, col] = valorAtual; //Valor da posição que será preenchida

            if (lin + linAumento < 0 || lin + linAumento >= n || col + colAumento < 0 || col + colAumento >= n || matrix[lin + linAumento, col + colAumento] != 0) //Verifica se passa do limite dado pelo usuário ou se já tem um espaço preenchido
            {
                int temp = linAumento; //Processo para mudar a direção
                linAumento = colAumento;
                colAumento = -temp;
            }

            lin += linAumento; //Segue para a o próximo quadrado
            col += colAumento;
            valorAtual++;
        }
    }

    static void PrintMatrix(int[,] matrix, int n) //Imprimir matriz
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                    Console.Write(matrix[i, j] + " "); 
            }
            Console.WriteLine();
        }
    }
}
