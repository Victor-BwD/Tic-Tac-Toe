using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using Tic_Tac_Toe.Entities;


namespace Tic_Tac_Toe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            var diceRoll = new DiceRoll();

            Player startingPlayer = diceRoll.WhoBegin();
            
            Console.WriteLine(startingPlayer);
            Console.WriteLine();

            Board board = new Board();
            board.BoardDraw();

            Player currentPlayer = startingPlayer;
            
            while (true)
            {
                if (currentPlayer.Number == 1)
                {
                    var player2 = new Player(2, 'O');
                    currentPlayer.PlayersMakeMove(board, currentPlayer, player2);
                    
                }else if (currentPlayer.Number == 2)
                {
                    var player1 = new Player(1, 'X');
                    currentPlayer.PlayersMakeMove(board, player1, currentPlayer);
                }
            }
        }
    }
}
