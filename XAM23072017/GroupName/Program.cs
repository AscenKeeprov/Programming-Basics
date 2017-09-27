using System;

namespace GroupName
{
	class Program
	{
		static void Main(string[] args)
		{
			char letter1 = char.Parse(Console.ReadLine());
			char letter2 = char.Parse(Console.ReadLine());
			char letter3 = char.Parse(Console.ReadLine());
			char letter4 = char.Parse(Console.ReadLine());
			var digit = int.Parse(Console.ReadLine());
			int suggestions = 0;
			int index1 = (int)letter1 % 32;
			int index2 = (int)letter2 % 32;
			int index3 = (int)letter3 % 32;
			int index4 = (int)letter4 % 32;
			int index5 = digit + 1;
			for (int first = 1; first <= index1; first++)
			{
				for (int second = 1; second <= index2; second++)
				{
					for (int third = 1; third <= index3; third++)
					{
						for (int fourth = 1; fourth <= index4; fourth++)
						{
							for (int fifth = 0; fifth < index5; fifth++)
							{
								suggestions++;
							}
						}
					}
				}
			}
			Console.WriteLine(suggestions - 1);
		}
	}
}