using System;

namespace SumNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var sum = 0;
			var n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				sum += int.Parse(Console.ReadLine());
			}
			Console.WriteLine(sum);
		}
	}
}