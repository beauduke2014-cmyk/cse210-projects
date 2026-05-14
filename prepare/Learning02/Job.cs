public class Job
{
    public string _JobTitle;
    public string _Company;
    public string _startYear;
    public string _endYear;
    public string toString()
    {
        string rvalue = _JobTitle + "(" + _Company + ")" + _startYear + "-" +_endYear;
        return rvalue;
    }
}