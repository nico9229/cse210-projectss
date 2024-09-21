using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random ();
        int number = randomGenerator.Next (1, 101);
        int guess = 0;

        while (guess != number)
        {
            Console.Write("guess the number between 1 and 10: ");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            
            if (guess > number)
            {
                Console.WriteLine(" Cool ! ");
            }
            else if  (guess < number)
            {
                Console.WriteLine("Hot !");
            }
            else 
            {
                Console.WriteLine($"You guessed it!, the number is {number}");
            }
        }
    }
}