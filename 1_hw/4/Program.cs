using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a >= 0 && b >= 0);
        }
    }