using System;

namespace StringApplication {
	class StringProg {
		static void Main(String[] args) {
			String str = "Last night i dreamt of San Pedro";
			Console.WriteLine(str);
			int index = str.IndexOf("d");
			int length = 6;
			String substr = str.Substring(index, length);
			Console.WriteLine(substr);
			Console.ReadKey();
		}
	}
}
