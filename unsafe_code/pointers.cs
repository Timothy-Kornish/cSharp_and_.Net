using System;

namespace UnsafeCodeApplication {
	class Program {
		public static unsafe void Main(String[] args) {
			int var = 20;
			int* point = &var;

			Console.WriteLine("Data is: {0}", var);
			Console.WriteLine("Address is: {0}", (int)point);
			Console.ReadKey();
		}
	}
}
