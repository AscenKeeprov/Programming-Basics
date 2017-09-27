using System;

namespace DanceHall
{
	class Program
	{
		static void Main(string[] args)
		{
			var L = double.Parse(Console.ReadLine());
			var W = double.Parse(Console.ReadLine());
			var A = double.Parse(Console.ReadLine());
			var HallArea = L * 100 * W * 100;
			var FreeArea = (HallArea - (A * 100 * A * 100) - (HallArea / 10)) / 7040;
			Console.WriteLine(Math.Truncate(FreeArea));
		}
	}
}