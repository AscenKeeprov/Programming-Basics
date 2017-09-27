using System;

namespace XAMTransportFee
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			string time = Console.ReadLine().ToLower();
			var minFee = 0.00;
			if (n >= 1 && n < 20)
			{
				if (time == "day") minFee = 0.7 + (n * 0.79);
				else if (time == "night") minFee = 0.7 + (n * 0.9);
			}
			else if (n >= 20 && n < 100) minFee = n * 0.09;
			else if (n >= 100) minFee = n * 0.06;
			Console.WriteLine("{0:F2}", minFee);
		}
	}
}