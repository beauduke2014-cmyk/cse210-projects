using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reflection cdw_reflectionActivity = new Reflection();
        Listing cdw_listingActivity = new Listing();
        bool cdw_menuFlag = false;
        while(cdw_menuFlag != true)
        {
            int cdw_menuResponse = toInt("Mindfulness Program\nMenu Options:\n\t1. Start Breathing Activity\n\t2. Start Reflecting Activity\n\t3. Start Listing Activity\n\t4. Quit\nSelect a choice from the menu: ");

            if (cdw_menuResponse == 1)
            {
                Breathing cdw_breathingActivity = new Breathing();
                cdw_breathingActivity.setActivity("Breathing", 0, "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine(cdw_breathingActivity.getStartMessage());

            }

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