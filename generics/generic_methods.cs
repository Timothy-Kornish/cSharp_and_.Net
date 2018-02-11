using System;
using System.Collections.Generic;

namespace GenericMethodApplication {
	class Program {
		public static void Swap<T>(ref T lhs, ref T rhs) {
			T temp;
			temp = lhs;
			lhs = rhs;
			rhs = temp;
		}

		public static void Main(String[] args) {
			int a, b;
			char c, d;

			a = 10;
			b = 20;
			c = 'A';
			d = 'B';

			Console.WriteLine("Int values before calling swap: ");
			Console.WriteLine("a = {0}, b = {1}", a, b);
			Console.WriteLine("Char values before calling swap: ");
			Console.WriteLine("c = {0}, d = {1}", c, d);

			Swap<int>(ref a, ref b);
			Swap<char>(ref c, ref d);

			Console.WriteLine("Int values after calling swap: ");
			Console.WriteLine("a = {0}, b = {1}", a, b);
			Console.WriteLine("Char values after calling swap: ");
			Console.WriteLine("c = {0}, d = {1}", c, d);

			Console.ReadKey();
		}
	}
}
