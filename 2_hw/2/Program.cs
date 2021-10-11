using System;

    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Enter the first variable:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second variable:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third variable:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a belongs to [-5;5] - " + (-5 < a && a < 5 ? true : false));
            Console.WriteLine("c belongs to [-5;5] - " + (- 5 < b && b < 5 ? true : false));
            Console.WriteLine("c belongs to [-5;5] - " + (-5 < c && c < 5 ? true : false));
        }
    }