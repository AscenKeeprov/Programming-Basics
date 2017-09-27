using System;

namespace MinNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var num0 = int.Parse(Console.ReadLine());
			var minN = num0;
			for (int i = 1; i <= n-1; i++)
			{
				var numN = int.Parse(Console.ReadLine());
				if (numN < minN)
				{
					minN = numN;
				}
			}
			Console.WriteLine(minN);
		}
	}
}