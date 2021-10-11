using System;
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter a:");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The area of the squeare is: " + a * a);
		Console.WriteLine("The perimeter of the squeare is: " + 4 * a);
	}
}