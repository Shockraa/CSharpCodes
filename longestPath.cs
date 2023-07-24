using System;

public class Program
{
    static char[,] lab = {
        {' ', ' ', ' ', ' ', ' ', '*', ' '},
        {'*', '*', '*', '*', ' ', '*', ' '},
        {' ', ' ', ' ', ' ', ' ', ' ', ' '},
        {'*', '*', '*', ' ', '*', '*', ' '},
        {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
    };
    
	static string longestPath = "";
    public static void Main()
    {
        Caminho(0, 0, " ");
		Console.WriteLine("Caminho mais transitável: " + longestPath);
    }

    static void Caminho(int lin, int col, string path)
    {
        if (lin < 0 || lin >= lab.GetLength(0) || col < 0 || col >= lab.GetLength(1))
        {
            return;
        }

        if (lab[lin, col] == 'e')
        {
            if (path.Length > longestPath.Length)
            {
                longestPath = path; // Atualiza o caminho mais longo encontrado
            }
            return;

        }

        if (lab[lin, col] != ' ')
        {
            return; // Retorna se a célula já foi visitada ou é um obstáculo
        }

        lab[lin, col] = 's'; // Marca a célula como visitada

        // Chamada recursiva para todas as direções checando todas as possibilidades e guardando as direções feitasqqqq
        Caminho(lin, col - 1, path + " esquerda "); 
        Caminho(lin - 1, col, path + " cima "); 
        Caminho(lin, col + 1, path + " direita "); 
        Caminho(lin + 1, col, path + " baixo "); 

        // Marca de volta a célula como não visitada (backtracking)
        lab[lin, col] = ' ';
    }
}
