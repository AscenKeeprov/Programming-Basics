using System;

namespace Cup
{
	class Program
	{
		static void Main(string[] args)
		{
			var N = int.Parse(Console.ReadLine());
			//n / 2 + 1
			for (int t1 = 0; t1 < N / 2; t1++)
			{
				Console.Write(new string('.', N + t1));
				if (N % 2 ==0) Console.Write(new string('#', (3 * N) - (2 * t1)));
				else Console.Write(new string('#', (3 * N) - (2 * t1) - 1));
				Console.WriteLine(new string('.', N + t1));
			}
			for (int t2 = 0; t2 < (N / 2) + 1; t2++)
			{
				Console.Write(new string('.', (3 * N) / 2 + t2));
				Console.Write("#");
				Console.Write(new string('.', (2 * N) - (2 * t2) - 2));
				Console.Write("#");
				Console.WriteLine(new string('.', (3 * N) / 2 + t2));
			}
			Console.Write(new string('.', 2 * N));
			if (N % 2 == 0) Console.Write(new string('#', N));
			else Console.Write(new string('#', N - 1));
			Console.WriteLine(new string('.', 2 * N));
			for (int b1 = 0; b1 < N / 2; b1++)
			{
				Console.Write(new string('.', 2 * N - 2));
				if (N % 2 == 0) Console.Write(new string('#', N + 4));
				else Console.Write(new string('#', N + 3));
				Console.WriteLine(new string('.', 2 * N - 2));
			}
			Console.Write(new string('.', (5 * N - 10) / 2));
			Console.Write("D^A^N^C^E^");
			Console.WriteLine(new string('.', (5 * N - 10) / 2));
			for (int b2 = 0; b2 < (N / 2) + 1; b2++)
			{
				Console.Write(new string('.', 2 * N - 2));
				if (N % 2 == 0) Console.Write(new string('#', N + 4));
				else Console.Write(new string('#', N + 3));
				Console.WriteLine(new string('.', 2 * N - 2));
			}
		}
	}
}