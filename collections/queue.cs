using System;
using System.Collections;

namespace CollectionsApplication {
	class Program {
		public static void Main(String[] args) {
			
			Queue q = new Queue();

			q.Enqueue('A');
			q.Enqueue('B');
			q.Enqueue('C');
			q.Enqueue('D');

			Console.WriteLine("Current queue: ");

			foreach(char c in q) {
				Console.Write(c + " ");
			}

			Console.WriteLine();

			q.Enqueue('E');
			q.Enqueue('F');

			Console.WriteLine("Current Queue: ");

			foreach (char c in q) {
				Console.Write(c + " ");
			}

			Console.WriteLine();
			Console.WriteLine("Removing values: ");

			char ch = (char)q.Dequeue();
			Console.WriteLine("The removed value: {0}", ch);

			ch = (char)q.Dequeue();
			Console.WriteLine("The removed value: {0}", ch);

			Console.ReadKey();
		}
	}
}
