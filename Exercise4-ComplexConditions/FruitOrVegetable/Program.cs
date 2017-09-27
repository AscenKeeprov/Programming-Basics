using System;

namespace FruitOrVegetable
{
	class Program
	{
		static void Main(string[] args)
		{
			string prod = Console.ReadLine().ToLower();
			if (prod == "banana" || prod == "apple" || prod == "kiwi" || prod == "cherry" || prod == "lemon" || prod == "grapes")
			{
				Console.WriteLine("fruit");
			}
			else if (prod == "tomato" || prod == "cucumber" || prod == "pepper" || prod == "carrot")
			{
				Console.WriteLine("vegetable");
			}
			else
			{
				Console.WriteLine("unknown");
			}
		}
	}
}