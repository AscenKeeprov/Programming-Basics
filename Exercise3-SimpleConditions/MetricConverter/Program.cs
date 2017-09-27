using System;

namespace MetricConverter
{
	class Program
	{
		static void Main(string[] args)
		{
			var distance = double.Parse(Console.ReadLine());
			var metric1 = Console.ReadLine();
			var metric2 = Console.ReadLine();
			if (metric1 == "m")
			{
				if (metric2 == "m")
				{
					Console.WriteLine("{0:0.00000000} {1}", distance, metric2);
				}
				else if (metric2 == "mm")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 1000), metric2);
				}
				else if (metric2 == "cm")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 100), metric2);
				}
				else if (metric2 == "mi")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.000621371192), metric2);
				}
				else if (metric2 == "in")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 39.3700787), metric2);
				}
				else if (metric2 == "km")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.001), metric2);
				}
				else if (metric2 == "ft")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 3.2808399), metric2);
				}
				else if (metric2 == "yd")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 1.0936133), metric2);
				}
			}
			else if (metric1 == "mm")
			{
				if (metric2 == "m")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.001), metric2);
				}
				else if (metric2 == "mm")
				{
					Console.WriteLine("{0:0.00000000} {1}", distance , metric2);
				}
				else if (metric2 == "cm")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.1), metric2);
				}
				else if (metric2 == "mi")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.000000621371192), metric2);
				}
				else if (metric2 == "in")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.039370079), metric2);
				}
				else if (metric2 == "km")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.000001), metric2);
				}
				else if (metric2 == "ft")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.00328084), metric2);
				}
				else if (metric2 == "yd")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.001093613), metric2);
				}
			}
			else if (metric1 == "cm")
			{
				if (metric2 == "m")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.01), metric2);
				}
				else if (metric2 == "mm")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 10), metric2);
				}
				else if (metric2 == "cm")
				{
					Console.WriteLine("{0:0.00000000} {1}", distance, metric2);
				}
				else if (metric2 == "mi")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.00000621371192), metric2);
				}
				else if (metric2 == "in")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.393700787), metric2);
				}
				else if (metric2 == "km")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.00001), metric2);
				}
				else if (metric2 == "ft")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.032808399), metric2);
				}
				else if (metric2 == "yd")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.010936133), metric2);
				}
			}
			else if (metric1 == "mi")
			{
				if (metric2 == "m")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 1609.344001), metric2);
				}
				else if (metric2 == "mm")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 1609344.001), metric2);
				}
				else if (metric2 == "cm")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 160934.4001), metric2);
				}
				else if (metric2 == "mi")
				{
					Console.WriteLine("{0:0.00000000} {1}", distance, metric2);
				}
				else if (metric2 == "in")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 63359.99996), metric2);
				}
				else if (metric2 == "km")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 1.609344001), metric2);
				}
				else if (metric2 == "ft")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 5280.00001), metric2);
				}
				else if (metric2 == "yd")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 1760.000003), metric2);
				}
			}
			else if (metric1 == "in")
			{
				if (metric2 == "m")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.0254), metric2);
				}
				else if (metric2 == "mm")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 25.40000003), metric2);
				}
				else if (metric2 == "cm")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 2.540000003), metric2);
				}
				else if (metric2 == "mi")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.0000157828282929), metric2);
				}
				else if (metric2 == "in")
				{
					Console.WriteLine("{0:0.00000000} {1}", distance, metric2);
				}
				else if (metric2 == "km")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.0000254), metric2);
				}
				else if (metric2 == "ft")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.083333334), metric2);
				}
				else if (metric2 == "yd")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.027777778), metric2);
				}
			}
			else if (metric1 == "km")
			{
				if (metric2 == "m")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 1000), metric2);
				}
				else if (metric2 == "mm")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 1000000), metric2);
				}
				else if (metric2 == "cm")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 100000), metric2);
				}
				else if (metric2 == "mi")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.621371192), metric2);
				}
				else if (metric2 == "in")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 39370.0787), metric2);
				}
				else if (metric2 == "km")
				{
					Console.WriteLine("{0:0.00000000} {1}", distance, metric2);
				}
				else if (metric2 == "ft")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 3280.8399), metric2);
				}
				else if (metric2 == "yd")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 1093.6133), metric2);
				}
			}
			else if (metric1 == "ft")
			{
				if (metric2 == "m")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.3048), metric2);
				}
				else if (metric2 == "mm")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 304.7999995), metric2);
				}
				else if (metric2 == "cm")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 30.47999995), metric2);
				}
				else if (metric2 == "mi")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.000189394), metric2);
				}
				else if (metric2 == "in")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 11.99999997), metric2);
				}
				else if (metric2 == "km")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.0003048), metric2);
				}
				else if (metric2 == "ft")
				{
					Console.WriteLine("{0:0.00000000} {1}", distance, metric2);
				}
				else if (metric2 == "yd")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.333333333), metric2);
				}
			}
			else if (metric1 == "yd")
			{
				if (metric2 == "m")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.914399999), metric2);
				}
				else if (metric2 == "mm")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 914.3999986), metric2);
				}
				else if (metric2 == "cm")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 91.43999986), metric2);
				}
				else if (metric2 == "mi")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.000568182), metric2);
				}
				else if (metric2 == "in")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 35.99999991), metric2);
				}
				else if (metric2 == "km")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 0.0009144), metric2);
				}
				else if (metric2 == "ft")
				{
					Console.WriteLine("{0:0.00000000} {1}", (distance * 3), metric2);
				}
				else if (metric2 == "yd")
				{
					Console.WriteLine("{0:0.00000000} {1}", distance, metric2);
				}
			}
		}
	}
}