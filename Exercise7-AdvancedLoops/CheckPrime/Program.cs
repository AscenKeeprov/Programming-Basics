﻿using System;

namespace CheckPrime
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var prime = true;
			if (n < 2) prime = false;
			else
			{
				for (int i = 2; i < n; i++)
				{
					if (n % i == 0)
					{
						prime = false;
						break;
					}
				}
			}
			if (prime) Console.WriteLine("Prime");
			else Console.WriteLine("Not Prime");
		}
	}
}