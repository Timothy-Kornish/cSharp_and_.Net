using System;

namespace UnsafeCodeApplication {
	class Program {
		public static void Main(String[] args) {
			unsafe {
				int var = 20;
				int* point = &var;

				Console.WriteLine("Data is: {0} ", var);
				Console.WriteLine("Data is: {0} ", point->ToString());
				Console.WriteLine("Address is: {0} ", (int)point);
			}
			Console.ReadKey();
		}
	}
}
