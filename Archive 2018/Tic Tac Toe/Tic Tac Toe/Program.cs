using System;
using System.Threading;
namespace Tic_Tac_Toe
{
    class Program
    {
        //making array and   
        //by default I am providing 0-9 where no use of zero  
        static char[] box = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; //By default player 1 is set  
        static int choice; //This holds the choice of the position that the user wants to mark        
        static int value = 0; //The "value" checks who has won. If it is equal to 1 then some one has won, if it is equal to -1 then it is a Draw, if 0 then match is still running
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();// whenever loop will be again start then screen will be clear  
                Console.WriteLine("Player 1: X and Player 2: O");
                Console.WriteLine("\n");
                if (player % 2 == 0)//checking the chance of the player  
                {
                    Console.WriteLine("Player 2's Turn");
                }
                else
                {
                    Console.WriteLine("Player 1's Turn");
                }
                Console.WriteLine("\n");
                Board();// calling the board Function  
                choice = int.Parse(Console.ReadLine());//Taking users choice   
                // checking that position where user want to run is marked (with X or O) or not  
                if (box[choice] != 'X' && box[choice] != 'O')
                {
                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X  
                    {
                        box[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        box[choice] = 'X';
                        player++;
                    }
                }
                else 
                {
                    Console.WriteLine("Sorry, box {0} is already marked with {1}", choice, box[choice]);
                    Thread.Sleep(2000);
                }
                value = CheckWin();
            } while (value != 1 && value != -1);

            Console.Clear(); //Clears the board
            Board(); //Resets the board
            if (value == 1) //if the value is 1 then there is a winner
            {
                Console.WriteLine("Player {0} Wins!", (player % 2) + 1);
            }
            else // if the value is -1 then its a draw and no one wins
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        // Draws the board
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", box[1], box[2], box[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", box[4], box[5], box[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", box[7], box[8], box[9]);
            Console.WriteLine("     |     |      ");
        }
        //Checks to see if a player has won or not
        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Winning condition for first row   
            if (box[1] == box[2] && box[2] == box[3])
            {
                return 1;
            }
            //Winning condition for second row   
            else if (box[4] == box[5] && box[5] == box[6])
            {
                return 1;
            }
            //Winning condition for third row   
            else if (box[6] == box[7] && box[7] == box[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning condition for first column       
            else if (box[1] == box[4] && box[4] == box[7])
            {
                return 1;
            }
            //Winning condition for second column  
            else if (box[2] == box[5] && box[5] == box[8])
            {
                return 1;
            }
            //Winning condition for third column  
            else if (box[3] == box[6] && box[6] == box[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (box[1] == box[5] && box[5] == box[9])
            {
                return 1;
            }
            else if (box[3] == box[5] && box[5] == box[7])

            {
                return 1;
            }
            #endregion
            #region 
            // If all of the box's are filled with X or O then a player has won the match  
            else if (box[1] != '1' && box[2] != '2' && box[3] != '3' && box[4] != '4' && box[5] != '5' && box[6] != '6' && box[7] != '7' && box[8] != '8' && box[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }

    }
}