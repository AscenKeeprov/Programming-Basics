using System;

namespace SequenceOfIncrements
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var numOld = -1001;
			var maxSeq = 0;
			var seq = 0;
			for (int i = 1; i <= n; i++)
			{
				var num = int.Parse(Console.ReadLine());
				if (num > numOld)
				{
					seq++;
					if (seq > maxSeq) maxSeq = seq;
				}
				else seq = 1;
				numOld = num;
			}
			Console.WriteLine(maxSeq);
		}
	}
}