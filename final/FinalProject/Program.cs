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

        //Process
            // Pass input variables to class instances and call class process information
        while(cdw_menuFlag == true)
        {
            Console.WriteLine("Thank you for playing 5-Minute Games!");
            Console.WriteLine("Menu: \n  1. Play Rock Paper Scissors \n  2. Play Trivia \n  3. Play Tic-Tac-Toe\n  4. Show Player Stats\n  5. Create New Player\n  6. Save Player Data\n  7. Load Player Data\n  8. Quit");
            cdw_menuChoice = toInt("What would you like to do? ");
            if (cdw_menuChoice == 1)
            {
                Console.WriteLine("Play Rock Paper Scissors");
                cdw_Pause();
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
                Console.WriteLine("Create a New Player");
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

    static void cdw_Pause()
    {
        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
    }

   static void cdw_SelectPlayer()
    {
        
    }

    static void cdw_SelectDifficulty()
    {
        
    }
    //Project Output functions that call Support Functions
    

}