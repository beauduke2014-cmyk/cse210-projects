using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");
        string cdw_UserName = cdw_GetString("Please Enter your name: ");
        int cdw_FavNumber = cdw_GetInt("Please enter your favorite number: ");
        int cdw_BirthYear = cdw_GetInt("Please enter the year you were born: ");
        int cdw_SquaredFavNumber = cdw_SquareNumber(cdw_FavNumber);
        int cdw_UserAge = cdw_CalculateAge(cdw_BirthYear);
        Console.WriteLine($"{cdw_UserName}, the square of your number is {cdw_SquaredFavNumber}.");
        Console.WriteLine($"{cdw_UserName}, you will turn {cdw_UserAge} this year.");
    }

    static int cdw_CalculateAge(int cdw_BirthYear)
    {
        int cdw_Age = 2026;
        cdw_Age -= cdw_BirthYear;
        return cdw_Age;
    }

    static int cdw_SquareNumber(int cdw_Number)
    {
        int cdw_SquaredNumber = cdw_Number * cdw_Number;
        return cdw_SquaredNumber;
    }

    static string cdw_GetString(string Prompt)
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
    static int cdw_GetInt(string Prompt)
    {
        int returnValue = 0;
        bool wac_flag = true;
        while (wac_flag)
        {
            try
            {
                Console.WriteLine(Prompt);
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
}