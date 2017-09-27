using System;

namespace BrickHaul
{
	class Program
	{
		static void Main(string[] args)
		{
			var b = int.Parse(Console.ReadLine());	//Брой тухли (bricks)
			var w = int.Parse(Console.ReadLine());	//Брой работници (workers)
			var c = int.Parse(Console.ReadLine());	//Вместимост на количките (Capacity)
			double k = (double)b / (w * c);			//Превръщаме цялото число в десетично преди деление, за да не се унищожи остатъка и да се получи грешен краен отговор
			Console.WriteLine(Math.Ceiling(k));		//Използваме специален метод, за да закръглим до по-голямо цяло число, понеже търсим минималния брой курсове (0.1 -> 1)
		}
	}
}