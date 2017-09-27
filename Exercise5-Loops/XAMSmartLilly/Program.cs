using System;

namespace XAMSmartLilly
{
	class Program
	{
		static void Main(string[] args)
		{
			var age = int.Parse(Console.ReadLine());
			var WMprice = double.Parse(Console.ReadLine());
			var Tprice = int.Parse(Console.ReadLine());
			var savings = 0.00;
			var thief = 0.00;
			var toys = 0;
			for (int bday = 1; bday <= age; bday++)
			{
				if (bday % 2 == 0)
				{
					thief += 1.00;
					savings += thief * 10.00;
				}
				else if (bday % 2 != 0) toys++;
			}
			savings += (toys * Tprice) - thief;
			if (savings >= WMprice) Console.WriteLine("Yes! {0:0.00}", savings - WMprice);
			else Console.WriteLine("No! {0:0.00}", WMprice - savings);
		}
	}
}