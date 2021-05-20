using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void CreateEmptyBoard()
        {
            Char[] board = new char[10];
            for (int i = 0; i < 10; i++)
            {
                board[i] = ' ';
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            CreateEmptyBoard();
        }
    }
}