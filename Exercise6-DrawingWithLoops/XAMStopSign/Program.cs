using System;

namespace XAMStopSign
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			Console.Write(new string('.', n + 1));
			Console.Write(new string('_', 2 * n + 1));
			Console.WriteLine(new string('.', n + 1));
			for (int t = 0; t < n; t++)
			{
				Console.Write(new string('.', n - t));
				Console.Write("//");
				Console.Write(new string('_', 2 * n + 2 * t - 1));
				Console.Write("\\\\");
				Console.WriteLine(new string('.', n - t));
			}
			Console.Write("//");
			Console.Write(new string('_', 2 * n - 3));
			Console.Write("STOP!");
			Console.Write(new string('_', 2 * n - 3));
			Console.WriteLine("\\\\");
			for (int b = n; b >= 1; b--)
			{
				Console.Write(new string('.', n - b));
				Console.Write("\\\\");
				Console.Write(new string('_', 2 * n + 2 * b - 1));
				Console.Write("//");
				Console.WriteLine(new string('.', n - b));
			}
		}
	}
}