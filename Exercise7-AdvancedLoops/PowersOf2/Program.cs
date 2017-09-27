using System;

namespace PowersOf2
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			for (int i = 0; i <= n; i++) Console.WriteLine(Math.Pow(2,i));
		}
	}
}