using System;

class Program
{
    static void Main(string[] args)
    {
        bool cdw_isRunning = true;
        bool cdw_allHidden = false;
        string cdw_userPrompt = "";
        Scripture cdw_scripture = cdw_getScripture();
        string cdw_memorizeScripture = cdw_scripture.cdw_toString(false);
        Console.Clear();
        Console.WriteLine(cdw_memorizeScripture);
        Console.WriteLine("\n\n\n\nType 'quit' to exit.");
        Console.ReadLine();
        Console.Clear();
        while (cdw_isRunning == true)
        {
            cdw_memorizeScripture = cdw_scripture.cdw_toString(true);
            if (cdw_memorizeScripture == "quit")
            {
                cdw_allHidden = true;
                Console.WriteLine("You have memorized the Scripture! Great Job!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(cdw_memorizeScripture);
                Console.WriteLine("\n\n\n\nType 'quit' to exit.");
                cdw_userPrompt = Console.ReadLine();
            }
            
            
            if (cdw_userPrompt == "quit")
            {
                cdw_isRunning = false;
            }
            if (cdw_allHidden == true)
            {
                cdw_isRunning = false;
            }
            Console.Clear();
            
        }
    }

    static string getString(string Prompt)
    {
        string returnValue =" ";
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
                Console.WriteLine("Value is not acceptable, please enter a valid word.");
            }
        }
        return returnValue;
    }

    static Scripture cdw_getScripture()
    {
        string cdw_userInputReference = getString("What is the reference of the scripture that you would like to use?");
        string cdw_userInputScripture = getString("What is the text of the scripture that you would like to memorize?");
        Scripture cdw_scripture = new Scripture();
        cdw_scripture.cdw_getScripture(cdw_userInputReference, cdw_userInputScripture);
        return cdw_scripture;
    }
}