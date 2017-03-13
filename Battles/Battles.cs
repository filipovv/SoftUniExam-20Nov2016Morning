using System;

namespace Battles
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int pokemonsFirstPlayer = int.Parse(Console.ReadLine());
			int pokemonsSecondPlayer = int.Parse(Console.ReadLine());
			int maxBattles = int.Parse(Console.ReadLine());

			int battleCounter = 0;

			for (int i = 1; i <= pokemonsFirstPlayer; i++)
			{
				for (int j = 1; j <= pokemonsSecondPlayer; j++)
				{
					if (battleCounter<maxBattles)
					{
						Console.Write($"({i} <-> {j})");
						Console.Write(' ');
					}
					battleCounter++;
				}
			}
		}
	}
}
