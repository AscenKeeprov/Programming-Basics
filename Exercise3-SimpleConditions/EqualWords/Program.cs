using System;

namespace EqualWords
{
	class Program
	{
		static void Main(string[] args)
		{
			String word1 = Console.ReadLine();
			word1 = word1.ToLower();
			String word2 = Console.ReadLine();
			word2 = word2.ToLower();
			if (word1 == word2)
			{
				Console.WriteLine("yes");
			}
			else
			{
				Console.WriteLine("no");
			}
		}
	}
}