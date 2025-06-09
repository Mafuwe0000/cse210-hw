using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        while (true)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu");
            string answer = Console.ReadLine();
            int resposta = int.Parse(answer);


            if (resposta == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();

            }
            else if (resposta == 2)
            {
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.Run();
            }
            else if (resposta == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (resposta == 4)
            {
                Console.WriteLine("Thank you");
                break;

            }
            else
            {
                Console.Write("Please select a different option");
            }
        }
    }
}