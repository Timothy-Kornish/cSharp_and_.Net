using System;

namespace nullables {
	class NullablesAtShow {
		static void Main(String[] args) {
			double? num1 = null;
			double? num2 = 3.14159;
			double num3;

			// ?? is kind an inplace ternary
			// known as Null Coalescing Operator (??)
			// if first value is null, then lvalue = value right of ??
			num3 = num1 ?? 5.34;
			Console.WriteLine("Value of num3: {0}", num3);
			
			num3 = num2 ?? 5.35;
			Console.WriteLine("Value of num3: {0}", num3);
			Console.ReadLine();
		}
	}
}
