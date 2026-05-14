using System;

class Program
{
    static void Main(string[] args)
    {
        int cdw_menuAnswer = 0;
        Console.WriteLine("Welcome to the Journal Program!");
        while (cdw_menuAnswer != 5)
        {
            cdw_menuAnswer = cdw_Menu();
            Console.WriteLine(cdw_menuAnswer);
        }

    }

    //The use of the menu, printing it, and returning the answer that is given.
    static int cdw_Menu()
    {
        int cdw_response = 0;
        Console.WriteLine("Please select one of the following: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
        cdw_response = toInt("What would you like to do? ");
        return cdw_response;
    }

    //From instructor documentation: W. Clements 2026, Class Notes
    //Transfer input to a int
    static int toInt(string Prompt)
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