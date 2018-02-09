using System;

namespace StaticPolymorphismApplication {
	class PrintData {
		
		public void print(int i) {
			Console.WriteLine("Printing int; {0}", i);
		}

		public void print(double f) {
			Console.WriteLine("Printing double: {0}", f);
		}

		public void print(String str) {
			Console.WriteLine("Printing String: {0}", str);
		}

	}

	class ExecutePrint {
		public static void Main(String[] args) {
			PrintData p = new PrintData();

			p.print(5);
			p.print(500.263);
			p.print("Hello c++");
			Console.ReadKey();
		}
	}
}	
