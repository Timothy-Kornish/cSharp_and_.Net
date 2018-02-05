using System;

namespace TypeConversionApplication {
	class ExplicitConversion {
		static void Main(String[] args) {
			
			double d = 5673.74;
			int i;

			Console.WriteLine("value as double: {0}", d);
			// casting a double value to an int
			// same as java
			i = (int)d;

			Console.WriteLine("value as int: {0}", i);
			Console.ReadKey();
		}
	}
}

