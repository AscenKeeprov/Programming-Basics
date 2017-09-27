using System;

namespace Number0To100ToText
{
	class Program
	{
		static void Main(string[] args)
		{
			var num = int.Parse(Console.ReadLine());
			var dig1 = num % 10;
			var dig2 = (num / 10) % 10;
			var dig3 = (num / 100) % 10;
			if (num < 0 || num > 100)
			{
				Console.WriteLine("invalid number");
			}
			else
			{
				if (dig3 == 1)
				{
					Console.WriteLine("one hundred");
				}
				else
				{
					if (dig2 == 9)
					{
						if (dig1 == 9)
						{
							Console.WriteLine("ninety nine");
						}
						else if (dig1 == 8)
						{
							Console.WriteLine("ninety eight");
						}
						else if (dig1 == 7)
						{
							Console.WriteLine("ninety seven");
						}
						else if (dig1 == 6)
						{
							Console.WriteLine("ninety six");
						}
						else if (dig1 == 5)
						{
							Console.WriteLine("ninety five");
						}
						else if (dig1 == 4)
						{
							Console.WriteLine("ninety four");
						}
						else if (dig1 == 3)
						{
							Console.WriteLine("ninety three");
						}
						else if (dig1 == 2)
						{
							Console.WriteLine("ninety two");
						}
						else if (dig1 == 1)
						{
							Console.WriteLine("ninety one");
						}
						else
						{
							Console.WriteLine("ninety");
						}
					}
					else if (dig2 == 8)
					{
						if (dig1 == 9)
						{
							Console.WriteLine("eighty nine");
						}
						else if (dig1 == 8)
						{
							Console.WriteLine("eighty eight");
						}
						else if (dig1 == 7)
						{
							Console.WriteLine("eighty seven");
						}
						else if (dig1 == 6)
						{
							Console.WriteLine("eighty six");
						}
						else if (dig1 == 5)
						{
							Console.WriteLine("eighty five");
						}
						else if (dig1 == 4)
						{
							Console.WriteLine("eighty four");
						}
						else if (dig1 == 3)
						{
							Console.WriteLine("eighty three");
						}
						else if (dig1 == 2)
						{
							Console.WriteLine("eighty two");
						}
						else if (dig1 == 1)
						{
							Console.WriteLine("eighty one");
						}
						else
						{
							Console.WriteLine("eighty");
						}
					}
					else if (dig2 == 7)
					{
						if (dig1 == 9)
						{
							Console.WriteLine("seventy nine");
						}
						else if (dig1 == 8)
						{
							Console.WriteLine("seventy eight");
						}
						else if (dig1 == 7)
						{
							Console.WriteLine("seventy seven");
						}
						else if (dig1 == 6)
						{
							Console.WriteLine("seventy six");
						}
						else if (dig1 == 5)
						{
							Console.WriteLine("seventy five");
						}
						else if (dig1 == 4)
						{
							Console.WriteLine("seventy four");
						}
						else if (dig1 == 3)
						{
							Console.WriteLine("seventy three");
						}
						else if (dig1 == 2)
						{
							Console.WriteLine("seventy two");
						}
						else if (dig1 == 1)
						{
							Console.WriteLine("seventy one");
						}
						else
						{
							Console.WriteLine("seventy");
						}
					}
					else if (dig2 == 6)
					{
						if (dig1 == 9)
						{
							Console.WriteLine("sixty nine");
						}
						else if (dig1 == 8)
						{
							Console.WriteLine("sixty eight");
						}
						else if (dig1 == 7)
						{
							Console.WriteLine("sixty seven");
						}
						else if (dig1 == 6)
						{
							Console.WriteLine("sixty six");
						}
						else if (dig1 == 5)
						{
							Console.WriteLine("sixty five");
						}
						else if (dig1 == 4)
						{
							Console.WriteLine("sixty four");
						}
						else if (dig1 == 3)
						{
							Console.WriteLine("sixty three");
						}
						else if (dig1 == 2)
						{
							Console.WriteLine("sixty two");
						}
						else if (dig1 == 1)
						{
							Console.WriteLine("sixty one");
						}
						else
						{
							Console.WriteLine("sixty");
						}
					}
					else if (dig2 == 5)
					{
						if (dig1 == 9)
						{
							Console.WriteLine("fifty nine");
						}
						else if (dig1 == 8)
						{
							Console.WriteLine("fifty eight");
						}
						else if (dig1 == 7)
						{
							Console.WriteLine("fifty seven");
						}
						else if (dig1 == 6)
						{
							Console.WriteLine("fifty six");
						}
						else if (dig1 == 5)
						{
							Console.WriteLine("fifty five");
						}
						else if (dig1 == 4)
						{
							Console.WriteLine("fifty four");
						}
						else if (dig1 == 3)
						{
							Console.WriteLine("fifty three");
						}
						else if (dig1 == 2)
						{
							Console.WriteLine("fifty two");
						}
						else if (dig1 == 1)
						{
							Console.WriteLine("fifty one");
						}
						else
						{
							Console.WriteLine("fifty");
						}
					}
					else if (dig2 == 4)
					{
						if (dig1 == 9)
						{
							Console.WriteLine("forty nine");
						}
						else if (dig1 == 8)
						{
							Console.WriteLine("forty eight");
						}
						else if (dig1 == 7)
						{
							Console.WriteLine("forty seven");
						}
						else if (dig1 == 6)
						{
							Console.WriteLine("forty six");
						}
						else if (dig1 == 5)
						{
							Console.WriteLine("forty five");
						}
						else if (dig1 == 4)
						{
							Console.WriteLine("forty four");
						}
						else if (dig1 == 3)
						{
							Console.WriteLine("forty three");
						}
						else if (dig1 == 2)
						{
							Console.WriteLine("forty two");
						}
						else if (dig1 == 1)
						{
							Console.WriteLine("forty one");
						}
						else
						{
							Console.WriteLine("forty");
						}
					}
					else if (dig2 == 3)
					{
						if (dig1 == 9)
						{
							Console.WriteLine("thirty nine");
						}
						else if (dig1 == 8)
						{
							Console.WriteLine("thirty eight");
						}
						else if (dig1 == 7)
						{
							Console.WriteLine("thirty seven");
						}
						else if (dig1 == 6)
						{
							Console.WriteLine("thirty six");
						}
						else if (dig1 == 5)
						{
							Console.WriteLine("thirty five");
						}
						else if (dig1 == 4)
						{
							Console.WriteLine("thirty four");
						}
						else if (dig1 == 3)
						{
							Console.WriteLine("thirty three");
						}
						else if (dig1 == 2)
						{
							Console.WriteLine("thirty two");
						}
						else if (dig1 == 1)
						{
							Console.WriteLine("thirty one");
						}
						else
						{
							Console.WriteLine("thirty");
						}
					}
					else if (dig2 == 2)
					{
						if (dig1 == 9)
						{
							Console.WriteLine("twenty nine");
						}
						else if (dig1 == 8)
						{
							Console.WriteLine("twenty eight");
						}
						else if (dig1 == 7)
						{
							Console.WriteLine("twenty seven");
						}
						else if (dig1 == 6)
						{
							Console.WriteLine("twenty six");
						}
						else if (dig1 == 5)
						{
							Console.WriteLine("twenty five");
						}
						else if (dig1 == 4)
						{
							Console.WriteLine("twenty four");
						}
						else if (dig1 == 3)
						{
							Console.WriteLine("twenty three");
						}
						else if (dig1 == 2)
						{
							Console.WriteLine("twenty two");
						}
						else if (dig1 == 1)
						{
							Console.WriteLine("twenty one");
						}
						else
						{
							Console.WriteLine("twenty");
						}
					}
					else if (dig2 == 1)
					{
						if (dig1 == 9)
						{
							Console.WriteLine("nineteen");
						}
						else if (dig1 == 8)
						{
							Console.WriteLine("eighteen");
						}
						else if (dig1 == 7)
						{
							Console.WriteLine("seventeen");
						}
						else if (dig1 == 6)
						{
							Console.WriteLine("sixteen");
						}
						else if (dig1 == 5)
						{
							Console.WriteLine("fifteen");
						}
						else if (dig1 == 4)
						{
							Console.WriteLine("fourteen");
						}
						else if (dig1 == 3)
						{
							Console.WriteLine("thirteen");
						}
						else if (dig1 == 2)
						{
							Console.WriteLine("twelve");
						}
						else if (dig1 == 1)
						{
							Console.WriteLine("eleven");
						}
						else
						{
							Console.WriteLine("ten");
						}
					}
					else
					{
						if (dig1 == 9)
						{
							Console.WriteLine("nine");
						}
						else if (dig1 == 8)
						{
							Console.WriteLine("eight");
						}
						else if (dig1 == 7)
						{
							Console.WriteLine("seven");
						}
						else if (dig1 == 6)
						{
							Console.WriteLine("six");
						}
						else if (dig1 == 5)
						{
							Console.WriteLine("five");
						}
						else if (dig1 == 4)
						{
							Console.WriteLine("four");
						}
						else if (dig1 == 3)
						{
							Console.WriteLine("three");
						}
						else if (dig1 == 2)
						{
							Console.WriteLine("two");
						}
						else if (dig1 == 1)
						{
							Console.WriteLine("one");
						}
						else
						{
							Console.WriteLine("zero");
						}
					}
				}
			}
		}
	}
}