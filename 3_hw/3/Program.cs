using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int result = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Please input {i + 1} number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            if (numbers[0] > 0 && numbers[1] > 0 && numbers[2] > 0 && 
                numbers[3] > 0 && numbers[4] > 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    result += numbers[i];
                }
                result--;
                Console.WriteLine($"First five numbers are positive and their sum is: {result}");
            }
            else
            {
                for (int i = 5; i < 10; i++)
                {
                    result *= numbers[i];
                }
                Console.WriteLine($"First five numbers aren`t positive and the product of 5 last elements is: {result}");
            }

        }
    }