using System;
using Tic_Tac_Toe.Entities;


namespace Tic_Tac_Toe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            DiceRoll diceRoll = new DiceRoll();
            Player player1 = new Player(1, 'X');
            Player player2 = new Player(2, 'O');

            Player startingPlayer = diceRoll.WhoBegin(player1, player2);

            Console.WriteLine(startingPlayer);
            Console.WriteLine();

            Board board = new Board();
            board.BoardDraw();

            Player currentPlayer = startingPlayer;

            while (true)
            {
                currentPlayer.PlayersMakeMove(board, currentPlayer);
                
                if (board.CheckForWin(currentPlayer.Symbol))
                {
                    Console.WriteLine($"Player {currentPlayer.Number} wins!");
                    break;
                }
                
                currentPlayer = (currentPlayer.Number == 1) ? player2 : player1;
            }
        }
    }
}
