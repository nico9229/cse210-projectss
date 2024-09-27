using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job ("Software Engineer", "(Microsoft)", "2019 - 2022");
        Job job2 = new Job ("Manager", "(Apple)", "2022 - 2023");

        Resume myresume = new Resume ("Nicolas Ayala");

        myresume._jobss.Add(job1);
        myresume._jobss.Add(job2);
        
        myresume.Display();
    }
}   
