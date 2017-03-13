using System;

namespace SoftUniCamp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int groups = int.Parse(Console.ReadLine());
			double byCar = 0;
			double byMicrobus = 0;
			double bySmBus = 0;
			double byBus = 0;
			double byTrain = 0;
			double total = 0;

			for (int i = 1; i <= groups; i++)
			{
				int groupAmount = int.Parse(Console.ReadLine());
				if (groupAmount>=0&&groupAmount<=5)
				{
					byCar += groupAmount;
					total += groupAmount;

				}
				if (groupAmount>=6&&groupAmount<=12)
				{
					byMicrobus += groupAmount;
					total += groupAmount;

				}
				if (groupAmount>=13&&groupAmount<=25)
				{
					bySmBus += groupAmount;
					total += groupAmount;

				}
				if (groupAmount>=26&&groupAmount<=40)
				{
					byBus += groupAmount;
					total += groupAmount;

				}
				if (groupAmount>=41)
				{
					byTrain += groupAmount;
					total += groupAmount;

				}
			}

			Console.WriteLine($"{(byCar/total*100):f2}%\n{(byMicrobus/total*100):f2}%\n{(bySmBus/total*100):f2}%\n{(byBus/total*100):f2}%\n{(byTrain/total*100):f2}%");
		}
	}
}
