using System;

namespace LeftAndRightSum
{
	class Program
	{
		static void Main(string[] args)
		{
			var Lsum = 0;
			var Rsum = 0;
			var n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				Lsum += int.Parse(Console.ReadLine());
			}
			for (int i = 1; i <= n; i++)
			{
				Rsum += int.Parse(Console.ReadLine());
			}
			if (Lsum - Rsum == 0)
			{
				Console.WriteLine("Yes, sum = " + Lsum);
			}
			else
			{
				Console.WriteLine("No, diff = " + Math.Abs(Lsum - Rsum));
			}
		}
	}
}