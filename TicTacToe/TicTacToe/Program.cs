using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] boardArray = new string[9];
            bool isThereAWinner = false;
            bool isThereATie = false;
            char currentPlayer = 'O';
            bool validInput = false;
            bool playAgain = true;

            while (playAgain)
            {
                FillBoard(boardArray);
                DrawBoard(boardArray);

                while (!isThereAWinner && !isThereATie)
                {
                    if (currentPlayer == 'X')
                    {
                        currentPlayer = 'O';
                    }
                    else
                    {
                        currentPlayer = 'X';
                    }

                    while (!validInput)
                    {
                        validInput = GetPlayerInput(currentPlayer, boardArray);
                        DrawBoard(boardArray);
                    }

                    validInput = false;

                    isThereAWinner = IsGameOver(boardArray);

                    isThereATie = CheckForTie(boardArray);
                }

                if (isThereAWinner)
                {
                    Console.WriteLine("Player {0} Won the Game!!", currentPlayer);
                }
                else if (isThereATie)
                {
                    Console.WriteLine("No One Won the Game!!", currentPlayer);
                }

                Console.WriteLine("Play again? y/n");
                string again = Console.ReadLine();

                if (again == "y")
                    playAgain = true;
                else
                    playAgain = false;

                isThereATie = false;
                isThereAWinner = false;
            }

            Console.ReadLine();
        }

        static void FillBoard(string[] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = i.ToString();
            }
        }

        static void DrawBoard(string[] board)
        {
            Console.Clear();

            Console.WriteLine(string.Format("| {0} | {1} | {2} |", board[0], board[1], board[2]));
            Console.WriteLine("-------------");
            Console.WriteLine(string.Format("| {0} | {1} | {2} |", board[3], board[4], board[5]));
            Console.WriteLine("-------------");
            Console.WriteLine(string.Format("| {0} | {1} | {2} |", board[6], board[7], board[8]));
        }

        static bool GetPlayerInput(char player, string[] board)
        {
            bool returnValue = false;

            Console.WriteLine("The current player is {0}", player);

            Console.WriteLine("Enter a valid spot");
            string inputAsString = Console.ReadLine();

            if (IsInputValid(inputAsString, board))
            {
                int input = Convert.ToInt32(inputAsString);
                board[input] = player.ToString();
                returnValue = true;
            }

            return returnValue;
        }

        static bool IsInputValid(string input, string[] board)
        {
            bool valueToReturn = false;
            try
            {
                int tempConversion = Convert.ToInt32(input);

                if (tempConversion >= 0 && tempConversion < 9)
                {
                    if (board[tempConversion] == "X" || board[tempConversion] == "O")
                    {
                        valueToReturn = false;
                    }
                    else
                    {
                        valueToReturn = true;
                    }
                }
            }
            catch (Exception e)
            {
                string temp = e.Message;
            }

            return valueToReturn;
        }

        static bool CheckForTie(string[] board)
        {
            bool returnValue = true;

            for (int i = 0; i < board.Length; i++)
            {
                if(board[i] != "X" && board[i] != "O")
                {
                    returnValue = false;
                }
            }

            return returnValue;
        }

        static bool IsGameOver(string[] board)
        {
            bool valueToReturn = false;

            if (board[0] == board[1] && board[1] == board[2])
            {
                valueToReturn = true;
            }
            else if (board[3] == board[4] && board[4] == board[5])
            {
                valueToReturn = true;
            }
            else if (board[6] == board[7] && board[7] == board[8])
            {
                valueToReturn = true;
            }
            else if (board[0] == board[3] && board[3] == board[6])
            {
                valueToReturn = true;
            }
            else if (board[1] == board[4] && board[4] == board[7])
            {
                valueToReturn = true;
            }
            else if (board[2] == board[5] && board[5] == board[8])
            {
                valueToReturn = true;
            }
            else if (board[0] == board[4] && board[4] == board[8])
            {
                valueToReturn = true;
            }
            else if (board[2] == board[4] && board[4] == board[6])
            {
                valueToReturn = true;
            }

            return valueToReturn;
        }
    }
}
