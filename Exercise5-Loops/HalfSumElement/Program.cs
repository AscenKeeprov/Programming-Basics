using System;

namespace HalfSumElement
{
	class Program
	{
		static void Main(string[] args)
		{
			var nSum = 0;
			var n = int.Parse(Console.ReadLine());
			var num0 = int.Parse(Console.ReadLine());
			nSum += num0;
			var nMax = num0;
			for (int i = 1; i <= n-1; i++)
			{
				var numN = int.Parse(Console.ReadLine());
				nSum += numN;
				if (numN > nMax) nMax = numN;
			}
			if (nSum - nMax == nMax)
			{
				Console.WriteLine("Yes, sum = " + nMax);
			}
			else
			{
				Console.WriteLine("No, diff = " + Math.Abs(nMax - (nSum - nMax)));
			}
		}
	}
}