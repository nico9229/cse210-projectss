using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
        
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the programing class !!!");
    }

     static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int SquareNumber(int bas)
    {
        int exp = 2;
        double Total = Math.Pow(bas, exp);
        int Total2 = (int)Total;
        Console.WriteLine($"The square of {bas} is: {Total2} ");
        return Total2;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}