using System;
using System.Dynamic;
/*
    Name: Carter Weber
    Class: CSE-210
    Description: Reflection class for the mindfulness activity of a reflection exercise.

    Sources: 
        1. https://byui-cse.github.io/cse210-course-2023
*/
public class Reflection : Activity
{
    private List<string> _cdw_prompts = new List<string>();

    private List<string> _cdw_questions = new List<string>();

    public void setReflection(List<string> cdw_prompts, List<string> cdw_questions)
    {
        _cdw_prompts = cdw_prompts;
        _cdw_questions = cdw_questions;
    }

    public string getRandomPrompt()
    {
        Random cdw_random = new Random();
        int cdw_randomIndex = cdw_random.Next(_cdw_prompts.Count);
        string cdw_randomPrompt = _cdw_prompts[cdw_randomIndex];
        return cdw_randomPrompt;
    }

    public string getRandomQuestion()
    {
        Random cdw_random = new Random();
        int cdw_randomIndex = cdw_random.Next(_cdw_questions.Count);
        string cdw_randomQuestion = _cdw_questions[cdw_randomIndex];
        return cdw_randomQuestion;
    }
    
}