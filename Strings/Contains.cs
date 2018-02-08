using System;

namespace StringApplication {
	class StringProg {
		static void Main(String[] args) {
			String str = "This is a test";

			if(str.Contains("test")) {
				Console.WriteLine("The sequence 'test' was found");
			}
			Console.ReadKey();
		}
	}
}
			
