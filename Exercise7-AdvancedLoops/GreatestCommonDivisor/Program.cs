using System;

namespace GreatestCommonDivisor
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());
			while (b != 0)
			{
				var bOld = b;
				b = a % b;
				a = bOld;
			}
			Console.WriteLine(a);
		}
	}
}