using System;

public class LabirintoSaidaLonga
{
    //You are given a matrix with passable and impassable cells. Write a program that finds the largest area of neighboring passable cells.
    //O Labirinto checa todos os caminhos possíveis e armazena o maior deles.
    static char[,] lab = { 
        {' ', ' ', ' ', ' ', ' ', '*', ' '}, //O labirinto pode ser modificado contanto que haja uma saída
        {'*', '*', '*', '*', ' ', '*', ' '},
        {' ', ' ', ' ', ' ', ' ', ' ', ' '},
        {'*', '*', '*', ' ', '*', '*', ' '},
        {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
    };
    
	static string longestPath = ""; //String que armazena as direções do caminho mais longo
    public static void Main()
    {
        Caminho(0, 0, " "); //Ativa método
		Console.WriteLine("Caminho mais transitável: " + longestPath); //Resposta
    }

    static void Caminho(int lin, int col, string path)
    {
        if (lin < 0 || lin >= lab.GetLength(0) || col < 0 || col >= lab.GetLength(1)) //Condição que impede a saida do labirinto
        {
            return;
        }

        if (lab[lin, col] == 'e')  //Condição que verifica se chegou na saída
        {
            if (path.Length > longestPath.Length) //Verifica se o caminho atual é o maior
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

        // Chamada recursiva para todas as direções checando todas as possibilidades e guardando as direções feitas
        Caminho(lin, col - 1, path + " esquerda "); 
        Caminho(lin - 1, col, path + " cima "); 
        Caminho(lin, col + 1, path + " direita "); 
        Caminho(lin + 1, col, path + " baixo "); 

        // Marca de volta a célula como não visitada para que seja possível o backtracking
        lab[lin, col] = ' ';
    }
}
