using Microsoft.Win32;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public string toString()
    {
        string rvalue = "";
        rvalue += "Name:" + _name + "\n";
        rvalue += "Jobs:\n";
        foreach(Job job in _jobs)
        {
            rvalue += job.toString() + "\n";
        }
        return rvalue;

    }
}