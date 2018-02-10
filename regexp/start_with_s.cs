using System;
using System.Text.RegularExpressions;

namespace RegExApplication {
	class Program {
		private static void showMatch(String text, String expr) {
			Console.WriteLine("The Expression: " + expr);
			MatchCollection mc = Regex.Matches(text, expr);
			foreach(Match m in mc) {
				Console.WriteLine(m);
			}
		}

		public static void Main(String[] args) {
			String str = "A Thousnad Splendid Suns Surfing Through The Universe";
			Console.WriteLine("Matching wods that start with 'S': ");
			showMatch(str, @"\bS\S*");
			Console.ReadKey();
		}
	}
}			
