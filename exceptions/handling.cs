using System;
namespace ErrorHandlingApplication {
	class DivNumbers {
		int result;
		
		public DivNumbers() {
			result = 0;
		}
		public void division(int num1, int num2) {
			try {
				result = num1 / num2;
			} catch (DivideByZeroException e) {
				Console.WriteLine("exception caught: {0}", e);
			} finally {
				Console.WriteLine("Result: {0}", result);
			}
		}

		static void Main(String[] args) {
			DivNumbers d = new DivNumbers();
			d.division(25, 0);
			Console.ReadKey();
		}
	}
}			
