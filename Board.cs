﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tictactoe
{
    internal class Board
    {

        public void PrintBoard(string[] board)
        {

            Console.Clear(); // Clear the screen to show the current board

            // Print the board in a 3x3 grid format
            Console.WriteLine("Current Board:");
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }

        public bool Winner(string[] oldgame)
        {
            //convert 1D array to 2D array
            string[][] game = new string[3][];
            for (int i = 0; i < 3; i++)
            {
                game[i] = new string[3];
                for (int j = 0; j < 3; j++)
                {
                    // locate the element in the 1D array
                    game[i][j] = oldgame[i * 3 + j];
                }
            }
            bool gameover = false;
            //check horizontal
            for (int i = 0; i < 3; i++)
            {
                if (game[i][0]!="-" && (game[i][0] == game[i][1] && game[i][1] == game[i][2]))
                {
                    gameover = true;
                    Console.WriteLine("The winner is " + game[i][0] + "!!!");
                }
            }
            //check vertical
            for (int i = 0; i < 3; i++)
            {
                if (game[0][i] != "-" && (game[0][i] == game[1][i] && game[1][i] == game[2][i]))
                {
                    gameover = true;
                    Console.WriteLine("The winner is " + game[i][0] + "!!!");
                }
            }
            //check diagonal
            if (game[0][0] != "-" && ((game[0][0] == game[1][1] && game[1][1] == game[2][2]) || (game[0][2] == game[1][1] & game[1][1] == game[2][0])))
            {
                gameover = true;
                Console.WriteLine("The winner is " + game[1][1] + "!!!");
            }
            //check draw
            for(int i = 0; i< 9; i++)
            {
                if (oldgame[i] == "-")
                {
                    gameover = false;
                    break;
                }
                else
                {
                    gameover = true;
                }
            }

            return gameover;
        }
    };
    
}
