using System;

namespace XAMCoins
{
	class Program
	{
		static void Main(string[] args)
		{
			var bitcoins = int.Parse(Console.ReadLine());
			var yuans = double.Parse(Console.ReadLine());
			var commission = double.Parse(Console.ReadLine());
			var euros = (bitcoins * 1168.00 / 1.95) + (yuans * 0.15 * 1.76 / 1.95);
			Console.WriteLine("{0:F2}", euros - (euros * commission * 0.01));
		}
	}
}