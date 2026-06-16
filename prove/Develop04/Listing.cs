using System;
/*
    Name: Carter Weber
    Class: CSE-210
    Description: Listing class for the mindfulness activity of a listing exercise.

    Sources: 
        1. https://byui-cse.github.io/cse210-course-2023
*/
public class Listing : Activity
{
    private List<string> _cdw_prompts = new List<string>();

    public void setPrompts(List<string> cdw_prompts)
    {
        _cdw_prompts = cdw_prompts;
    }

    public string getRandomPrompt()
    {
        Random cdw_random = new Random();
        int cdw_randomIndex = cdw_random.Next(_cdw_prompts.Count);
        string cdw_randomPrompt = _cdw_prompts[cdw_randomIndex];
        return cdw_randomPrompt;
    }
}