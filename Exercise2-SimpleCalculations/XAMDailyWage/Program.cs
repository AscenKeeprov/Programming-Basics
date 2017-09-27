using System;

namespace XAMDailyWage
{
	class Program
	{
		static void Main(string[] args)
		{
			var mDays = int.Parse(Console.ReadLine());
			var dWage = double.Parse(Console.ReadLine());
			var fxRate = double.Parse(Console.ReadLine());
			var mWage = mDays * dWage;
			var netWage = 14.5 * mWage * 0.75;
			Console.WriteLine("{0:F2}", netWage * fxRate / 365);
		}
	}
}