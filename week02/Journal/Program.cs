using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        
        
        
        Console.WriteLine("Welcome to the the Journal Program.");

        
        int resposta;


        Journal journal1 = new Journal();
        
        PromptGenerator promptGenerator = new PromptGenerator();
      
        
        do
        {
            Console.WriteLine("Please Select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do:  ");
            string answer = Console.ReadLine();
            if (!int.TryParse(answer, out resposta))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                resposta = -1;
                continue;
            }


            if (resposta == 1)
            {

                journal1.AddEntry();


            }
            else if (resposta == 2)
            {
                journal1.DisplayAll();

            }
            else if (resposta == 3)
            {
                Console.WriteLine("What is the filename");
                string filename = Console.ReadLine();

                journal1.LoadFromFile(filename);

            }
            else if (resposta == 4)
            {
                Console.Write("saving your file");
                Console.WriteLine("Give a name to your file:");
                string filename = Console.ReadLine();
                journal1.SaveToFile(filename);
                Console.Write("saving your file");
            }
            else if (resposta == 5)
            {
                Console.WriteLine("See you next time");
            }
            else
            {
                Console.WriteLine("Please select a different option.");
            }
        } while (resposta != 5);
      
    }
}