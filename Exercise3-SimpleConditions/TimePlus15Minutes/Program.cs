using System;

namespace TimePlus15Minutes
{
	class Program
	{
		static void Main(string[] args)
		{
			var hours = int.Parse(Console.ReadLine());
			var minutes = int.Parse(Console.ReadLine());
			minutes += 15;
			if (minutes > 59)
			{
				hours += 1;
				minutes -= 60;
				if (hours > 23)
				{
					Console.WriteLine("{0}:{1:00}", (hours - 24), minutes);
				}
				else
				{
					Console.WriteLine("{0}:{1:00}", hours, minutes);
				}
			}
			else
			{
				Console.WriteLine("{0}:{1:00}", hours, minutes);
			}
		}
	}
}