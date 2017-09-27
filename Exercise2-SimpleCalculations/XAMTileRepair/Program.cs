using System;

namespace XAMTileRepair
{
	class Program
	{
		static void Main(string[] args)
		{
			var N = double.Parse(Console.ReadLine());
			var W = double.Parse(Console.ReadLine());
			var L = double.Parse(Console.ReadLine());
			var M = double.Parse(Console.ReadLine());
			var O = double.Parse(Console.ReadLine());
			var tiles = ((N * N) - (M * O)) / (W * L);
			var time = tiles * 0.2;
			Console.WriteLine("{0:F2}", tiles);
			Console.WriteLine("{0:F2}", time);
		}
	}
}