using System;

namespace XAMFortress
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			Console.Write("/");
			Console.Write(new string('^', n / 2));
			Console.Write("\\");
			if (n % 2 == 0) Console.Write(new string('_', n - 4));
			else Console.Write(new string('_', n - 3));
			Console.Write("/");
			Console.Write(new string('^', n / 2));
			Console.WriteLine("\\");
			for (int i = 1; i <= n - 2; i++)
			{
				Console.Write("|");
				Console.Write(new string(' ', n / 2 + 1));
				if (i == n - 2)
				{
					if (n % 2 == 0) Console.Write(new string('_', n - 4));
					else Console.Write(new string('_', n - 3));
				}
				else
				{
					if (n % 2 == 0) Console.Write(new string(' ', n - 4));
					else Console.Write(new string(' ', n - 3));
				}
				Console.Write(new string(' ', n / 2 + 1));
				Console.WriteLine("|");
			}
			Console.Write("\\");
			Console.Write(new string('_', n / 2));
			Console.Write("/");
			if (n % 2 == 0) Console.Write(new string(' ', n - 4));
			else Console.Write(new string(' ', n - 3));
			Console.Write("\\");
			Console.Write(new string('_', n / 2));
			Console.WriteLine("/");
		}
	}
}