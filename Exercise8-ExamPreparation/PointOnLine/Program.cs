using System;

namespace PointOnSegment
{
	class Program
	{
		static void Main(string[] args)
		{
			var A = short.Parse(Console.ReadLine());
			var B = short.Parse(Console.ReadLine());
			var L = Math.Min(A, B);
			var R = Math.Max(A, B);
			var P = short.Parse(Console.ReadLine());
			if (P >= L && P <= R) Console.WriteLine("In");
			else Console.WriteLine("Out");
			Console.WriteLine("Offset: " + Math.Min(Math.Abs(P - L), Math.Abs(R - P)));
		}
	}
}