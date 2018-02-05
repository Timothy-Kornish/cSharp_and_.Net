using System;

namespace DeclaringConstants {
	class Program {
		public static void Main(String[] args) {

			const double pi = 3.14159;

			double r;
			Console.WriteLine("Enter radius: ");
			r = Convert.ToDouble(Console.ReadLine());

			double area = pi * r * r;
			Console.WriteLine("Radius: {0}, Area of Circle: {1}", r, area);
			Console.ReadLine();
		}
	}
}

