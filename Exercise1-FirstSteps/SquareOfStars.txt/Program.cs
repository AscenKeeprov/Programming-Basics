﻿using System;

namespace SquareOfStars.txt
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			Console.WriteLine(new string('*', n));
			for (int i = 1; i <= n - 2; i++)
			{
				Console.WriteLine("*" + new string(' ', n - 2) + "*");
			}
			Console.WriteLine(new string('*', n));
		}
	}
}