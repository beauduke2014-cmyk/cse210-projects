using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        List<int> cdw_Numbers = new List<int>();
        int cdw_NumberInput = 1;
        do
        {
            cdw_NumberInput = cdw_GetNumberInput("What number would you like to enter? (enter a 0 to end)");
            if (cdw_NumberInput != 0)
            {
                cdw_Numbers.Add(cdw_NumberInput);
            }
        } while(cdw_NumberInput != 0 );
        int cdw_Sum = cdw_GetSum(cdw_Numbers);
        float cdw_Average = cdw_GetAverage(cdw_Sum, cdw_Numbers);
        int cdw_Largest = cdw_GetLargest(cdw_Numbers);
        Console.WriteLine($"The sum is: {cdw_Sum}");
        Console.WriteLine($"The average is: {cdw_Average}");
        Console.WriteLine($"The largest number is: {cdw_Largest}");
    }

    static int cdw_GetNumberInput(string Prompt)
    {
        int cdw_NumberInput = toInt(Prompt);
        return cdw_NumberInput;

    }
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

    static int cdw_GetSum(List<int> cdw_Numbers)
    {
        int cdw_Sum = 0;
        foreach (int cdw_Number in cdw_Numbers)
        {
            cdw_Sum += cdw_Number;
        }
        return cdw_Sum;
    }

    static float cdw_GetAverage(int cdw_Sum, List<int> cdw_Numbers)
    {
        float cdw_Average = 0;
        cdw_Average = (float)cdw_Sum/cdw_Numbers.Count;
        return cdw_Average;
    }

    static int cdw_GetLargest(List<int> cdw_Numbers)
    {
        int cdw_Largest = 0;
        foreach(int number in cdw_Numbers)
        {
            if(number > cdw_Largest)
            {
                cdw_Largest = number;
            }
        }
        return cdw_Largest;
    }
}