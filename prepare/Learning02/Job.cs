using System;

public class Job
{
    public string _jobTitle;
    public string _Company; 

    public string _Cinse;

    public Job (string jobTitle, string company, string cinse)
    {
        _jobTitle = jobTitle;
        _Company = company;
        _Cinse = cinse;
    }

    public void DisplayJobDetails ()
    {
      Console.WriteLine("Job Title: " + _jobTitle);
      Console.WriteLine("Company: "+ _Company + "  Cinse: "+ _Cinse);
    }

}