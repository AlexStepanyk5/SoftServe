using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of the month(1-12): ");
            int Month = int.Parse(Console.ReadLine());
            string[] month = { "31", "28", "31", "30", "31", "30", "31", "31", "30", "31", "30", "31" };

            while (Month > 12 || Month < 1)
            {
                Console.Write("Input the correct number of month(1-12): ");
                Month = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"You inputed {Month} it`s {month[Month - 1]} days long");

        }
    }