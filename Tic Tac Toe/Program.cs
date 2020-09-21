using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Threading;


namespace Tic_Tac_Toe
{
    class Program
    {
        static char[] array = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };//board array
        static int choice;//player choose
        //static int player = 1;
        

        static int who_won = 0; //1 = win, -1 = draw, 0 = still running

       


        static void Main(string[] args)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 8);//random number 1 to 8
            Console.WriteLine("Dice value: {0}",dice);//show dice value
            Console.WriteLine("\n");



            Board();

            if (dice <= 4)
            {
                Console.WriteLine("Player 1 starts!");
                Console.WriteLine("\n");
                Player1();

            }
            else
            {
                Console.WriteLine("Player 2 starts!");
                Console.WriteLine("\n");
                Player2();
            }
            






            /*while (who_won == 0)
            {
                Console.Clear();
                Console.WriteLine("Player 1: X nad Player 2: O");
                if (array[choice] != 'X' && array[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        Console.WriteLine("Player 1 plays...");
                        array[choice] = 'X';
                        player++;
                    }
                    else
                    {
                        Console.WriteLine("Player 2 plays...");
                        array[choice] = 'O';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, array[choice]);

                    Console.WriteLine("\n");

                 
                }
                Console.WriteLine("\n");
                Board();
                Console.WriteLine("Choose...");
                Console.WriteLine("\n");
                choice = int.Parse(Console.ReadLine());

            }*/





        }

        private static void Board()

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[0], array[1], array[2]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[3], array[4], array[5]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array[6], array[7], array[8]);

            Console.WriteLine("     |     |      ");

        }

        private static void Player1()
        {
      
            Console.WriteLine("Player 1 choose...");
            

            choice = int.Parse(Console.ReadLine());
            array[choice] = 'X';
        
        
          



            Board();
            CheckWinPlayer1();
            Player2();
            
        }

        private static void Player2()
        {


            Console.WriteLine("Player 2 choose...");
            choice = int.Parse(Console.ReadLine());
            array[choice] = 'O';


            Board();
            CheckWinPlayer2();
            Player1();
          
        }

        private static void CheckWinPlayer1()
        {
            if (array[0] == 'X' && array[1] == 'X' && array[2] == 'X')//top horizontal
            {
                Console.WriteLine("Player 1 win");
                

            }
            else if (array[3] == 'X' && array[4] == 'X' && array[5] == 'X')//mid horizontal
            {
                Console.WriteLine("Player 1 win");
            }
            else if (array[6] == 'X' && array[7] == 'X' && array[8] == 'X')//bot horizontal
            {
                Console.WriteLine("Player 1 win");
            }
            else if(array[0] == 'X' && array[3] == 'X' && array[6] == 'X')//left vertical
            {
                Console.WriteLine("Player 1 win");
            }
            else if (array[1] == 'X' && array[4] == 'X' && array[7] == 'X')//mid vertical
            {
                Console.WriteLine("Player 1 win");
            }
            else if (array[2] == 'X' && array[5] == 'X' && array[8] == 'X')//right vertical
            {
                Console.WriteLine("Player 1 win");
            }
            else if (array[0] == 'X' && array[4] == 'X' && array[8] == 'X')//diagonal
            {
                Console.WriteLine("Player 1 win");
                
            }
            else if(array[6] == 'X' && array[4] == 'X' && array[2] == 'X')//diagonal
            {
                Console.WriteLine("Player 1 win");
                
            }
            else if (array[0] != '0' && array[1] != '1' && array[2] != '2' && array[3] != '3' && array[4] != '4' && array[5] != '5' && array[6] != '6' && array[7] != '7' && array[8] != '8')//draw
            {
                Console.WriteLine("Draw");
            }



        }

        private static void CheckWinPlayer2()
        {
            if (array[0] == 'O' && array[1] == 'O' && array[2] == 'O')//top horizontal
            {
                Console.WriteLine("Player 2 win");

            }
            else if (array[3] == 'O' && array[4] == 'O' && array[5] == 'O')//mid horizontal
            {
                Console.WriteLine("Player 2 win");
            }
            else if (array[6] == 'O' && array[7] == 'O' && array[8] == 'O')//bot horizontal
            {
                Console.WriteLine("Player 2 win");
            }
            else if (array[0] == 'O' && array[3] == 'O' && array[6] == 'O')//left vertical
            {
                Console.WriteLine("Player 2 win");
            }
            else if (array[1] == 'O' && array[4] == 'O' && array[7] == 'O')//mid vertical
            {
                Console.WriteLine("Player 2 win");
            }
            else if (array[2] == 'O' && array[5] == 'O' && array[8] == 'O')//right vertical
            {
                Console.WriteLine("Player 2 win");
            }
            else if (array[0] == 'O' && array[4] == 'O' && array[8] == 'O')//diagonal
            {
                Console.WriteLine("Player 2 win");
            }
            else if (array[6] == 'O' && array[4] == 'O' && array[2] == 'O')//diagonal
            {
                Console.WriteLine("Player 2 win");
            }
            else if (array[0] != '0' && array[1] != '1' && array[2] != '2' && array[3] != '3' && array[4] != '4' && array[5] != '5' && array[6] != '6' && array[7] != '7' && array[8] != '8')//draw
            {
                Console.WriteLine("Draw");
            }
        }

        

    }
}
