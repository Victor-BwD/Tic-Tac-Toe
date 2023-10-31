using System;
using System.Collections.Generic;

namespace Tic_Tac_Toe.Entities
{
    public class Board
    {
        private char[] array = {'0', '1', '2', '3', '4', '5', '6', '7', '8'};
        
        public void BoardDraw()
        {
            System.Console.WriteLine("     |     |      ");
            System.Console.WriteLine("  {0}  |  {1}  |  {2}", array[0], array[1], array[2]);
            System.Console.WriteLine("_____|_____|_____ ");
            System.Console.WriteLine("     |     |      ");
            System.Console.WriteLine("  {0}  |  {1}  |  {2}", array[3], array[4], array[5]);
            System.Console.WriteLine("_____|_____|_____ ");
            System.Console.WriteLine("     |     |      ");
            System.Console.WriteLine("  {0}  |  {1}  |  {2}", array[6], array[7], array[8]);
            System.Console.WriteLine("     |     |      ");
        }
        
        public char GetPosition(int index)
        {
            if (index >= 0 && index < array.Length)
            {
                return array[index];
            }
            else
            {
                Console.WriteLine("Invalid position. Choose a position between 0 and 8.");
                return ' '; 
            }
        }
        
        public void SetPosition(int index, char value)
        {
            char positionValue = GetPosition(index);
            bool validPosition = false;

            while (!validPosition)
            {
                if (positionValue == 'X' || positionValue == 'O')
                {
                    Console.WriteLine("Position already taken. Choose another position.");
                }
                else
                {
                    validPosition = true;
                }

                if (!validPosition)
                {
                    Console.Write("Choose a new position: ");
                    index = int.Parse(Console.ReadLine());
                    positionValue = GetPosition(index);
                }
            }
            array[index] = value;
        }
        
        public bool CheckForWin(char symbol)
        {
            var winConditions = new List<int[]>
            {
                new[] {0, 1, 2}, new[] {3, 4, 5}, new[] {6, 7, 8}, // Linhas horizontais
                new[] {0, 3, 6}, new[] {1, 4, 7}, new[] {2, 5, 8}, // Colunas verticais
                new[] {0, 4, 8}, new[] {2, 4, 6} // Diagonais
            };

            foreach (var condition in winConditions)
            {
                if (array[condition[0]] == symbol && array[condition[1]] == symbol && array[condition[2]] == symbol)
                {
                    return true;
                }
            }

            return false; // Nenhum jogador com o símbolo especificado venceu ainda
        }
    }
}