﻿using System;

namespace PersonalTitles
{
	class Program
	{
		static void Main(string[] args)
		{
			var age = double.Parse(Console.ReadLine());
			var gender = Console.ReadLine();
			if (age >= 16)
			{
				if (gender == "m")
				{
					Console.WriteLine("Mr.");
				}
				else if (gender == "f")
				{
					Console.WriteLine("Ms.");
				}
			}
			else
			{
				if (gender == "m")
				{
					Console.WriteLine("Master");
				}
				else if (gender == "f")
				{
					Console.WriteLine("Miss");
				}
			}
		}
	}
}