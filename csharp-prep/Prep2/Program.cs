using System;

class Program
{
    static void Main(string[] args)
    {
        float cdw_gradePercentage = cdw_getGradePercentage();
        string cdw_gradeLetter = cdw_getGradeLetter(cdw_gradePercentage);
        string cdw_pass = cdw_checkPass(cdw_gradePercentage);

        Console.WriteLine($"Your final Grade is {cdw_gradeLetter} with a {cdw_gradePercentage}%, so you {cdw_pass} this class.");

    }

    static float cdw_getGradePercentage()
    {
        float cdw_gradePercentage = toFloat("Please enter your Grade Percentage.");
        return cdw_gradePercentage;
    }
    
    static string cdw_getGradeLetter(float cdw_gradePercentage)
    {
        string cdw_gradeLetter = "";
        if (cdw_gradePercentage > 90)
        {
            cdw_gradeLetter = "A";
        }
        else if (cdw_gradePercentage > 80)
        {
            cdw_gradeLetter = "B";
        }
        else if (cdw_gradePercentage > 70)
        {
            cdw_gradeLetter = "C";
        }
        else if (cdw_gradePercentage > 60)
        {
            cdw_gradeLetter = "D";
        }
        else
        {
            cdw_gradeLetter = "F";
        }
        return cdw_gradeLetter;
    }
    
    static string cdw_checkPass(float cdw_gradePercentage)
    {
        string cdw_pass = "Fail";
        if (cdw_gradePercentage > 70)
        {
            cdw_pass = "Pass";
        }
        return cdw_pass;
    }

    static float toFloat(string Prompt)
    {
        float returnValue = 0;
        bool wac_flag = true;
        while (wac_flag)
        {
            try
            {
                Console.WriteLine(Prompt);
                string wacUserInputStr = Console.ReadLine();
                returnValue = float.Parse(wacUserInputStr);
                wac_flag = false;
            } catch (Exception e)
            {
                Console.WriteLine($"Value is not acceptable, please enter a valid number. {e}");
            }
        }
        return returnValue;
    }
}