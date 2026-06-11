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
        string cdw_startMessage = "Welcome to the " + _cdw_name + "Activity.\n\n" + _cdw_description + "\n\nHow long, in seconds, would you like for your session?"; 
        return cdw_startMessage;
    }
}