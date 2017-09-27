using System;

namespace XAMNumOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			var N1 = int.Parse(Console.ReadLine());
			var N2 = int.Parse(Console.ReadLine());
			var result = 0.00;
			string sign = Console.ReadLine();
			if (sign == "+")
			{
				result = N1 + N2;
				if (result % 2 == 0) Console.WriteLine("{0} + {1} = {2} - even", N1, N2, result);
				else Console.WriteLine("{0} + {1} = {2} - odd", N1, N2, result);
			}
			else if (sign == "-")
			{
				result = N1 - N2;
				if (result % 2 == 0) Console.WriteLine("{0} - {1} = {2} - even", N1, N2, result);
				else Console.WriteLine("{0} - {1} = {2} - odd", N1, N2, result);
			}
			else if (sign == "*")
			{
				result = N1 * N2;
				if (result % 2 == 0) Console.WriteLine("{0} * {1} = {2} - even", N1, N2, result);
				else Console.WriteLine("{0} * {1} = {2} - odd", N1, N2, result);
			}
			else if (sign == "/")
			{
				if (N2 == 0) Console.WriteLine("Cannot divide {0} by zero", N1);
				else
				{
					result = 1.00 * N1 / N2;
					Console.WriteLine("{0} / {1} = {2:F2}", N1, N2, result);
				}
			}
			else if (sign == "%")
			{
				if (N2 == 0) Console.WriteLine("Cannot divide {0} by zero", N1);
				else
				{
					result = N1 % N2;
					Console.WriteLine("{0} % {1} = {2}", N1, N2, result);
				}
			}
		}
	}
}