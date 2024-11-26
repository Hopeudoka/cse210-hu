using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction fraction1 = new Fraction();
        // Fraction fraction2 = new Fraction(6);
        // Fraction fraction3 = new Fraction(6, 7);
        // Fraction fraction4 = new Fraction();

        // fraction1.Display();
        // fraction2.Display();
        // fraction3.Display();

        // get original values
        // int top = fraction4.GetTop();
        // int bottom = fraction4.GetBottom();

        // Print the values
        // Console.WriteLine($"Top: {top}");      
        // Console.WriteLine($"Bottom: {bottom}"); 

        // set new values
        // fraction4.SetTop(10);
        // fraction4.SetBottom(20);

        // get new values
        // top = fraction4.GetTop();
        // bottom = fraction4.GetBottom();

        // Print the values
        // Console.WriteLine($"Top: {top}");      
        // Console.WriteLine($"Bottom: {bottom}");

        // Case 1: Whole number (1)
        Fraction fraction1 = new Fraction(1);
        Console.WriteLine($"Fraction: {fraction1.GetFractionString()}"); 
        Console.WriteLine($"Decimal: {fraction1.GetDecimalValue()}");   

        // Case 2: Whole number (5)
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"Fraction: {fraction2.GetFractionString()}"); 
        Console.WriteLine($"Decimal: {fraction2.GetDecimalValue()}");   

        // Case 3: Fraction (3/4)
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction: {fraction3.GetFractionString()}"); 
        Console.WriteLine($"Decimal: {fraction3.GetDecimalValue()}");   

        // Case 4: Fraction (1/3)
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine($"Fraction: {fraction4.GetFractionString()}"); 
        Console.WriteLine($"Decimal: {fraction4.GetDecimalValue()}");  
    }
}