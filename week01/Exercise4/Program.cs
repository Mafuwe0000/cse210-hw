using System;

internal class NewBaseType
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        int number = -235695852;

        List<int> lNumber = new List<int>();
        do
        {
            Console.Write("Enter a number:  ");
            string numb = Console.ReadLine();
            number = int.Parse(numb);

            lNumber.Add(number);


        } while (number != 0);


        int sum = lNumber.Sum();
        Console.WriteLine($"the sum of all numbers i: {sum}");

        /*int sum = 0;
        foreach (int numeros in lNumber)
        {
            sum += numeros
        }*/


        int  averageNumber = sum/lNumber.Count();
        Console.WriteLine($"The average number is :{averageNumber}");

        int max = lNumber[0];

        foreach (int numbers in lNumber)
        {
            if (numbers > max)
            {
                Console.WriteLine($"The maximum number is: {max}");
            }

        }



    }
}
