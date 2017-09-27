using System;

namespace Sum3Num
{
	class Program
	{
		static void Main(string[] args)
		{
			var n1 = int.Parse(Console.ReadLine());
			var n2 = int.Parse(Console.ReadLine());
			var n3 = int.Parse(Console.ReadLine());
			var nSum = n1 + n2 + n3;
			var nMin = Math.Min(Math.Min(n1, n2), n3);
			var nMax = Math.Max(Math.Max(n1, n2), n3);
			var nMid = nSum - nMin - nMax;
			if (nMin + nMid == nMax) Console.WriteLine("{0} + {1} = {2}", nMin, nMid, nMax);
			else Console.WriteLine("No");

			/*	Решение, работещо за положителни и отрицателни числа:
			if (n1 == (n2 + n3))
			{
				if (n2 <= n3) Console.WriteLine("{0} + {1} = {2}", n2, n3, n1);
				else Console.WriteLine("{0} + {1} = {2}", n3, n2, n1);
			}
			else if (n2 == (n1 + n3))
			{
				if (n1 <= n3) Console.WriteLine("{0} + {1} = {2}", n1, n3, n2);
				else Console.WriteLine("{0} + {1} = {2}", n3, n1, n2);
			}
			else if (n3 == (n1 + n2))
			{
				if (n1 <= n2) Console.WriteLine("{0} + {1} = {2}", n1, n2, n3);
				else Console.WriteLine("{0} + {1} = {2}", n2, n1, n3);
			}
			else Console.WriteLine("No");*/
		}
	}
}