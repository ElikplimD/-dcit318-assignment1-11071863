
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        Console.Write("Side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        string triangleType = TriangleTypeIdentifier.GetTriangleType(side1, side2, side3);
        Console.WriteLine($"Triangle type: {triangleType}");
    }
}