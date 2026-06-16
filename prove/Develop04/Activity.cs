using System;
/*
    Name: Carter Weber
    Class: CSE-210
    Description: Parent class for the mindfulness activities.

    Sources: 
        1. https://byui-cse.github.io/cse210-course-2023
*/
public class Activity
{
    private string _cdw_name;
    private int _cdw_time;
    private string _cdw_description;

    public void setActivity(string cdw_name, int cdw_time, string cdw_description)
    {
        _cdw_name = cdw_name;
        _cdw_time = cdw_time;
        _cdw_description = cdw_description;
    }
    public string getStartMessage()
    {
        string cdw_startMessage = "Welcome to the " + _cdw_name + "Activity.\n\n" + _cdw_description + "\n\nHow long, in seconds, would you like for your session? "; 
        return cdw_startMessage;
    }
    public void setTime(int cdw_time)
    {
        _cdw_time = cdw_time;
    }

    public int getTime()
    {
        return _cdw_time;
    }

    public string getEndMessage()
    {
        string cdw_endMessage = "Well done! \n\nYou have completed another " + _cdw_time + " seconds of " + _cdw_name + ".";
        return cdw_endMessage;
    }

    public DateTime startActivity()
    {
        DateTime cdw_startTime = DateTime.Now;
        DateTime cdw_endTime = cdw_startTime.AddSeconds(_cdw_time);
        return cdw_endTime;
    }
}