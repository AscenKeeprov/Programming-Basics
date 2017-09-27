using System;

namespace XAMSpecialNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var N = int.Parse(Console.ReadLine());
			for (int first = 1; first <= 9; first++)
			{
				for (int second = 1; second <= 9; second++)
				{
					for (int third = 1; third <= 9; third++)
					{
						for (int fourth = 1; fourth <= 9; fourth++)
						{
							if (N % first == 0 && N % second == 0 && N % third == 0 && N % fourth == 0) Console.Write("{0}{1}{2}{3} ", first, second, third, fourth);
						}
					}
				}
			}
		}
	}
}