using System;

namespace BonusScore
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter score: ");
			var score = int.Parse(Console.ReadLine());
			var bonus = 0.0;
			if (0 <= score && score <= 100)
			{
				bonus += 5;
			}
			else if (100 < score && score <= 1000)
			{
				bonus = score * 0.2;
			}
			else if (score > 1000)
			{
				bonus = score * 0.1;
			}
			if (score % 2 == 0)
			{
				bonus += 1;
			}
			else if (score % 10 == 5)
			{
				bonus += 2;
			}
			Console.WriteLine("Bonus score: " + bonus);
			Console.WriteLine("Total score: " + (score + bonus));
		}
	}
}