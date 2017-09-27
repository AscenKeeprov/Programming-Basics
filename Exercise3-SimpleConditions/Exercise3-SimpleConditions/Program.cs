using System;

namespace ExcellentResult
{
	class Program
	{
		static void Main(string[] args)
		{
			var grade = double.Parse(Console.ReadLine());
			if (grade >= 5.50)
			{
				Console.WriteLine("Excellent!");
			}
		}
	}
}
