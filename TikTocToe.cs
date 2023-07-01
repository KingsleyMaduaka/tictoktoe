using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCode1
{
    internal class TikTocToe
    {
        private string[,] tiktok = new string[,] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        private string[,] tiktoktoe = new string[3, 3];

       
        public void StartGame()
        {
           
            bool win = true;
            bool game = false;
            try
            {
                Console.Title = "Tik Tok Toe";
                printData(tiktok);
                do
                {
                    PlayerOne(tiktok);
                    printData(tiktok);
                    if (CheckPlayerOneWinner(tiktok))
                    {
                        Console.WriteLine("Player one wins");
                        game = true;
                        win = false;
                        break;
                    }
                        
                    PlayerTwo(tiktok);
                    printData(tiktok);
                    if (CheckPlayerTwoWinner(tiktok))
                    {
                        Console.WriteLine("Player two wins");
                        game = true;
                        win = false;
                    }
                }
                while (win);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Game problem");
            }
        }
        public string[,] printData(string[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i, j] + "\t ");
                }
                Console.WriteLine();
            }

            return data;
        }
        public int ComputerRandom()
        {
            int randNum;
            Random rand = new Random();
            randNum = rand.Next(1, 10);
            return randNum;
        }
        public bool ConfirmNum(string[,] data)
        {
            int a= 0;
            int b= 0;
            
            bool check = true;
            bool ok = false;
          
            do
            {
              
                
            }
            while(check);

            return ok;
        }
        
        public bool ComputerPlay(string[,] data)
        {
            Console.WriteLine("Computer turn ");
            bool ok = false;
            bool confirm = false;
            int computerChoice = ComputerRandom();
            try
            {
                do
                {
                    if (computerChoice == 1 )
                    {
                        data[0, 0] = "Z";
                        ok = true;
                        return ok;
                    }
                    else if (computerChoice == 2)
                    {
                        data[0, 1] = "Z";
                        ok = true;
                        return ok;
                    }
                    else if (computerChoice == 3)
                    {
                        data[0, 2] = "Z";
                        ok = true;
                        return ok;
                    }
                    else if (computerChoice == 4)
                    {
                        data[1, 0] = "Z";
                        ok = true;
                        return ok;
                    }
                    else if (computerChoice == 5)
                    {
                        data[1, 1] = "Z";
                        ok = true;
                        return ok;
                    }
                    else if (computerChoice == 6)
                    {
                        data[1, 2] = "Z";
                        ok = true;
                        return ok;
                    }
                    else if (computerChoice == 7)
                    {
                        data[2, 0] = "Z";
                        ok = true;
                        return ok;
                    }
                    else if (computerChoice == 8)
                    {
                        data[2, 1] = "Z";
                        ok = true;
                        return ok;
                    }
                    else if (computerChoice == 9)
                    {
                        data[2, 2] = "Z";
                        ok = true;
                        return ok;
                    }
                    
                }
                while (confirm) ;
            }
            catch (Exception e)
            {
                Console.WriteLine("somthing went Wrong");
            }
            
            return ok;
        }
       
        public bool CheckPlayerTwoWinner(string[,] data)
        {
            bool winner = false;

            if (data[0, 0] == "0" && data[0, 1] == "0" && data[0, 2] == "0")
            {
                Console.WriteLine("Player 0 wins");
                winner = true;
                return winner;

            }
            else if (data[1, 0] == "0" && data[1, 1] == "0" && data[1, 2] == "0")
            {
                Console.WriteLine("Player 0 wins");
                winner = true;
                return winner;
            }
            else if (data[2, 0] == "0" && data[2, 1] == "0" && data[2, 2] == "0")
            {
                Console.WriteLine("Player 0 wins");
                winner = true;
                return winner;
            }
            else if (data[0, 0] == "0" && data[1, 1] == "0" && data[2, 2] == "0")
            {
                Console.WriteLine("Player 0 wins");
                winner = true;
                return winner;
            }
            else if (data[0, 2] == "0" && data[1, 1] == "0" && data[2, 0] == "0")
            {
                Console.WriteLine("Player 0 wins");
                winner = true;
                return winner;
            }
            else if (data[0, 1] == "0" && data[1, 1] == "0" && data[2, 1] == "0")
            {
                Console.WriteLine("Player 0 wins");
                winner = true;
                return winner;
            }
            else if (data[0,0] == "0" && data[1,0] == "0" && data[2,0] == "0")
            {
                Console.WriteLine("Player 0 wins");
                winner = true;
                return winner;
            }
            else if (data[0,2] == "0" && data[1,2] == "0" && data[2,2] == "0")
            {
                Console.WriteLine("Player 0 wins");
                winner = true;
                return winner;
            }
            
            return winner;

        }
        public bool CheckPlayerOneWinner(string[,] data)
        {
            bool winner = false;

            if (data[0, 0] == "X" && data[0,1] == "X" && data[0,2] == "X") 
            {
                Console.WriteLine("Player X wins");
                winner = true;
                return winner;
            
            }
            else if (data[1,0] == "X" && data[1,1] == "X" && data[1,2] == "X")
            {
                Console.WriteLine("Player X wins");
                winner = true;
                return winner;
            }
            else if (data[2,0] == "X" && data[2,1] == "X" && data[2,2] == "X")
            {
                Console.WriteLine("Player X wins");
                winner = true;
                return winner;
            }
            else if (data[0, 0] == "X" && data[1, 1] == "X" && data[2, 2] == "X")
            {
                Console.WriteLine("Player X wins");
                winner = true;
                return winner;
            }
            else if (data[0, 2] == "X" && data[1, 1] == "X" && data[2, 0] == "X")
            {
                Console.WriteLine("Player X wins");
                winner = true;
                return winner;
            }
            else if (data[0, 1] == "X" && data[1, 1] == "X" && data[2, 1] == "X")
            {
                Console.WriteLine("Player X wins");
                winner = true;
                return winner;
            }
            else if (data[0, 0] == "X" && data[1, 0] == "X" && data[2, 0] == "X")
            {
                Console.WriteLine("Player X wins");
                winner = true;
                return winner;
            }
            else if (data[0, 2] == "X" && data[1, 2] == "X" && data[2, 2] == "X")
            {
                Console.WriteLine("Player X wins");
                winner = true;
                return winner;
            }
            else
            {
                Console.WriteLine();
            }
            

            return winner;
        }
        public bool PlayerTwo(string[,] data)
        {
            bool ok = false;
            bool confirm = false;
            int playerOne;
            Console.Write("Player two turn: ");
            playerOne = Convert.ToInt32(Console.ReadLine());
            try
            {
                do
                {
                    if (playerOne == 1 && data[0, 0] != "X")
                    {
                        data[0, 0] = "0";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 2 && data[0,1] != "X")
                    {
                        data[0, 1] = "0";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 3 && data[0, 3] != "X")
                    {
                        data[0, 2] = "0";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 4 && data[1, 0] != "X")
                    {
                        data[1, 0] = "0";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 5 && data[1, 1] != "X")
                    {
                        data[1, 1] = "0";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 6 && data[1, 2] != "X")
                    {
                        data[1, 2] = "0";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 7 && data[2, 0] != "X")
                    {
                        data[2, 0] = "0";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 8 && data[2, 1] != "X")
                    {
                        data[2, 1] = "0";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 9 && data[2, 2] != "X")
                    {
                        data[2, 2] = "0";
                        ok = true;
                        return ok;
                    }
                    else { Console.WriteLine("Number already taken or not valid"); }

                }
                while (confirm);
            }
            catch (Exception e)
            {
                Console.WriteLine("somthing went Wrong");
            }
             return ok;
        }
        public bool PlayerOne(string[,] data)
        {
            bool ok = false;
            bool confirm = false;
            int playerOne;
            Console.Write("Player one turn: ");
            playerOne = Convert.ToInt32(Console.ReadLine());
            try
            {
                do
                {
                    if (playerOne == 1 && data[0,0] != "0")
                    {
                        data[0, 0] = "X";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 2 && data[0, 1] != "0")
                    {
                        data[0, 1] = "X";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 3 && data[0, 2] != "0")
                    {
                        data[0, 2] = "X";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 4 && data[1, 0] != "0")
                    {
                        data[1, 0] = "X";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 5 && data[1, 1] != "0")
                    {
                        data[1, 1] = "X";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 6 && data[1, 2] != "0")
                    {
                        data[1, 2] = "X";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 7 && data[2, 0] != "0")
                    {
                        data[2, 0] = "X";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 8 && data[2, 1] != "0")
                    {
                        data[2, 1] = "X";
                        ok = true;
                        return ok;
                    }
                    else if (playerOne == 9 && data[2, 2] != "0")
                    {
                        data[2, 2] = "X";
                        ok = true;
                        return ok;
                    }
                    else { Console.WriteLine("Number already taken or not valid"); }

                }
                while (confirm);
            }
            catch (Exception e)
            {
                Console.WriteLine("somthing went Wrong");
            }
            
            return ok;
        }
    }
}
