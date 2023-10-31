using System;

namespace Tic_Tac_Toe.Entities
{
    public class Player
    {
        public int Number { get; private set; }
        public char Symbol { get; private set; }

        public Player(int number, char symbol)
        {
            if (number < 1 || number > 2)
            {
                throw new ArgumentException("O número do jogador deve ser 1 ou 2.");
            }
            
            if (symbol != 'X' && symbol != 'O')
            {
                throw new ArgumentException("O símbolo do jogador deve ser 'X' ou 'O'.");
            }
            
            Number = number;
            Symbol = symbol;
        }
        
        public void PlayersMakeMove(Board board, Player currentPlayer)
        {
            Console.WriteLine($"Player {currentPlayer.Number}, choose a position: ");
            int position = int.Parse(Console.ReadLine());
            board.SetPosition(position, currentPlayer.Symbol);
            board.BoardDraw();
            Console.WriteLine($"Player {currentPlayer.Number} joga");
        }

        public override string ToString()
        {
            return $"Player {Number} is '{Symbol}'.";
        }
    }
}