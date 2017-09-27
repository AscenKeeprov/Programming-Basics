using System;

namespace OddEvenPosition
{
	class Program
	{
		static void Main(string[] args)
		{
			double eSum = 0.0;
			var eMin = double.PositiveInfinity;
			var eMax = double.NegativeInfinity;
			double oSum = 0.0;
			var oMin = double.PositiveInfinity;
			var oMax = double.NegativeInfinity;
			var n = double.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				var num = double.Parse(Console.ReadLine());
				if (i % 2 == 0)
				{
					eSum += num;
					if (num < eMin) eMin = num;
					if (num > eMax) eMax = num;
				}
				else
				{
					oSum += num;
					if (num < oMin) oMin = num;
					if (num > oMax) oMax = num;
				}
			}
			Console.WriteLine("OddSum=" + oSum);
			if (oMin == double.PositiveInfinity) Console.WriteLine("OddMin=No");
			else Console.WriteLine("OddMin=" + oMin);
			if (oMax == double.NegativeInfinity) Console.WriteLine("OddMax=No");
			else Console.WriteLine("OddMax=" + oMax);
			Console.WriteLine("EvenSum=" + eSum);
			if (eMin == double.PositiveInfinity) Console.WriteLine("EvenMin=No");
			else Console.WriteLine("EvenMin=" + eMin);
			if (eMax == double.NegativeInfinity) Console.WriteLine("EvenMax=No");
			else Console.WriteLine("EvenMax=" + eMax);
		}
	}
}