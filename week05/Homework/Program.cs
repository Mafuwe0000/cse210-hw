using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("samuel Bennet","Multiplication");
        

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodrigues","Fractions","Section 7.3","Problems 8-19");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment12 = new WritingAssignment("Mary Waters"," European History","The causes of world war II");
        Console.WriteLine(writingAssignment12.GetSummary());
        Console.WriteLine(writingAssignment12.GetWritingInformation());
    }
}