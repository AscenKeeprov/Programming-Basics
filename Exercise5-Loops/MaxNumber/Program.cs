using System;

namespace MaxNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var num0 = int.Parse(Console.ReadLine());
			var maxN = num0;
			for (int i = 1; i <= n-1; i++)
			{
				var numN = int.Parse(Console.ReadLine());
				if (numN > maxN)
				{
					maxN = numN;
				}
			}
			Console.WriteLine(maxN);
		}
	}
}