using System;

namespace InchesToCentimetres
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Inches = ");
			var inches = double.Parse(Console.ReadLine());
			Console.WriteLine("Centimetres = " + inches * 2.54);
		}
	}
}