using System;

class JogoDaVelha
{
    static void Main()
    {
        char[,] tabuleiro = new char[3, 3];
        char jogador = 'O';

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tabuleiro[i, j] = ' ';
            }
        }

        bool jogoTerminado = false;
        while (!jogoTerminado)
        {
            ImprimirTabuleiro(tabuleiro);

            Console.WriteLine("Jogador " + jogador + ", digite a linha (0-2):");
            int linha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jogador " + jogador + ", digite a coluna (0-2):");
            int coluna = Convert.ToInt32(Console.ReadLine());

            if (tabuleiro[linha, coluna] == ' ')
            {
                tabuleiro[linha, coluna] = jogador;

                if (VerificarVitoria(tabuleiro, jogador))
                {
                    Console.WriteLine("Jogador " + jogador + " venceu!");
                    jogoTerminado = true;
                }
                else if (TabuleiroCompleto(tabuleiro))
                {
                    Console.WriteLine("O jogo terminou em empate.");
                    jogoTerminado = true;
                }
                else
                {
                    jogador = (jogador == 'O') ? 'X' : 'O';
                }
            }
            else
            {
                Console.WriteLine("Posição ocupada. Tente novamente.");
            }
        }

        Console.WriteLine("Tabuleiro final:");
        ImprimirTabuleiro(tabuleiro);

        Console.ReadLine();
    }

    static void ImprimirTabuleiro(char[,] tabuleiro)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tabuleiro[i, j] + " ");

                if (j < 2)
                {
                    Console.Write("| ");
                }
            }
            Console.WriteLine();
            if (i < 2)
            {
                Console.WriteLine("---------");
            }
        }
    }

    static bool VerificarVitoria(char[,] tabuleiro, char jogador)
    {
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[i, 0] == jogador && tabuleiro[i, 1] == jogador && tabuleiro[i, 2] == jogador)
            {
                return true;
            }
        }
        for (int j = 0; j < 3; j++)
        {
            if (tabuleiro[0, j] == jogador && tabuleiro[1, j] == jogador && tabuleiro[2, j] == jogador)
            {
                return true;
            }
        }
        if ((tabuleiro[0, 0] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 2] == jogador) ||
            (tabuleiro[0, 2] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 0] == jogador))
        {
            return true;
        }

        return false;
    }

    static bool TabuleiroCompleto(char[,] tabuleiro)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[i, j] == ' ')
                {
                    return false;
                }
            }
        }

        return true;
    }
}
