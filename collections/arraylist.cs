using System;
using System.Collections;

namespace CollectionApplication {
	class Program {
		public static void Main(String[] args) {
			ArrayList al = new ArrayList();
			Console.WriteLine("Adding some numbers: ");

			for (int i = 0; i < 10; i++) {
				al.Add((i*130)%59);
			}

			Console.WriteLine("Capacity: {0}", al.Capacity);
			Console.WriteLine("Count: {0}", al.Count);

			Console.Write("Content: ");
			foreach (int i in al) {
				Console.Write(i + " ");
			}

			Console.WriteLine();
			Console.Write("Sorted Content: ");

			al.Sort();
			foreach (int i in al) {
				Console.Write(i + " ");
			}
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
