using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name? ");
        string firstname =Console.Readline();
        Console.Write("What is your last name? ");
        string lastname = Console.Readline();
        Console.WriteLine($"Your name is {lastname} ,{firstname} {lastname} .");
    }
}