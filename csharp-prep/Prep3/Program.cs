using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        bool cdw_playAgain = true;
        while (cdw_playAgain)
        {
            int cdw_magicNumber = randomGenerator.Next(1,101);
            int cdw_guessCount = 0;
            bool cdw_flag = true;
            while (cdw_flag)
            {
                int cdw_userGuess = cdw_getInt("What is your guess?");
                if (cdw_userGuess < cdw_magicNumber)
                {
                    Console.WriteLine("Higher");

                } 
                else if (cdw_userGuess > cdw_magicNumber)
                {
                    Console.WriteLine("Lower");

                }
                else if (cdw_userGuess == cdw_magicNumber)
                {
                    Console.WriteLine($"You guessed it! in {cdw_guessCount} guesses!");
                    cdw_flag = false;
                    string cdw_userPlayAgain = getString("Do you want to play again? Yes or No.");
                    if (cdw_userPlayAgain == "No")
                    {
                        cdw_playAgain = false;
                        Console.WriteLine("Thank you for playing!");
                    }
                }
                cdw_guessCount++;
            }
        }
    }

    static string getString(string Prompt)
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

    static int cdw_getInt(string Prompt)
    {
        int cdw_returnValue = 0;
        bool cdw_flag = true;
        while (cdw_flag)
        {
            try
            {
                Console.WriteLine(Prompt);
                string cdw_userInputString = Console.ReadLine();
                cdw_returnValue = int.Parse(cdw_userInputString);
                cdw_flag = false;
            }
            catch (Exception)
            {
                Console.WriteLine("Value is not acceptable, please enter a valid integer.");
            }
        }
        return cdw_returnValue;

    }
}