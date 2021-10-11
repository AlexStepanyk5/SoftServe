using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter the first variable:");
		char a = Convert.ToChar(Console.ReadLine());
		Console.WriteLine("Enter the second variable:");
		char b = Convert.ToChar(Console.ReadLine());
		Console.WriteLine("Enter the third variable:");
		char c = Convert.ToChar(Console.ReadLine());
		Console.WriteLine("You entered: " + a + ", " + b + ", " + c);
	}
}