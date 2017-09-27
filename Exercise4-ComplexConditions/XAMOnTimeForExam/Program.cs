using System;

namespace XAMOnTimeForExam
{
	class Program
	{
		static void Main(string[] args)
		{
			var TexamH = int.Parse(Console.ReadLine());
			var TexamM = int.Parse(Console.ReadLine());
			var TarriveH = int.Parse(Console.ReadLine());
			var TarriveM = int.Parse(Console.ReadLine());
			var dH = TexamH - TarriveH;
			var dM = TexamM - TarriveM;
			if (dH < -1)
			{
				if (dM <= 0)
				{
					Console.WriteLine("Late");
					Console.WriteLine("{0}:{1:00} hours after the start", -dH, -dM);	//checked
				}
				else if (dM > 0)
				{
					Console.WriteLine("Late");
					Console.WriteLine("{0}:{1:00} hours after the start", (-dH - 1), (60 - dM));	//checked
				}
			}
			else if (dH == -1)
			{
				if (dM <= 0)
				{
					Console.WriteLine("Late");
					Console.WriteLine("{0}:{1:00} hours after the start", -dH, -dM);	//checked
				}
				else if (dM > 0)
				{
					Console.WriteLine("Late");
					Console.WriteLine("{0} minutes after the start", (60 - dM));	//checked
				}
			}
			else if (dH == 0)
			{
				if (dM < 0)
				{
					Console.WriteLine("Late");
					Console.WriteLine("{0} minutes after the start", -dM);	//checked
				}
				else if (dM == 0) Console.WriteLine("On time");	//checked
				else if (dM > 0)
				{
					if (dM <= 30)
					{
						Console.WriteLine("On time");
						Console.WriteLine("{0} minutes before the start", dM);	//checked
					}
					else
					{
						Console.WriteLine("Early");
						Console.WriteLine("{0} minutes before the start", dM);	//checked
					}
				}	
			}
			else if (dH == 1)
			{
				if (dM < 0)
				{
					if (dM > -30)
					{
						Console.WriteLine("Early");
						Console.WriteLine("{0} minutes before the start", (60 + dM));	//checked
					}
					else
					{
						Console.WriteLine("On time");
						Console.WriteLine("{0} minutes before the start", (60 + dM));	//checked
					}
				}
				else if ( dM >= 0)
				{
					Console.WriteLine("Early");
					Console.WriteLine("{0}:{1:00} hours before the start", dH, dM);	//checked
				}
			}
			else if (dH > 1)
			{
				if (dM < 0)
				{
					Console.WriteLine("Early");
					Console.WriteLine("{0}:{1:00} hours before the start", (dH - 1), (60 + dM));	//checked
				}
				else if (dM >= 0)
				{
					Console.WriteLine("Early");
					Console.WriteLine("{0}:{1:00} hours before the start", dH, dM);	//checked
				}
			}
		}
	}
}