using System;

namespace passByOutput {
	class NumberManipulator {
		public void getValues(out int x, out int y) {
			Console.WriteLine("Enter the first value: " );
			x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the second value: ");
			y = Convert.ToInt32(Console.ReadLine());
		}
	}
	class Execute {
		static void Main(String[] args) {
			NumberManipulator n = new NumberManipulator();

			int a, b;
			
			n.getValues(out a, out b);

			Console.WriteLine("value of a after output assignment: {0}", a);
			Console.WriteLine("value of b after output assignment: {0}", b);
			Console.ReadLine();
		}
	}
}
