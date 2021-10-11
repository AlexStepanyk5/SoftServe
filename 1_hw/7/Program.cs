using System;

public class Program
{
    public static void Main()
    {
        double r, a, b, c;
        Console.WriteLine("Enter the radius of the circle:");
        r = Convert.ToDouble(Console.ReadLine());
        a = 2 * r * 3.14;
        b = r * r * 3.14;
        c = 4 / 3 * 3.14 * r * r * r;
        Console.WriteLine("The lenght is: " + a);
        Console.WriteLine("The area is: " + b);
        Console.WriteLine("The volume is: " + c);
    }
}