using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numb = new List<int>();

        int number;

        do 
        {
            Console.WriteLine("Enter the number or end with 0: ");
            number = int.Parse (  Console.ReadLine() );

            if (number != 0)
            {
                numb.Add(number);
            }
        } while (number != 0 );
        Console.WriteLine("Number in the list: ");
        foreach (int num in numb)
        
        {
            Console.WriteLine(num);
           
        }
        int sum = 0;

        foreach (int num in numb)
        {
            sum += num;
            
        }
        if (numb.Count > 0)
        {
            
        
        double average = (double) sum / numb.Count;
        int max = numb.Max();
        Console.WriteLine($"you have {numb.Count} numbers in your list");
        Console.WriteLine ($"the sum of the all number is: {sum}");
        Console.WriteLine ($"the average is {average}");
        Console.WriteLine ($"the largestnumber is  {max}");
        }
    }   
}