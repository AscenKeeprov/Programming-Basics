﻿using System;

namespace TriangleOfDollars
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			for (int r = 1; r <= n; r++)
			{
				Console.Write("$");
				for (int c = 1; c < r; c++)
				{
					Console.Write(" $");
				}
				Console.WriteLine();
			}
		}
	}
}