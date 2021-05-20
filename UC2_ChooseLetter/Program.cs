using System;

namespace Tic_Toc_Toe
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
        static void ChooseLetter()
        {
            string computerChoose;
            Console.WriteLine("Plaese enter Your Letter(X/O) : ");
            string userChoose = Console.ReadLine();
            while (true)
            {
                if (userChoose == "X" || userChoose == "x")
                {
                    computerChoose = "O";
                    break;
                }
                else if (userChoose == "O" || userChoose == "o")
                {
                    computerChoose = "X";
                    break;
                }
                else
                    Console.WriteLine("Wrong input,Please type again");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            CreateEmptyBoard();
            ChooseLetter();
        }
    }
}