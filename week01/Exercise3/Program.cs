using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        int guess =-2;
        Random randomGenerator = new Random ();
        int number = randomGenerator.Next (1,101);

        while (guess != number)
        {
            Console.Write("What is your Guess? ");
            string gue = Console.ReadLine();
            guess = int.Parse(gue);

            
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }
        
        
    }
}
