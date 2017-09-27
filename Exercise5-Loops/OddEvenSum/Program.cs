using System;

namespace OddEvenSum
{
	class Program
	{
		static void Main(string[] args)
		{
			var oSum = 0;
			var eSum = 0;
			var n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				if (i % 2 == 0)
				{
					eSum += int.Parse(Console.ReadLine());
				}
				else
				{
					oSum += int.Parse(Console.ReadLine());
				}
			}
			if (oSum - eSum == 0)
			{
				Console.WriteLine("Yes, sum = " + oSum);
			}
			else
			{
				Console.WriteLine("No, diff = " + Math.Abs(oSum - eSum));
			}
		}
	}
}