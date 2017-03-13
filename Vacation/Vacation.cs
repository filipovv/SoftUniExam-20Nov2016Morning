using System;

namespace Vacation
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int elders = int.Parse(Console.ReadLine());
			int students = int.Parse(Console.ReadLine());
			int nights = int.Parse(Console.ReadLine());
			string transportation = Console.ReadLine();

			double transPriceElders = 0;
			double transPriceStudents = 0;

			switch (transportation.ToLower())
			{
				case "train": if (elders+students>=50)
					{
						transPriceElders = 24.99/2; transPriceStudents = 14.99/2; break;
					}
					else
					{
						transPriceElders = 24.99; transPriceStudents = 14.99; break;
					}
				case "bus": transPriceElders = 32.50; transPriceStudents = 28.50; break;
				case "boat": transPriceElders = 42.99; transPriceStudents = 39.99; break;
				case "airplane": transPriceElders = 70.00; transPriceStudents = 50.00; break;
				default:
					break;
			}

			double nightsPrice = nights * 82.99;
			double eldersCosts = elders * transPriceElders*2;
			double studentsCosts = students * transPriceStudents*2;

			double costs = nightsPrice + eldersCosts + studentsCosts;
			double total = costs + (costs * 10 / 100);

			Console.WriteLine($"{total:f2}");


		}
	}
}
