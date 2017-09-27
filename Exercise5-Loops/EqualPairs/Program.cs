using System;

namespace EqualPairs
{
	class Program
	{
		static void Main(string[] args)
		{
			var pSumOld = -1;
			var pSumNew = -1;
			var diff = 0;
			var maxDiff = 0;
			var n = int.Parse(Console.ReadLine());
			var pNum1 = int.Parse(Console.ReadLine());
			var pNum2 = int.Parse(Console.ReadLine());
			pSumOld = pNum1 + pNum2;
			for (int i = 1; i <= n-1; i++)
			{
				var pNum3 = int.Parse(Console.ReadLine());
				var pNum4 = int.Parse(Console.ReadLine());
				pSumNew = pNum3 + pNum4;
				if (pSumOld != pSumNew)
				{
					diff = Math.Abs(pSumNew - pSumOld);
					if (diff > maxDiff) maxDiff = diff;
				}
				pSumOld = pSumNew;
			}
			if (maxDiff == 0) Console.WriteLine("Yes, value = " + pSumOld);
			else Console.WriteLine("No, maxdiff = " + maxDiff);
		}
	}
}