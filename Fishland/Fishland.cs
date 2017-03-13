using System;

namespace Fishland
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double skumriyaPrice = double.Parse(Console.ReadLine());
			double tsatsaPrice = double.Parse(Console.ReadLine());
			double palamudKg = double.Parse(Console.ReadLine());
			double safridKg = double.Parse(Console.ReadLine());
			double midiKg = double.Parse(Console.ReadLine());

			double palamudPrice = skumriyaPrice + skumriyaPrice * 60 / 100;
			double safridPrice = tsatsaPrice + tsatsaPrice * 80 / 100;
			double midiPrice = 7.50;

			double sumPalamud = palamudKg * palamudPrice;
			double sumSafrid = safridKg * safridPrice;
			double sumMidi = midiKg * midiPrice;
			double sum = sumMidi + sumSafrid + sumPalamud;

			Console.WriteLine($"{sum:f2}");
		}
	}
}
