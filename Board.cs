using System;
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


            // Print the board in a 3x3 grid format
            Console.WriteLine("Current Board:");
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }

        // This method checks if there is a winner or if the game is a draw
        public string Winner(string[] oldgame)
        {
            // Convert the 1D array to a 2D array for easier manipulation
            string[][] game = new string[3][];
            for (int i = 0; i < 3; i++)
            {
                game[i] = new string[3];
                for (int j = 0; j < 3; j++)
                {
                    // Locate the element in the 1D array
                    game[i][j] = oldgame[i * 3 + j];
                }
            }

            string output = "";
            bool draw = false;

            // Check for a draw
            for (int i = 0; i < 9; i++)
            {
                if (!char.IsLetter(oldgame[i][0]))
                {
                    // If there is an number, the game is not a draw
                    draw = false;
                    break;
                }
                else
                {
                    draw = true;
                }
            }
            if (draw)
            {
                output = "The game is a draw!";
                return output;
            }

            // Check for horizontal wins
            for (int i = 0; i < 3; i++)
            {
                if (char.IsLetter(game[i][0][0]) && (game[i][0] == game[i][1] && game[i][1] == game[i][2]))
                {
                    output = "The winner is " + game[i][0] + "!!!";
                    return output;
                }
            }

            // Check for vertical wins
            for (int i = 0; i < 3; i++)
            {
                if (char.IsLetter(game[0][i][0]) && (game[0][i] == game[1][i] && game[1][i] == game[2][i]))
                {
                    output = "The winner is " + game[0][i] + "!!!";
                    return output;
                }
            }

            // Check for diagonal wins
            if (char.IsLetter(game[0][0][0]) && ((game[0][0] == game[1][1] && game[1][1] == game[2][2]) || (game[0][2] == game[1][1] & game[1][1] == game[2][0])))
            {
                output = "The winner is " + game[1][1] + "!!!";
                return output;
            }

            return output;
        }
    };
    
}
