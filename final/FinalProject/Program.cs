using System;
/* 
    Name: Carter Weber
    Class: CSE-210
    Description: A program designed to run and play multiple 5-minute games with either one or two players.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. 
*/
class Program
{
    static void Main(string[] args)
    {
        //Input
            // Get information from console and save it in a varialbe
        bool cdw_menuFlag = true;
        int cdw_menuChoice = 0;
        List<Player> cdw_playerList = new List<Player>();
        ComputerPlayer cdw_easy = new ComputerPlayer();
        ComputerPlayer cdw_medium = new ComputerPlayer();
        ComputerPlayer cdw_hard = new ComputerPlayer();
        cdw_easy.cdw_SetDifficulty(1);
        cdw_medium.cdw_SetDifficulty(2);
        cdw_hard.cdw_SetDifficulty(3);

        //Process
            // Pass input variables to class instances and call class process information
        while(cdw_menuFlag == true)
        {
            Console.WriteLine("Thank you for playing 5-Minute Games!");
            Console.WriteLine("Menu: \n  1. Play Rock Paper Scissors \n  2. Play Trivia \n  3. Play Tic-Tac-Toe\n  4. Show Player Stats\n  5. Create New Player\n  6. Save Player Data\n  7. Load Player Data\n  8. Quit");
            cdw_menuChoice = toInt("What would you like to do? ");
            Console.Clear();
            if (cdw_menuChoice == 1)
            {
                RockPaperScissors cdw_RPS = new RockPaperScissors();
                int cdw_playerCount = cdw_GetPlayerCount();
                int cdw_difficulty = 0;
                int cdw_rewardPoints = 0;
                Player cdw_playerOne;
                Player cdw_playerTwo;
                if (cdw_playerCount == 1)
                {
                    cdw_difficulty = cdw_SelectDifficulty();
                    cdw_rewardPoints = cdw_SelectReward(cdw_difficulty);
                    cdw_playerOne = cdw_SelectPlayer(cdw_playerList);
                    Console.Clear();
                    //Input data to the class and introduce game
                    cdw_RPS.cdw_Initialize("Rock Paper Scissors", "Each turn the players will pick between one of three options: rock, paper, and scissors. Rock beats scissors, scissors beats paper, and paper beats rock. Whoever chooses the item that beats the opponent wins the game. If both players choose the same item, it is a tie and they play again until a winner is chosen.", cdw_rewardPoints, cdw_playerCount);
                    cdw_RPS.cdw_ToString();
                    Console.Clear();
                    //start of playing the game
                    bool cdw_gameFlag = true;
                    while (cdw_gameFlag == true)
                    {
                        string cdw_Game = cdw_RPS.cdw_StartGame();
                        bool cdw_flag = true;
                        string cdw_RPSChoice = "";
                        while(cdw_flag == true)
                        {
                            cdw_RPSChoice = answerToString(cdw_Game);
                            if (cdw_RPSChoice == "Rock" || cdw_RPSChoice == "Paper" || cdw_RPSChoice == "Scissors")
                            {
                                cdw_flag = false;
                            }
                            else
                            {
                                Console.WriteLine("That is an invalid input. Make sure you enter the option you want to choose.");
                            }
                        }
                        string cdw_computerAction = "";
                        if (cdw_difficulty == 1)
                        {
                            cdw_computerAction = cdw_easy.cdw_RPSAction(cdw_RPSChoice);
                        }
                        else if (cdw_difficulty == 2)
                        {
                            cdw_computerAction = cdw_medium.cdw_RPSAction(cdw_RPSChoice);
                        }
                        else if (cdw_difficulty == 3)
                        {
                            cdw_computerAction = cdw_hard.cdw_RPSAction(cdw_RPSChoice);
                        }
                        string cdw_results = cdw_RPS.cdw_CheckWinner(cdw_RPSChoice, cdw_computerAction);
                        Console.WriteLine($"The results are a {cdw_results}");
                        if (cdw_results == "Tie")
                        {
                            Console.WriteLine("Now to try again! ");
                        }
                        else
                        {
                            cdw_gameFlag = false;
                            if (cdw_results == "Lose")
                            {
                                cdw_playerOne.cdw_addLose();
                            }
                            else if(cdw_results == "Win")
                            {
                                cdw_playerOne.cdw_addWin();
                            }
                        }
                    }
                }
                else if (cdw_playerCount == 2)
                {
                    cdw_rewardPoints = cdw_SelectReward();
                    cdw_playerOne = cdw_SelectPlayer(cdw_playerList);
                    cdw_playerTwo = cdw_SelectPlayer(cdw_playerList);
                        cdw_Pause();
                    Console.Clear();
                    cdw_RPS.cdw_Initialize("Rock Paper Scissors", "Each turn the players will pick between one of three options: rock, paper, and scissors. Rock beats scissors, scissors beats paper, and paper beats rock. Whoever chooses the item that beats the opponent wins the game. If both players choose the same item, it is a tie and they play again until a winner is chosen.", cdw_rewardPoints, cdw_playerCount);
                    cdw_RPS.cdw_ToString();
                    cdw_Pause();
                    Console.Clear();
                    string cdw_Game = cdw_RPS.cdw_StartGame();
                    bool cdw_flag = true;
                    int cdw_RPSChoice = 0;
                    while(cdw_flag == true)
                    {
                        cdw_RPSChoice = toInt(cdw_Game);
                        if (cdw_RPSChoice > 3 || cdw_RPSChoice < 1)
                        {
                            Console.WriteLine("That is an invalid input. Make sure you enter the number next to the option you want to choose.");
                        }
                        else
                        {
                            cdw_flag = false;
                        }
                    }
                }
                

            }
            else if (cdw_menuChoice == 2)
            {
                Console.WriteLine("Play Trivia");
                cdw_Pause();
            }
            else if (cdw_menuChoice == 3)
            {
                TicTacToe cdw_ticTacToe = new TicTacToe();
                Console.WriteLine(cdw_ticTacToe.cdw_AssembleBoard());
                cdw_Pause();
            }
            else if (cdw_menuChoice == 4)
            {
                Console.WriteLine("Show Player Stats");
                cdw_Pause();
            }
            else if (cdw_menuChoice == 5)
            {
                HumanPlayer cdw_newPlayer = new HumanPlayer();
                string cdw_name = answerToString("What is the name of the player? ");
                cdw_newPlayer.cdw_Initialize(cdw_name);
                Console.WriteLine("New Player created!");
                cdw_playerList.Add(cdw_newPlayer);
                cdw_Pause();
            }
            else if (cdw_menuChoice == 6)
            {
                Console.WriteLine("Save Player Data");
                cdw_Pause();
            }
            else if (cdw_menuChoice == 7)
            {
                Console.WriteLine("Load Player Data");
                cdw_Pause();
            }
            else if (cdw_menuChoice == 8)
            {
                cdw_menuFlag = false;
            }
            else
            {
                Console.WriteLine("Not a valid input, please try again");
            }
            Console.Clear();
        }
        Console.WriteLine("Thank you for using the 5-Minute Games program!");


        //Output
            // Retrieve string state of class and pass it to Project Output functions
    }

    //Project Input functions that call Support Functions

    //Project Process functions that call Class
    static int toInt(string Prompt)
    {
        int returnValue = 0;
        bool wac_flag = true;
        while (wac_flag)
        {
            try
            {
                Console.Write(Prompt);
                string wacUserInputStr = Console.ReadLine();
                returnValue = int.Parse(wacUserInputStr);
                wac_flag = false;
            } catch (Exception e)
            {
                Console.WriteLine($"Value is not acceptable, please enter a valid number. {e}");
            }
        }
        return returnValue;
    }

    static string answerToString(string Prompt)
    {
        string returnValue ="";
        bool wac_flag = true;
        while(wac_flag)
        {
            try
            {
                Console.WriteLine(Prompt);
                returnValue = Console.ReadLine();
                if (string.IsNullOrEmpty(returnValue)==true)
                {
                    throw new Exception();
                }
                wac_flag = false;
            } catch(Exception)
            {
                Console.WriteLine("Value is not acceptable, please enter a valid name.");
            }
        }
        return returnValue;
    }

    static void cdw_Pause()
    {
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
    }

    static int cdw_GetPlayerCount()
    {
        bool cdw_flag = true;
        int cdw_playerCount = 0;
        while(cdw_flag == true)
        {
            cdw_playerCount = toInt("How many players will play this game? 1 or 2?  ");
            if (cdw_playerCount > 2 || cdw_playerCount < 1)
            {
                Console.WriteLine("That is not a valid input, please input a 1 or 2.");
            }
            else
            {
                cdw_flag = false;
            }
        }
        
        return cdw_playerCount;
    }

   static Player cdw_SelectPlayer(List<Player> cdw_playerList)
    {
        bool cdw_flag = true;
        Player cdw_playerOne;
        int cdw_playerChoice = 0;
        while (cdw_flag == true)
        {
            int cdw_playerCount = 0;
            Console.WriteLine("Players: ");
            foreach(Player cdw_player in cdw_playerList)
            {
                cdw_playerCount ++;
                Console.WriteLine($" {cdw_playerCount}. {cdw_player.cdw_GetName()}");
            }
            cdw_playerChoice = toInt("Which player would you like to play as? ");
            cdw_playerChoice --;
            if (cdw_playerChoice < 0 || cdw_playerChoice > cdw_playerList.Count)
            {
                Console.WriteLine("That is not a valid input, make sure you enter a number that is next to the player you want to play as.");
            }
            else
            {
                cdw_flag = false;
            }
            
        }
        return cdw_playerOne = cdw_playerList[cdw_playerChoice];
    }

    static int cdw_SelectDifficulty()
    {
        bool cdw_flag = true;
        int cdw_difficulty = 0;
        while (cdw_flag == true)
        {
            cdw_difficulty = toInt("What do you want the difficulty of the NPC to be? \n 1. Easy \n 2. Medium \n 3. Hard\n");
            if(cdw_difficulty > 3 || cdw_difficulty < 1)
            {
                Console.WriteLine("That is not a valid input, please enter a number between 1 and 3.");
            }
            else
            {
                cdw_flag = false;
            }
        }
        return cdw_difficulty;
        
    }

    static int cdw_SelectReward(int cdw_difficulty = 0)
    {
        int cdw_reward = 0;
        if (cdw_difficulty == 1)
        {
            cdw_reward = 100;
        }
        else if (cdw_difficulty == 2)
        {
            cdw_reward = 150;
        }
        else if (cdw_difficulty == 3)
        {
            cdw_reward = 200;
        }
        else
        {
            bool cdw_flag = true;
            while (cdw_flag == true)
            {
                cdw_reward = toInt("What would you like the reward to be for winning this match? ");
                if (cdw_reward < 0)
                {
                    Console.WriteLine("That is not a valid input, make sure the reward points is above 0");
                }
                else
                {
                    cdw_flag = false;
                }
            }
            
        }
        return cdw_reward;
    }
    //Project Output functions that call Support Functions
    

}