using System;

namespace RectangleAreaAndPerimeter
{
	class Program
	{
		static void Main(string[] args)
		{
			var x1 = double.Parse(Console.ReadLine());
			var y1 = double.Parse(Console.ReadLine());
			var x2 = double.Parse(Console.ReadLine());
			var y2 = double.Parse(Console.ReadLine());
			Console.WriteLine("Area = " + Math.Abs(x1 - x2) * Math.Abs(y1 - y2));
			Console.WriteLine("Perimeter = " + 2 * (Math.Abs(x1 - x2) + Math.Abs(y1 - y2)));
		}
	}
}