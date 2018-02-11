using System;
using System.Collections;

namespace CollectionsApplication {
	class Program {
		public static void Main(String[] args) {
			Stack stack = new Stack();

			stack.Push('a');
			stack.Push('b');
			stack.Push('c');
			stack.Push('d');

			Console.WriteLine("Current stack: ");

			foreach (char c in stack) {
				Console.Write(c + " ");
			}
			Console.WriteLine();

			stack.Push('e');
			stack.Push('f');

			Console.WriteLine("The next poppable value in stack: {0}", stack.Peek());
			Console.WriteLine("Current stack: ");
			
			foreach (char c in stack) {
				Console.Write(c + " ");
			}
			Console.WriteLine();

			Console.WriteLine("Removing values: ");
			stack.Pop();
			stack.Pop();
			stack.Pop();

			Console.WriteLine("Current stack: ");
			foreach (char c in stack) {
				Console.Write(c + " ");
			}
		}
	}
}
