using System;

namespace CelsiusToFahrenheit
{
	class Program
	{
		static void Main(string[] args)
		{
			var oC = double.Parse(Console.ReadLine());
			var oF = oC * 1.8 + 32;
			Console.WriteLine(Math.Round(oF, 2));
		}
	}
}