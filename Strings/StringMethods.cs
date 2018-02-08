using System;

namespace StringApplication {
	class StringProg {
		static void Main(String[] args) {
			String str1 = "This is test";
			String str2 = "This is text";

			if (String.Compare(str1, str2) == 0) {
				Console.WriteLine("\"" + str1 + "\" and \"" + str2 + " are equal.");
			} else {
				Console.WriteLine("\"" + str1 + "\" and \"" + str2 + " are not equal.");
			}
			Console.ReadKey();
		}
	}
}
