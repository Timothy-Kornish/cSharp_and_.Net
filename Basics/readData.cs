using System;

namespace VariableDefinition {

	class Program {
		
		public static void Main(String[] args) {

		short a;
		int b;
		double c;

		/* Actual Initialization */

		a = 10;
		b = 20;
		c = a + b;

		Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
		
		int num = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("input is: {0}", num);
		Console.ReadLine();
		}
	}
}
