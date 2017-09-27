using System;

namespace XAMPoolPipes
{
	class Program
	{
		static void Main(string[] args)
		{
			var V = int.Parse(Console.ReadLine());
			var P1 = int.Parse(Console.ReadLine());
			var P2 = int.Parse(Console.ReadLine());
			var H = float.Parse(Console.ReadLine());
			var F1 = P1 * H;
			var F2 = P2 * H;
			var F = F1 + F2;
			if (F > V) Console.WriteLine("For {0:0.#} hours the pool overflows with {1:0.0} liters.", H, F - V);
			else
			{
				var C1 = Math.Truncate(F1 / F * 100);
				var C2 = Math.Truncate(F2 / F * 100);
				Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(F / V * 100), C1, C2);
			}
		}
	}
}