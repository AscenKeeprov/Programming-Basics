using System;

namespace XAMButterfly
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			Console.Write(new string('*', n - 3));
			Console.Write("*\\ /*");
			Console.WriteLine(new string('*', n - 3));
			for (int i = 1; i <= n - 3; i++)
			{
				if (i % 2 == 0)
				{
					Console.Write(new string('*', n - 3));
					Console.Write("*\\ /*");
					Console.WriteLine(new string('*', n - 3));
				}
				else
				{
					Console.Write(new string('-', n - 3));
					Console.Write("-\\ /-");
					Console.WriteLine(new string('-', n - 3));
				}
			}
			Console.Write(new string(' ', n - 1));
			Console.Write("@");
			Console.WriteLine(new string(' ', n - 1));
			for (int i = 1; i <= n - 3; i++)
			{
				if (i % 2 == 0)
				{
					if (n % 2 == 0)
					{
						Console.Write(new string('*', n - 3));
						Console.Write("*/ \\*");
						Console.WriteLine(new string('*', n - 3));
					}
					else
					{
						Console.Write(new string('-', n - 3));
						Console.Write("-/ \\-");
						Console.WriteLine(new string('-', n - 3));
					}
				}
				else
				{
					if (n % 2 == 0)
					{
						Console.Write(new string('-', n - 3));
						Console.Write("-/ \\-");
						Console.WriteLine(new string('-', n - 3));
					}
					else
					{
						Console.Write(new string('*', n - 3));
						Console.Write("*/ \\*");
						Console.WriteLine(new string('*', n - 3));
					}
				}
			}
			Console.Write(new string('*', n - 3));
			Console.Write("*/ \\*");
			Console.WriteLine(new string('*', n - 3));
		}
	}
}