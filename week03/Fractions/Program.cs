using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");




        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6,7);
        Fraction fraction4 = new Fraction();

        Console.WriteLine(fraction1.GetBottomValue());
        Console.WriteLine(fraction2.GetBottomValue());
        Console.WriteLine(fraction3.GetBottomValue());

        fraction1.SetTopValue(1);
        fraction2.SetTopValue(5);
        fraction3.SetBottomValue(3);
        fraction3.SetTopValue(1);
        fraction4.SetTopValue(3);
        fraction4.SetBottomValue(4);

        /*Console.WriteLine(fraction1.GetTopValue());
        Console.WriteLine(fraction2.GetTopValue());
        Console.WriteLine(fraction3.GetBottomValue());*/

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        

    }
}