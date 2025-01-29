using Tictactoe;
using System;

Console.WriteLine("Welcome to Tic Tac Toe!");

string[] positions = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];

string end = "";

Board b = new Board();
// prints board
//checj for winner
// ask player1s move
// print board
//check for winner
// ask for player2 move

while (true)
{
    string player1 = "";
    string player2 = "";
    int iChoice = 0;
    bool bPlayer1 = true;
    bool bPlayer2 = true;
    //PLAYER 1 MOVE

    // func that displays board
    b.PrintBoard(positions);

    while (bPlayer1)
    {
        Console.WriteLine("Player 1: Enter the number of a position that hasn't been taken.");
        player1 = Console.ReadLine();

        for (int i = 0; i < positions.Length; i++)
        {
            if (player1 == positions[i] && player1 != "X" && player1 != "O")
            {
                iChoice = int.Parse(player1);
                positions[iChoice - 1] = "X";
                bPlayer1 = false;
            }
        }
        if (bPlayer1)
        {
            Console.WriteLine("Enter a valid input, you dummy.");

        }
    }
    end = b.Winner(positions);

    //func that checks for winner
    if (end != "")
    {
        Console.WriteLine(end);
        b.PrintBoard(positions);
        break;
    }
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();
    Console.Clear();
    //PLAYER 2 MOVE

    // func that displays board
    b.PrintBoard(positions);
    while (bPlayer2)
    {
        Console.WriteLine("Player 2: Enter the number of a position that hasn't been taken.");
        player2 = Console.ReadLine();

        for (int i = 0; i < positions.Length; i++)
        {
            if (player2 == positions[i] && player2 != "X" && player2 != "O")
            {
                iChoice = int.Parse(player2);
                positions[iChoice - 1] = "O";
                bPlayer2 = false;
            }
        }
        if (bPlayer2)
        {
            Console.WriteLine("Enter a valid input, you dummy.");

        }
    }
    end = b.Winner(positions);

    //func that checks for winner
    if (end != "")
    {
        Console.WriteLine(end);
        b.PrintBoard(positions);
        break;
    }
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();
    Console.Clear();
}
Console.WriteLine("\nGoodbye!");










