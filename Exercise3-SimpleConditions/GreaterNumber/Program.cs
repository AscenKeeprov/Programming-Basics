using System;

namespace GreaterNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter two integers:");
			var int1 = int.Parse(Console.ReadLine());
			var int2 = int.Parse(Console.ReadLine());
			if (int1 > int2)
			{
				Console.WriteLine("Greater number: " + int1);
			}
			else
			{
				Console.WriteLine("Greater number: " + int2);
			}
		}
	}
}