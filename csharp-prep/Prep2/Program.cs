using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string gradePercent = Console.ReadLine();
        int Percent = int.Parse(gradePercent);

        string letter ="";
        if (Percent >= 90)
        {
            letter ="A";
        }
        else if (Percent>=80)
        {
            letter = "B";
        }
        else if (Percent>=70)
        {
            letter = "C";
        }
        else if (Percent>=60)
        {
            letter = "D";
        }
        else
        {
            letter ="F";
        }
        Console.WriteLine($"Your grade percentage is : {letter}");
            
        if(Percent>=70)
        {
            Console.WriteLine(" Congratulations you passed");
        }
        else
        {
            Console.WriteLine("Please try again next term ");
        }

    }
}