using System;

namespace USDToBGN.txt
{
	class Program
	{
		static void Main(string[] args)
		{
			var USD = double.Parse(Console.ReadLine());
			var BGN = USD * 1.79549;
			Console.WriteLine("{0} BGN", Math.Round(BGN, 2));
		}
	}
}