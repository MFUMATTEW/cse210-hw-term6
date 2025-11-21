using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions operation = new Fractions();

        Console.WriteLine("First Fraction");
        operation.Fraction();
        Console.WriteLine(operation.GetFractionString());
        Console.WriteLine(operation.GetDecimalValue());

        Console.WriteLine("Second Fraction");
        operation.Fraction(5);
        Console.WriteLine(operation.GetFractionString());
        Console.WriteLine(operation.GetDecimalValue());

        Console.WriteLine("Third Fraction");
        operation.Fraction(3,4);
        Console.WriteLine(operation.GetFractionString());
        Console.WriteLine(operation.GetDecimalValue());

        Console.WriteLine("Fourth Fraction");
        operation.Fraction(1,3);
        Console.WriteLine(operation.GetFractionString());
        Console.WriteLine(operation.GetDecimalValue());
    }
}