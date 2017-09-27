using System;

namespace AnimalType
{
	class Program
	{
		static void Main(string[] args)
		{
			string klas = Console.ReadLine().ToLower();
			switch (klas)
			{
				case "dog":
					Console.WriteLine("mammal");
					break;
				case "crocodile":
					Console.WriteLine("reptile");
					break;
				case "tortoise":
					Console.WriteLine("reptile");
					break;
				case "snake":
					Console.WriteLine("reptile");
					break;
				default:
					Console.WriteLine("unknown");
					break;
			}
		}
	}
}