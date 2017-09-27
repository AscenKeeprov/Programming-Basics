using System;

namespace TriangleArea
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = double.Parse(Console.ReadLine());
			var h = double.Parse(Console.ReadLine());
			Console.WriteLine("Triangle area = " + Math.Round(a * h / 2, 2));
		}
	}
}