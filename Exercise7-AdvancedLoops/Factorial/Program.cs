using System;

namespace Factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var f = 1;
			do
			{
				f *= n;
				n--;
			}
			while (n > 1);
			Console.WriteLine(f);
		}
	}
}