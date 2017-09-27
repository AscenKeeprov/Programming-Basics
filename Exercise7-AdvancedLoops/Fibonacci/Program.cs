using System;

namespace Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			int f1 = 1;
			int f2 = 1;
			int ft = -1;
			if (n < 2) Console.WriteLine(1);
			else
			{
				for (int i = 1; i <= n; i++)
				{
					ft = f2;
					f2 = f1 + f2;
					f1 = ft;
				}
				Console.WriteLine(ft);
			}
		}
	}
}