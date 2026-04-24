/*
Author: Carter Weber

Sources:
    Class = 1
*/

using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        string cdw_firstName = cdw_getFirstName();
        string cdw_lastName = cdw_getLastName();
        Console.WriteLine($"Your name is {cdw_lastName}, {cdw_firstName} {cdw_lastName}");
    }

    static string cdw_getFirstName()
    {
        string prompt = "What is your first name?";
        string cdw_firstName = getString(prompt);
        return cdw_firstName;
    }

    static string cdw_getLastName()
    {
        string prompt = "What is your last name?";
        string cdw_lastName = getString(prompt);
        return cdw_lastName;
    }

//1
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
}