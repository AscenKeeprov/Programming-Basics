using System;

namespace XAMDumbPassGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var l = int.Parse(Console.ReadLine());
			string alphabet = "abcdefghijklmnopqrstuvwxyz";
			for (int first = 1; first < n; first++)
			{
				for (int second = 1; second < n; second++)
				{
					for (char third = 'a'; third < alphabet[l]; third++)
					{
						for (char fourth = 'a'; fourth < alphabet[l]; fourth++)
						{
							for (int fifth = 2; fifth <= n; fifth++)
							{
								if (fifth > first && fifth > second) Console.Write("{0}{1}{2}{3}{4} ", first, second, third, fourth, fifth);
							}
						}
					}
				}
			}
		}
	}
}