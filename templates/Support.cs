


class Support
{
    static int GetUserInputInteger(string prompt)
    {
        int returnValue = 0;
        bool wac_flag = true;
        while (wac_flag)
        {
            try {
                Console.WriteLine(prompt);
                string wac_UserInputStr = Console.ReadLine();
                returnValue = int.Parse(wac_UserInputStr);
                wac_flag = false;
            } catch (Exception e) {
                Console.WriteLine("Value is not acceptable, expecting a whole number! Please try again");
            }
        }
        return returnValue;
    }

    static float GetUserInputFloat(string prompt)
    {
        float returnValue = 0;
        bool wac_flag = true;
        while (wac_flag)
        {
            try {
                Console.WriteLine(prompt);
                string wac_UserInputStr = Console.ReadLine();
                returnValue = float.Parse(wac_UserInputStr);
                wac_flag = false;
            } catch (Exception e) {
                Console.WriteLine("Value is not acceptable, expecting a decimal number! Please try again");
            }
        }
        return returnValue;
    }

    static string GetUserInputString(string prompt)
    {
        string returnValue = "";
        bool wac_flag = true;
        while (wac_flag)
        {
            try {
                Console.WriteLine(prompt);
                string wac_UserInputStr = Console.ReadLine();
                if ((wac_UserInputStr.Trim() == "" ) || (wac_UserInputStr.Length < 1  
                    || wac_UserInputStr.Length > 100)) {
                    throw new Exception();
                }
                wac_flag = false;
            } catch (Exception e) {
                Console.WriteLine("Value is not acceptable, expecting a decimal number! Please try again");
            }
        }
        return returnValue;
    }

    public static void Display(string s)
    {
        Console.WriteLine(s);
    }
}