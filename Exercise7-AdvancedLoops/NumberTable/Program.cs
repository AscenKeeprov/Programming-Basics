using System;

namespace NumberTable
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			for (int row = 1; row <= n; row++)
			{
				for (int colL = row; colL < n; colL++)
				{
					if (n == 1) Console.Write(colL);
					else Console.Write(colL + " ");
				}
				for (int colR = n; colR > n - row; colR--)
				{
					if (colR < n) Console.Write(" ");
					Console.Write(colR);
				}
				Console.WriteLine();
			}
		}
	}
}