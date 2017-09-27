using System;

namespace XAMVeggieMarket
{
	class Program
	{
		static void Main(string[] args)
		{
			var vPrice = double.Parse(Console.ReadLine());
			var fPrice = double.Parse(Console.ReadLine());
			var vWeight = int.Parse(Console.ReadLine());
			var fWeight = int.Parse(Console.ReadLine());
			var incomeBGN = (vPrice * (double)vWeight) + (fPrice * (double)fWeight);
			var incomeEUR = incomeBGN / 1.94;
			Console.WriteLine("{0:F2}", incomeEUR);
		}
	}
}