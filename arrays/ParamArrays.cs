using System;

namespace ArrayApplication {
	class ParamArray {

		/* params allows any number of parameters be passed into the method,
		all will be put into a new array,
		an array does not need to be pre-instantiated then passed to method
		*/

		public int AddElements(params int[] arr) {
			int sum = 0;

			foreach(int i in arr) {
				sum += i;
			}
			return sum;
		}
	}

	class TestClass {
		static void Main(String[] args) {
			ParamArray arr = new ParamArray();

			int sum = arr.AddElements(512, 720, 250, 567, 889);
			Console.WriteLine("The sum is: {0}", sum);
			Console.ReadKey();
		}
	}
}
