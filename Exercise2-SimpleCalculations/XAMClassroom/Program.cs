using System;

namespace XAMClassroom
{
	class Program
	{
		static void Main(string[] args)
		{
			var h = double.Parse(Console.ReadLine());
			var w = double.Parse(Console.ReadLine());
			var hSeats = Math.Truncate(h / 1.2);
			var wSeats = Math.Truncate((w - 1) / 0.7);
			Console.WriteLine((hSeats * wSeats) - 3);
		}
	}
}