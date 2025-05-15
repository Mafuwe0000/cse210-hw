using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your Grade Percentage: ");
        string gradePercent = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercent);

        string letter =" ";

        if (gradePercentage >=90)
        {
            letter = "A" ;
        }

        else if (gradePercentage<90 && gradePercentage>=80)
        {
            letter = "B" ;
        }

        else if (gradePercentage<80 && gradePercentage>=70)
        {
            letter = "C" ;
        }

        else if (gradePercentage<70 && gradePercentage>=60)
        {
            letter = "D" ;
        }

        else
        {
            letter = "F" ;
        }

        Console.WriteLine($"Your grade is :{letter}");

        if (gradePercentage>=70)
        {
            Console.WriteLine("Congratulations, you've passed the class.");
           
        }

        else
        {
            Console.WriteLine("I'm so sorry. You'll try again next time.");
            
        }
      
    }
}