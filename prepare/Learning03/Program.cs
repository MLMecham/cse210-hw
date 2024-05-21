using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new();

        Fraction fraction2 = new(9);

        Fraction fraction3 = new(5,10);

        double  numberDouble = fraction1.GetDecimalValue();
        string numberString = fraction1.GetFractionString();
        Console.WriteLine(numberString);
        Console.WriteLine(numberDouble);

        numberDouble = fraction2.GetDecimalValue();
        numberString = fraction2.GetFractionString();
        Console.WriteLine(numberString);
        Console.WriteLine(numberDouble);

        numberDouble = fraction3.GetDecimalValue();
        numberString = fraction3.GetFractionString();
        Console.WriteLine(numberString);
        Console.WriteLine(numberDouble);

        fraction1.SetTop(100);
        fraction1.SetBottom(1000);

        int top = fraction1.GetTop();
        int bottom = fraction1.GetBottom();
        Console.WriteLine(top);
        Console.WriteLine(bottom);
        numberDouble = fraction1.GetDecimalValue();
        numberString = fraction1.GetFractionString();
        Console.WriteLine(numberString);
        Console.WriteLine(numberDouble);
    }
}