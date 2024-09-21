using System;

class Program
{
    static void Main(string[] arg)
    {

        Console.Write("Please enter the percentage of your grade: ");
        string percentaje = Console.ReadLine();
        double per = double.Parse(percentaje);
        string letter = "";
        string sign = "";


        


        if ( per >= 97)
        {
            letter = "A";
            sign = "+";
            
        }
        else if ( per >= 94)
        {
            letter = "A";
            
        }
        else if ( per >= 90)
        {
            letter = "A";
            sign = "-";
            
        }
        else if (per >= 87 )
        {
            letter = "B";
            sign = "+";
        }
        else if (per >= 84 )
        {
            letter = "B";
        }
        else if (per >= 80 )
        {
            letter = "B";
            sign = "-";
        }
        else if (per >= 77 )
        {
            letter = "C";
            sign = "+";
        }
        else if (per >= 74 )
        {
            letter = "C";
        }
        else if (per >= 73 )
        {
            letter = "C";
            sign = "-";
        }
        else if (per >= 67 )
        {
            letter = "D";
            sign = "+";
        }
        else if (per >= 64 )
        {
            letter = "D";
        }
        else if (per >= 63 )
        {
            letter = "D";
            sign = "-";
        }
        else
        {
            letter = "F";
        }                        
        Console.WriteLine($"{letter}{sign} {per}");
    } 
}