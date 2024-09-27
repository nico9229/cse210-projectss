using System; 

public class Resume
{
    public string _Name;
    public List<Job>_jobss;

    public Resume (string name)
    {
        _Name = name;
        _jobss = new List<Job>();
    }

    public void Display()
    {
        Console.WriteLine("Nombre: "+_Name);
        foreach (Job job in _jobss)
        {
            job.DisplayJobDetails();
        }
    }


}