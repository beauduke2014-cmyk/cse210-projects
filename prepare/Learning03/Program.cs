using System;

class Program
{
    static void Main(string[] args)
    {
        bool cdw_isRunning = true;
        bool cdw_allHidden = false;
        string cdw_userPrompt = "";
        while (cdw_isRunning == true)
        {
            Scripture cdw_scripture = cdw_getScripture();
            cdw_userPrompt = getString("");
            if (cdw_userPrompt == "quit")
            {
                cdw_isRunning = false;
            }
            if (cdw_allHidden == true)
            {
                cdw_isRunning = false;
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
        return cdw_scripture;
    }
}