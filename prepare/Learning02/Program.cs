using System;

class Program
{
    static void Main(string[] args)
    {
        Job cdw_job1 = new Job();
        cdw_job1._JobTitle = "Software Engineer";
        cdw_job1._Company = "Microsoft";
        cdw_job1._startYear = "2019";
        cdw_job1._endYear = "2022";
        Job cdw_job2 = new Job();
        cdw_job2._JobTitle = "Manager";
        cdw_job2._Company = "Apple";
        cdw_job2._startYear = "2022";
        cdw_job2._endYear = "2023";
        Resume cdw_resume1 = new Resume();
        cdw_resume1._name = "Allison Rose";
        cdw_resume1._jobs.Add(cdw_job1);
        cdw_resume1._jobs.Add(cdw_job2);
        Console.WriteLine(cdw_resume1);
    }
}