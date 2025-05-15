using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        
        DisplayWelcome();
        
        string Name = PromptUserName ();
        int Number = PromptUserNumber();

        int square = SquareNumber (Number);

        DisplayResult(Name, Number);

    }
     static void DisplayWelcome ()
     {
        Console.WriteLine("Welcome to the Program");
     }

    static string PromptUserName ( )
    {
        Console.WriteLine ("What is your name? ");
        string Name = Console.ReadLine ();
        return Name;
    }

    static int PromptUserNumber ()
    {
        Console.WriteLine("What is your favorite Number ?");
        string Numb = Console.ReadLine ();
        int Number = int.Parse(Numb);


        return Number;
    }

    static int SquareNumber (int number)
        {
            int square= number * number;

            return square;

    }
           
    static void DisplayResult (string Name, int square)
    {
        Console.WriteLine($"Brother {Name}, the square of your number is {square}");

     }
    
    
}