using System;

public class Program
{
	public static void Main()
	{
		int a, b;
		Console.WriteLine("Enter a:");
		a = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter b:");
		b = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("a+b=" + (a + b));
		Console.WriteLine("a-b=" + (a - b));
		Console.WriteLine("a*b=" + (a * b));
		Console.WriteLine("a/b=" + (a / b));
	}
}