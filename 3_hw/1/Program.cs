using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter your text:");

            string str = Console.ReadLine();
            int a = 0,
                b = 0,
                c = 0,
                d = 0;

            foreach (int letter in str)
            {
                if (letter == 'a')
                {
                    a++;
                }
                else if (letter == 'o')
                {
                    b++;
                }
                else if (letter == 'i')
                {
                    c++;
                }
                else if (letter == 'e')
                {
                    d++;
                }
            }

            Console.WriteLine($"Letter 'a' is used in the text {a} times \nLetter 'o' is used in the text {b} times \nLetter 'i' is used in the text {c} times \nLetter 'e' is used in the text {d} times");

        }
    }