using System;

namespace TicTacGame
{
    class Program
    {
        static char[,] playBoard = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        static void Main(string[] args)
        {
            EnterXO();
        }

        public static void setBoard()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("    |    |    ");
            Console.WriteLine(" {0}  | {1}  |  {2}", playBoard[0,0], playBoard[0, 1], playBoard[0, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");       
            Console.WriteLine(" {0}  | {1}  |  {2}", playBoard[1, 0], playBoard[1, 1], playBoard[1, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            Console.WriteLine(" {0}  | {1}  |  {2}", playBoard[2, 0], playBoard[2, 1], playBoard[2, 2]);
        }
        public static void EnterXO()
        {
            int counter = 0;
            int player = 1;
            int input = 0;
            bool correctOrNot = true;
            int flag;
            while (correctOrNot)
            {
                flag = 1;
                setBoard();
                Console.WriteLine("Player {0} please enter your choice. press other key to exit.", player);
                correctOrNot = int.TryParse(Console.ReadLine(), out input);
                
                Console.Clear();             
                char playerSign = ' ';
                if (player == 1)
                {
                    player = 2;
                    playerSign = 'X';
                }
                else if (player == 2)
                {
                    player = 1;
                    playerSign = 'O';
                }
                switch (input)
                {
                    case 1:
                        if (playBoard[0, 0] == '1')
                        {
                            playBoard[0, 0] = playerSign;
                            counter++;
                        }
                        else
                        { 
                            Console.WriteLine("This is not an empty place. Please try again.");
                            if (player == 1)
                            {
                                player = 2;
                            }
                            else
                                player = 1;
                        }
                        break;
                    case 2:
                        if (playBoard[0, 1] == '2')
                        {
                            playBoard[0, 1] = playerSign;
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("This is not an empty place. Please try again.");
                            if (player == 1)
                            {
                                player = 2;
                            }
                            else
                                player = 1;
                        }
                        break;
                    case 3:
                        if (playBoard[0, 2] == '3')
                        {
                            playBoard[0, 2] = playerSign;
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("This is not an empty place. Please try again.");
                            if (player == 1)
                            {
                                player = 2;
                            }
                            else
                                player = 1;
                        }
                        break;
                    case 4:
                        if (playBoard[1, 0] == '4')
                        {
                            playBoard[1, 0] = playerSign;
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("This is not an empty place. Please try again.");
                            if (player == 1)
                            {
                                player = 2;
                            }
                            else
                                player = 1;
                        }
                            break;
                    case 5:
                        if (playBoard[1, 1] == '5')
                        {
                            playBoard[1, 1] = playerSign;
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("This is not an empty place. Please try again.");
                            if (player == 1)
                            {
                                player = 2;
                            }
                            else
                                player = 1;
                        }
                            break;
                    case 6:
                        if (playBoard[1, 2] == '6')
                        {
                            playBoard[1, 2] = playerSign;
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("This is not an empty place. Please try again.");
                            if (player == 1)
                            {
                                player = 2;
                            }
                            else
                                player = 1;
                        }
                            break;
                    case 7:
                        if (playBoard[2, 0] == '7')
                        {
                            playBoard[2, 0] = playerSign;
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("This is not an empty place. Please try again.");
                            if (player == 1)
                            {
                                player = 2;
                            }
                            else
                                player = 1;
                        }
                            break;
                    case 8:
                        if (playBoard[2, 1] == '8')
                        {
                            playBoard[2, 1] = playerSign;
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("This is not an empty place. Please try again.");
                            if (player == 1)
                            {
                                player = 2;
                            }
                            else
                                player = 1;
                        }
                            break;
                    case 9:
                        if (playBoard[2, 2] == '9')
                        {
                            playBoard[2, 2] = playerSign;
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("This is not an empty place. Please try again.");
                            if (player == 1)
                            {
                                player = 2;
                            }
                            else
                                player = 1;
                        }
                            break;
                    default: Console.WriteLine("Wrong key. Please choose:");break;
                }
            
               if((playBoard[0,0]== playBoard[0,1]) && (playBoard[0, 0]== playBoard[0, 2])|| (playBoard[1, 0]== playBoard[1, 1])&& (playBoard[1, 2]== playBoard[1,2]) || (playBoard[2, 0]== playBoard[2, 1])&&(playBoard[2, 1]== playBoard[2, 2])||(( playBoard[0, 0]== playBoard[1 ,1])&& (playBoard[0, 0]== playBoard[2, 2])|| (playBoard[0,0]== playBoard[1, 0])&&( playBoard[1, 0]== playBoard[2, 0]))|| (playBoard[0, 1]== playBoard[1, 1])&& (playBoard[1, 1]== playBoard[2, 1]) || (playBoard[0,2]== playBoard[1,2])&& (playBoard[1,2]== playBoard[2, 2])||(playBoard[0, 2]== playBoard[1, 1])&&( playBoard[0, 2]== playBoard[2,0]))
               {
                    setBoard();
                    if(player==2)
                        Console.WriteLine("Player 1 is winning!");
                    else
                        Console.WriteLine("Player 2 is winning!");
                    //if (playBoard[0, 0] == 'X')
                    //    Console.WriteLine("Player 1 is the winner!"); 
                    //else
                    //    Console.WriteLine("Player 2 is the winner!");
                    break;
               }
                if (counter == 9)
                {
                    setBoard();
                    Console.WriteLine("Even result"); 
                    break;
                }

                }
                Console.WriteLine("Press 1 either you want to reset the game or other key to stop.");
            string resetInput = Console.ReadLine();
            int result;
            bool ToF = int.TryParse(resetInput, out result);
            if (ToF && result == 1)
                resetBoard();
            else
                Console.WriteLine("Thank you for playing!");
        }
       public static void resetBoard()
        {
            int i, j,k=1;
            char[,] playAgain = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            Console.Clear();
            char myChar;
            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                    playBoard[i, j] = playAgain[i, j];
            EnterXO();
        }
    }
}
