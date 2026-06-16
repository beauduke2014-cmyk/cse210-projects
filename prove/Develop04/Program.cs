using System;
using System.Reflection;
using System.Text.RegularExpressions;
/*
    Name: Carter Weber
    Class: CSE-210
    Description: A program to assist in the mindfulness of a user through three different walkthrough activities.
    Sources:
        1. https://byui-cse.github.io/cse-course-2023
        
*/
class Program
{
    static void Main(string[] args)
    {
        bool cdw_menuFlag = false;
        while(cdw_menuFlag != true)
        {
            int cdw_menuResponse = toInt("Mindfulness Program\nMenu Options:\n\t1. Start Breathing Activity\n\t2. Start Reflecting Activity\n\t3. Start Listing Activity\n\t4. Quit\nSelect a choice from the menu: ");
            Console.Clear();

            if (cdw_menuResponse == 1)
            {
                Breathing cdw_breathingActivity = new Breathing();
                cdw_breathingActivity.setActivity("Breathing", 0, "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                int cdw_duration = toInt(cdw_breathingActivity.getStartMessage());
                cdw_breathingActivity.setTime(cdw_duration);
                DateTime cdw_endTime = cdw_breathingActivity.startActivity();
                while(DateTime.Now <= cdw_endTime)
                {
                    Console.Clear();
                    Console.WriteLine("Breath in");
                    Animation();
                    Console.WriteLine("\nBreath out");
                    Animation();
                    Console.Clear();
                }
                Console.WriteLine(cdw_breathingActivity.getEndMessage());
                endCountDown();
            }
            else if (cdw_menuResponse == 2)
            {
                Reflection cdw_reflectionActivity = new Reflection();
                List<string> cdw_prompts = new List<string>();
                cdw_prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
                List<string> cdw_questions = new List<string>();
                cdw_questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
                cdw_reflectionActivity.setActivity("Reflection", 0, "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                cdw_reflectionActivity.setReflection(cdw_prompts, cdw_questions);
                int cdw_duration = toInt(cdw_reflectionActivity.getStartMessage());
                cdw_reflectionActivity.setTime(cdw_duration);
                string cdw_prompt = cdw_reflectionActivity.getRandomPrompt();
                DateTime cdw_endTime = cdw_reflectionActivity.startActivity();
                while(DateTime.Now <= cdw_endTime)
                {
                    Console.Clear();
                    Console.WriteLine(cdw_prompt + "\n\n" + cdw_reflectionActivity.getRandomQuestion());
                    Animation();
                    Console.WriteLine("\b \b");
                    Animation();
                }
                Console.Clear();
                Console.WriteLine(cdw_reflectionActivity.getEndMessage());
                endCountDown();
            }
            else if (cdw_menuResponse == 3)
            {
                Listing cdw_listingActivity = new Listing();
                List<string> cdw_prompts = new List<string>();
                cdw_prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
                cdw_listingActivity.setPrompts(cdw_prompts);
                cdw_listingActivity.setActivity("Listing", 0, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                int cdw_duration = toInt(cdw_listingActivity.getStartMessage());
                cdw_listingActivity.setTime(cdw_duration);
                string cdw_prompt = cdw_listingActivity.getRandomPrompt();
                int cdw_inputCounter = 0;
                Console.Clear();
                Console.WriteLine(cdw_prompt);
                countDown();
                DateTime cdw_endTime = cdw_listingActivity.startActivity();
                while(DateTime.Now <= cdw_endTime)
                {
                    Console.ReadLine();
                    cdw_inputCounter ++;
                }
                Console.Clear();
                Console.WriteLine("You entered "+ cdw_inputCounter + " responses!");
                Console.WriteLine("\n\n" + cdw_listingActivity.getEndMessage());
                endCountDown();
            }
            else if(cdw_menuResponse == 4)
            {
                Console.Clear();
                Console.WriteLine("Thank you for using the Mindfulness Program!");
                cdw_menuFlag = true;
            }

        }
    }

    static void Animation()
    {
        Random cdw_random = new Random();
        int cdw_randomNumber = cdw_random.Next(3);
        if (cdw_randomNumber == 0)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("o");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("O");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("o");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write(".");
            Thread.Sleep(1000);
        }
        else if (cdw_randomNumber == 1)
        {
            Console.Write("-");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("_");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("v");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("V");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(1000);
        }
        else if (cdw_randomNumber == 2)
        {
            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(1000);
        }
        
    }
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
    static void endCountDown()
    {
        int cdw_count = 0;
        while(cdw_count < 2)
        {
            Animation();
            Console.WriteLine("\b \b");
            cdw_count++;
        }
        Console.Clear();
    }
    static void countDown()
    {
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("Go");
    }
}