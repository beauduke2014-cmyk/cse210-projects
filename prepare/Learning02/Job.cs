public class Job
{
    public string _JobTitle;
    public string _Company;
    public int _startYear;
    public int _endYear;
    public void Display()
    {
        Console.WriteLine($"{_JobTitle} ({_Company}) {_startYear}-{_endYear}");
    }
}