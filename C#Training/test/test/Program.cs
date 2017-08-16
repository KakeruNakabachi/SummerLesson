﻿using System;

namespace test
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			int a = 10;
			Console.WriteLine(a);
			double b = 1.0;
			Console.WriteLine(b);

			var c = 10;
			var d = 5.9;

			int e = (int)d;
			double f = (double)c;


			string s = "Sample Text";
			Console.WriteLine(s);
			Console.WriteLine(
				string.Format("({0}, {1})", 10, 20));


			int[] x = new[] { 1, 2, 3, 4, 5 };


			for (int i = 0; i < x.Length; i++)
			{
				Console.WriteLine(x[i]);
			}

			foreach (var item in x)
			{
				Console.WriteLine(item);
			}


			foreach (var item in x)
			{
				if (item % 2 == 0)
				{
					Console.WriteLine("偶数");
				}
				else
				{
					Console.WriteLine("奇数");
				}
			}
		}

		private static int Plus(int a, int c)
		{
			int g = a + c;
			return g;
		}

		struct Point
		{
			public int X;
			public int Y;
		}

		static void PointSet(string[] args)
		{
			var p = new Point
			{
				X = 10,
				Y = 20
			};

			Console.WriteLine(p.X);
			Console.WriteLine(p.Y);
		}


	}
}
