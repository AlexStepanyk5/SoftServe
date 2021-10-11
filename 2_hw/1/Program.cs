using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first variable:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second variable:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third variable:");
            float c = float.Parse(Console.ReadLine());

            string a1 = (-5 <= a && a <= 5) ? $"a = {a} and a in range [-5, 5]" : $"a = {a} and a does not belong to the range [-5, 5]";
            string b1 = (-5 <= b && b <= 5) ? $"b = {b} and b in range [-5, 5]" : $"b = {b} and b does not belong to the range [-5, 5]";
            string c1 = (-5 <= c && c <= 5) ? $"c = {c} and c in range [-5, 5]" : $"c = {c} and c does not belong to the range [-5, 5]";

            Console.WriteLine($"{a1} \n{b1} \n{c1}");
        }
    }