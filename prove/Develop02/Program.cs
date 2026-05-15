using System;
using System.Configuration.Assemblies;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int cdw_menuAnswer = 0;
        Journal cdw_entryList = new Journal();
        
        while (cdw_menuAnswer != 5)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Journal Program!");
            cdw_menuAnswer = cdw_Menu();
            if (cdw_menuAnswer == 1)
            {
                cdw_entryList._cdw_entries.Add(cdw_Write());
            }
            else if (cdw_menuAnswer == 2)
            {
                cdw_Display(cdw_entryList);
            }
            else if (cdw_menuAnswer == 3)
            {
                cdw_entryList = cdw_Load(cdw_entryList);
            }
            else if (cdw_menuAnswer == 4)
            {
                cdw_Save(cdw_entryList);
            }
        }
        Console.Clear();
        Console.WriteLine("Thank you for using the Journal Program!");

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

    //Write a new entry and save it to the entry class
    static Entry cdw_Write()
    {
        Console.Clear();
        int cdw_writeAnswer = toInt("Please select one of the following: \n1. Create custom prompt \n2. Use random prompt");
        Console.Clear();
        Entry cdw_newEntry = new Entry();
        Prompt cdw_promptList = new Prompt();
        if (cdw_writeAnswer == 1)
        {
            string cdw_newPrompt = toString("Please enter the prompt you would like to use.");
            cdw_newEntry._cdw_prompt = cdw_newPrompt;
            cdw_promptList._prompts.Add(cdw_newPrompt);
            cdw_newEntry._cdw_entry = toString(cdw_newPrompt + "\nEntry: ");
            cdw_newEntry._cdw_date = DateTime.Now.ToString("MM/dd/yyyy");
        }
        else if(cdw_writeAnswer == 2)
        {
            Random cdw_random = new Random();
            int cdw_randomIndex = cdw_random.Next(cdw_promptList._prompts.Count);
            string cdw_randomPrompt = cdw_promptList._prompts[cdw_randomIndex];
            cdw_newEntry._cdw_prompt = cdw_randomPrompt;
            cdw_newEntry._cdw_date = DateTime.Now.ToString("MM/dd/yyyy");
            cdw_newEntry._cdw_entry = toString(cdw_randomPrompt + "\nEntry: ");
        }
        return cdw_newEntry;
        
    }

    //From instructor Documentation: W. Clements 2026, Class Notes
    //Get a valid string from the User
    static string toString(string Prompt)
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


    //Display all entries in the journal
    static void cdw_Display(Journal cdw_journal)
    {
        Console.Clear();
        Console.WriteLine(cdw_journal.cdw_compileJournal());
        Console.WriteLine("Press Enter to Continue...");
        Console.ReadLine();
    }

    //Load a previous journal from a file
    static Journal cdw_Load(Journal cdw_journal)
    {
        Console.Clear();
        string cdw_fileName = toString("Please enter the filename under which your journal is saved: ");
        string[] lines = System.IO.File.ReadAllLines(cdw_fileName);

        foreach (string line in lines)
        {
            string[] cdw_item = line.Split(",,");
            Entry cdw_newEntry = new Entry();
            cdw_newEntry._cdw_date = cdw_item[0];
            cdw_newEntry._cdw_prompt = cdw_item[1];
            cdw_newEntry._cdw_entry = cdw_item[2];
            cdw_journal._cdw_entries.Add(cdw_newEntry);
        }
        Console.WriteLine("Press Enter to Continue...");
        Console.ReadLine();
        return cdw_journal;
    }

    //Save current journal to a file
    static void cdw_Save(Journal cdw_journal)
    {
       Console.Clear();
       string cdw_fileName = toString("Please enter the new filename:");
        cdw_journal.cdw_writeToFile(cdw_fileName);
        Console.WriteLine($"Your Journal has been saved to {cdw_fileName}");
        Console.WriteLine("Press Enter to Continue...");
        Console.ReadLine();
    }
}