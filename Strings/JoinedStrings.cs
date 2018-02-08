using System;

namespace StringApplication {
	class StringProg {
		static void Main(String[] args) {
			String[] strArray = new String[] {"Down the way nights are dark",
			"And the sun shines daily on the mountain top",
			"I took a trip on a sailing ship",
			"And when I reached Jamaica",
			"I made a stop" };

			String str = String.Join("\n", strArray);
			Console.WriteLine(str);
			Console.ReadKey();
		}
	}
}
