using System;
using System.Text.RegularExpressions;

namespace RegExApplication {
	class Program {
		static void Main(String[] args) {
			String input = "Hello    World   ";
			String pattern = "\\s+"; //s is whitespace, S is non-whitespace
			String replacement = " ";
			Regex rgx = new Regex(pattern);
			String result = rgx.Replace(input, replacement);

			Console.WriteLine("Original String : |" + input + "|");
			Console.WriteLine("Replacement String : |" + result + "|");
			Console.ReadKey();
		}
	}
}			
