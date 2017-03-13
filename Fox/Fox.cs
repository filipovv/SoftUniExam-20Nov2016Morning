using System;

namespace Fox
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());


			char star = '*';
			char bslash = '\\';
			char fslash = '/';
			char dash = '-';
			char wall = '|';


			for (int i = 1; i <= n; i++)
			{
				Console.WriteLine(new string(star, i)+ bslash+ new string(dash, (2*n+1)-2*i)+fslash+ new string(star, i));
			}

			for (int j = 1; j <= n/3; j++)
			{
				Console.WriteLine(wall + new string(star, n / 2-1+j) + bslash + new string(star, (n + 2) - 2 * j) + fslash + new string(star, n / 2-1+j) + wall);
			}

			for (int l = 1; l <= n; l++)
			{
				Console.WriteLine(new string(dash, l) + bslash + new string(star, (2 * n + 1) - 2 * l) + fslash+new string(dash, l));
			}
		}
	}
}
