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
        
        public void PlayersMakeMove (Board board, Player player1, Player player2)
        {
            Console.WriteLine("Player 1, choose a position: ");
            int position = int.Parse(Console.ReadLine());
            board.SetPosition(position, player1.Symbol);
            board.BoardDraw();
            
            Console.WriteLine("Player 2, choose a position: ");
            position = int.Parse(Console.ReadLine());
            board.SetPosition(position, player2.Symbol);
            board.BoardDraw();
        }

        public override string ToString()
        {
            return $"Player {Number} is '{Symbol}'.";
        }
    }
}