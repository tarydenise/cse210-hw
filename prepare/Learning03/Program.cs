using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        f2.SetTop(1);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        f2.SetTop(5);
        f1.SetTop(5);

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        f3.SetTop(3);
        f3.SetBottom(4);

        int top = f3.GetTop();
        int bottom = f3.GetBottom();

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        f3.SetTop(1);
        f3.SetBottom(3);

        int top2 = f3.GetTop();
        int bottom2 = f3.GetBottom();

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}