using System;

namespace Volleyball
{
	class Program
	{
		static void Main(string[] args)
		{
			string year = Console.ReadLine().ToLower();
			var p = int.Parse(Console.ReadLine());
			var h = int.Parse(Console.ReadLine());
			if (year == "leap")
			{
				Console.WriteLine(Math.Truncate(((48 - h) * 0.75 + (p * 2.0 / 3) + h) * 1.15));
			}
			else if (year == "normal")
			{
				Console.WriteLine(Math.Truncate((48 - h) * 0.75 + (p * 2.0 / 3) + h));
			}
		}
	}
}