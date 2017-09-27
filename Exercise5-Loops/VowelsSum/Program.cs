using System;

namespace VowelsSum
{
	class Program
	{
		static void Main(string[] args)
		{
			var vSum = 0;
			string text = Console.ReadLine().ToLower();
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == 'a') vSum += 1;
				else if (text[i] == 'e') vSum += 2;
				else if (text[i] == 'i') vSum += 3;
				else if (text[i] == 'o') vSum += 4;
				else if (text[i] == 'u') vSum += 5;
			}
			Console.WriteLine(vSum);
		}
	}
}