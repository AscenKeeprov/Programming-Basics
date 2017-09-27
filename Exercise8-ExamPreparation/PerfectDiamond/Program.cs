using System;

namespace PerfectDiamond
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				Console.Write(new string(' ', (n - i - 1)));
				Console.Write("*");
				for (int j = 0; j < i; j++) Console.Write("_*");
				Console.WriteLine(new string(' ', (n - i - 1)));
			}
			for (int i = n - 1; i > 0; i--)
			{
				Console.Write(new string(' ', (n - i)));
				Console.Write("*");
				for (int j = i - 1; j > 0; j--) Console.Write("_*");
				Console.WriteLine(new string(' ', (n - i)));
			}
		}
	}
}