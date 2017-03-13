using System;

namespace Pets
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int days = int.Parse(Console.ReadLine());
			int foodKg = int.Parse(Console.ReadLine());
			double dogFoodKg = double.Parse(Console.ReadLine());
			double catFoodKg = double.Parse(Console.ReadLine());
			double turFoodGrams = double.Parse(Console.ReadLine());

			double turFoodKg = turFoodGrams / 1000;

			double foodNeededKg = (dogFoodKg + catFoodKg + turFoodKg) * days;

			if (foodKg>=foodNeededKg)
			{
				double leftover = Math.Max(foodKg, foodNeededKg) - Math.Min(foodKg, foodNeededKg);
				Console.WriteLine($"{Math.Floor(leftover)} kilos of food left.");
			}
			else
			{
				double notenough = Math.Max(foodKg, foodNeededKg) - Math.Min(foodKg, foodNeededKg);
				Console.WriteLine($"{Math.Ceiling(notenough)} more kilos of food are needed.");
			}
		}
	}
}
