using System;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] mines = new char[n, n];
            char[,] board = new char[n, n];

            // Read mine positions
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    mines[i, j] = line[j];
                }
            }

            // Read board positions
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = line[j];
                }
            }

            // Fill in numbers for touched positions
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == 'x')
                    {
                        if (mines[i, j] == '*')
                        {
                            // Touching a mine
                            for (int k = 0; k < n; k++)
                            {
                                for (int l = 0; l < n; l++)
                                {
                                    if (mines[k, l] == '*')
                                    {
                                        board[k, l] = '*';
                                    }
                                }
                            }
                            break;
                        }
                        else
                        {
                            // Counting mines
                            int count = 0;
                            for (int k = i - 1; k <= i + 1; k++)
                            {
                                for (int l = j - 1; l <= j + 1; l++)
                                {
                                    if (k >= 0 && k < n && l >= 0 && l < n && mines[k, l] == '*')
                                    {
                                        count++;
                                    }
                                }
                            }
                            board[i, j] = (char)(count + '0');
                        }
                    }
                }
            }

            // Print the board
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
