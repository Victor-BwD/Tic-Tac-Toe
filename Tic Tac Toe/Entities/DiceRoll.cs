using System;

namespace Tic_Tac_Toe.Entities
{
    public class DiceRoll
    {
        private int diceRoll;
        private Player player1;
        private Player player2;
        
        private int Roll()
        {
            System.Random random = new System.Random();
            diceRoll = random.Next(1, 7);
            return diceRoll;
        }
        
        public int GetDiceRoll()
        {
            return Roll();
        }

        public Player WhoBegin(Player player1, Player player2)
        {
            var diceRoll = GetDiceRoll();

            if (diceRoll <= 3)
            {
                Console.WriteLine("Player 1 starts the game!");
                return player1;
            }
            else
            {
                Console.WriteLine("Player 2 starts the game!");
                return player2;
            }
        }
    }
}