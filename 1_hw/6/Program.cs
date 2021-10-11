using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("How old are you, " + name + "?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(name + " you are " + age + " years old.");
    }
}