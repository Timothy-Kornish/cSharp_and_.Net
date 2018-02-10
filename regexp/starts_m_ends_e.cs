using System;
using System.Text.RegularExpressions;

namespace RegExApplication {
	class Program {
		private static void showMatch(String text, String expr) {
			Console.WriteLine("Expression: " + expr);
			MatchCollection mc = Regex.Matches(text, expr);
			foreach(Match m in mc) {
				Console.WriteLine(m);
			}
		}

		public static void Main(String[] args) {
			String str = "make a maze and manage to measure it matt";
			Console.WriteLine("Matching words start with 'm' and ends with 'e':");
			showMatch(str, @"\bm\S*e\b");
			Console.ReadKey();
		}
	}
}
