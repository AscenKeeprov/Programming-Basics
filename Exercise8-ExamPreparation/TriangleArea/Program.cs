using System;

namespace TriangleArea
{
	class Program
	{
		static void Main(string[] args)
		{
			var x1 = int.Parse(Console.ReadLine());
			var y1 = int.Parse(Console.ReadLine());
			var x2 = int.Parse(Console.ReadLine());
			var y2 = int.Parse(Console.ReadLine());
			var x3 = int.Parse(Console.ReadLine());
			var y3 = int.Parse(Console.ReadLine());
			double area = Math.Abs(x2 - x3) * Math.Abs(y1 - y2) / 2.0;	// Делим на 2.0, за да не се truncate-не остатъка след десетичната запетая
			Console.WriteLine(area);
		}
	}
}