using System;
using System.Globalization;

namespace KiloDaysAfterBirth
{
	class Program
	{
		static void Main(string[] args)
		{
			CultureInfo ci = CultureInfo.InvariantCulture;
			string format = "dd-MM-yyyy";
			string input = Console.ReadLine();
			DateTime bDay = DateTime.ParseExact(input, format, ci);
			DateTime kDay = bDay.AddDays(1000);
			Console.WriteLine(kDay.ToUniversalTime().ToString("dd-MM-yyyy"));
		}
	}
}