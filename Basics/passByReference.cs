using System;

namespace passByReference {
	class NumberManipulator {
		public void swap(ref int x, ref int y) {
			int temp = x;
			x = y;
			y = temp;
		}
	}

	class Execute {
		static void Main(String[] args) {
			int a = 100;
			int b = 200;

			Console.WriteLine("Before swap, value of a: {0}", a);
			Console.WriteLine("Before swap, value of b: {0}", b);

			NumberManipulator n = new NumberManipulator();
			n.swap(ref a, ref b);

			Console.WriteLine("After swap, value of a: {0}", a);
			Console.WriteLine("After swap, value of b: {0}", b);

			Console.ReadLine();

		}
	}
}
