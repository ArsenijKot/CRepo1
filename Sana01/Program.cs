using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Enter values a, b, c, d:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());

        
        double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
        double y = 5 * (a + b) * (c - d) / (0.5 * c) + (d * d) * (a * a - b * b) / (b - a);
        double z = ((x * x - 2 * x) * (x * x - 2 * x) * (x * x - 2 * x) - 4 * (x * x * x * x + 1) * (1 - b)) / (5 * a + 3 * b);
        double r = (0.5 * a + (3.0 / 4.0) * b - 7.0 / 5.0) / (3 * c + 1) + 1 / (a - c);

        
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");
        Console.WriteLine($"z = {z}");
        Console.WriteLine($"r = {r}");
    }
}
