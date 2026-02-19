using System.Runtime.CompilerServices;
using System.Security.Principal;

Pentagon p1 = new Pentagon();
Console.WriteLine("\nPentagon p1");
p1.Display();

Pentagon p2 = new Pentagon(5);
Console.WriteLine("\nPentagon p2");
p2.Display();

Console.WriteLine("\nPress Enter to exit...");
Console.ReadLine();

class Pentagon
{
    private double side;

    public Pentagon()
    {
        side = 0;
    }
    public Pentagon(double side)
    {
        this.side = side;
    }

    double GetPerimeter()
    {
        return 5 * side;
    }

    double GetArea()
    {
        double numerator = Math.Sqrt(5*(5+(2*Math.Sqrt(5)))*(side*side));
        return numerator / 4;
    }

    public void Display()
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Side length: {0}", side);
        Console.WriteLine("Perimeter: {0:F3}", GetPerimeter());
        Console.WriteLine("Area: {0:F3}", GetArea());
    }
}
