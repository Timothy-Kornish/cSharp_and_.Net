using System;
using System.IO;

namespace FileApplication {
	class Program {
		public static void Main(String[] args) {
			String[] words = new String[] {"These", "Are", "Words", "Going", "Into", "A", "Text", "File"};

			using (StreamWriter sw = new StreamWriter("words.txt")) {
				foreach (String str in words) {
					sw.WriteLine(str);
				}
			}

			String line = "";

			using (StreamReader sr = new StreamReader("words.txt")) {
				while ((line = sr.ReadLine()) != null) {
					Console.WriteLine(line);
				}
			}
			Console.ReadKey();
		}
	}
}
