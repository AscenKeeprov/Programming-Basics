using System;

namespace Cinema
{
	class Program
	{
		static void Main(string[] args)
		{
			string type = Console.ReadLine().ToLower();
			var r = int.Parse(Console.ReadLine());
			var c = int.Parse(Console.ReadLine());
			if (type == "premiere")
			{
				Console.WriteLine("{0:F2} leva", (r * c * 12.00));
			}
			else if (type == "normal")
			{
				Console.WriteLine("{0:F2} leva", (r * c * 7.50));
			}
			else if (type == "discount")
			{
				Console.WriteLine("{0:F2} leva", (r * c * 5.00));
			}
		}
	}
}