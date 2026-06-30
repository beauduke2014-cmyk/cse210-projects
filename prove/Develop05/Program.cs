using System;
using System.IO;
/* 
    Name: Carter Weber
    Class: CSE-210
    Description:A program to help keep track of goals and give rewards as they are completed, creating a game out of it.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher Notes
*/
class Program
{
    static void Main(string[] args)
    {
        List<Quest> cdw_questList = new List<Quest>();
        int cdw_points = 0;
        bool cdw_menuFlag = true;
        while(cdw_menuFlag == true)
        {
            
            Console.WriteLine($"You have {cdw_points} points.\n\n");
            int cdw_menuResponse = toInt("Menu Options \n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");
            if (cdw_menuResponse == 1)
            {
                Console.Clear();
                int cdw_createGoalChoice = toInt("The types of goals are: \n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhat type of goal would you like to create? ");
                if (cdw_createGoalChoice == 1)
                {
                    Simple cdw_simpleQuest = new Simple();
                    string cdw_name = toString("What is the name of your goal? ");
                    string cdw_description = toString("What is a short description of it? ");
                    int cdw_reward = toInt("What is the amount of points associated with this goal? ");
                    cdw_simpleQuest.cdw_CreateSimple(cdw_name, cdw_description, cdw_reward);
                    cdw_questList.Add(cdw_simpleQuest);
                    Console.Clear();
                }
                else if (cdw_createGoalChoice == 2)
                {
                    Eternal cdw_eternalQuest = new Eternal();
                    string cdw_name = toString("What is the name of your goal? ");
                    string cdw_description = toString("What is a short description of it? ");
                    int cdw_reward = toInt("What is the amount of points associated with this goal? ");
                    cdw_eternalQuest.cdw_CreateEternal(cdw_name, cdw_description, cdw_reward);
                    cdw_questList.Add(cdw_eternalQuest);
                    Console.Clear();
                }
                else if(cdw_createGoalChoice == 3)
                {
                    Checklist cdw_checklistQuest = new Checklist();
                    string cdw_name = toString("What is the name of your goal? ");
                    string cdw_description = toString("What is a short description of it? ");
                    int cdw_reward = toInt("What is the amount of points associated with this goal? ");
                    int cdw_goal = toInt("How many times does this goal need to be accomplished for a bonus? ");
                    int cdw_bonus = toInt("What is the bonus for accomplishing it that many times? ");
                    cdw_checklistQuest.cdw_CreateChecklist(cdw_name, cdw_description, cdw_reward, cdw_goal, cdw_bonus);
                    cdw_questList.Add(cdw_checklistQuest);
                    Console.Clear();
                }
            }
            else if(cdw_menuResponse == 2)
            {
                int cdw_goalCounter = 0;
                foreach (Quest cdw_quest in cdw_questList)
                {
                    cdw_goalCounter ++;
                    Console.WriteLine($"{cdw_goalCounter}. {cdw_quest.cdw_ToString()}");
                }
            }
            else if (cdw_menuResponse == 3)
            {
                Console.Clear();
                // 1
                string cdw_fileName = toString("What would you like the file to be called? (without the .txt)");
                cdw_fileName += ".txt";
                using (StreamWriter outputFile = new StreamWriter(cdw_fileName))
                {
                    foreach(Quest cdw_quest in cdw_questList)
                    {
                        outputFile.WriteLine($"{cdw_quest.cdw_SaveGoals()}");
                    }
                    outputFile.WriteLine($"{cdw_points}");
                }
            }
            else if (cdw_menuResponse == 4)
            {
                cdw_questList.Clear();
                Console.Clear();
                // 1
                string cdw_fileName = toString("What is the name of the file that you would like to load from? (Without the .txt) ");
                cdw_fileName += ".txt";
                string[] lines = System.IO.File.ReadAllLines(cdw_fileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(" // ");
                    if (parts.Length == 8)
                    {
                        Checklist cdw_checklistQuest = new Checklist();
                        cdw_checklistQuest.cdw_CreateChecklist(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[6]), int.Parse(parts[7]), int.Parse(parts[5]), bool.Parse(parts[4]));
                        cdw_questList.Add(cdw_checklistQuest);
                    }
                    else if (parts[0] == "Simple")
                    {
                        Simple cdw_simpleQuest = new Simple();
                        cdw_simpleQuest.cdw_CreateSimple(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                        cdw_questList.Add(cdw_simpleQuest);
                    }
                    else if (parts[0] == "Eternal")
                    {
                        Eternal cdw_eternalQuest = new Eternal();
                        cdw_eternalQuest.cdw_CreateEternal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                        cdw_questList.Add(cdw_eternalQuest);
                    }
                    else
                    {
                        cdw_points = int.Parse(parts[0]);
                    }
                }
            }
            else if (cdw_menuResponse == 5)
            {
                Console.Clear();
                Console.WriteLine("Which goal would you like to accomplish?");
                int cdw_goalCounter = 0;
                foreach (Quest cdw_quest in cdw_questList)
                {
                    cdw_goalCounter ++;
                    Console.WriteLine($"  {cdw_goalCounter}. {cdw_quest.cdw_GetName()}");
                }
                int cdw_goalChoice = toInt("Which goal did you accomplish? ");
                
                if (cdw_goalChoice <= cdw_questList.Count)
                {
                    cdw_goalChoice --;
                    Quest cdw_goal = cdw_questList[cdw_goalChoice];
                    cdw_points += cdw_goal.cdw_CompleteQuest();
                }
            }
            else if(cdw_menuResponse == 6)
            {
                Console.Clear();
                Console.WriteLine("Thank you for using the Quest/Goal Program!");
                cdw_menuFlag = false;
            }
        }
        
    }

    //Project Input functions that call Support Functions

    //Project Process functions that call Class
    //2
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
    //2
    static string toString(string Prompt)
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

    //Project Output functions that call Support Functions
    

}