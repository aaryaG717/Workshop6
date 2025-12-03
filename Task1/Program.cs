using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();

        rect.Length = 10;
        rect.Breadth = 5;

        Console.WriteLine("Area: " + rect.GetArea());
        Console.WriteLine("Perimeter: " + rect.GetPerimeter());
        Console.WriteLine(rect.SeeDetails());

        Console.ReadLine();
    }
}
