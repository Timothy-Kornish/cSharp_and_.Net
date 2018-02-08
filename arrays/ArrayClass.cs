using System;

namespace ArrayApplication {
	class MyArray {
		static void Main(String[] args) {
			int[] list = {34, 72, 13, 44, 25, 30, 10};
			int[] temp = list;

			Console.WriteLine("Original Array");

			foreach (int i in list) {
				Console.Write(i + " ");
			}
			Console.WriteLine();

			// Reversing the array

			Array.Reverse(temp);
			Console.WriteLine("Reversed Array");

			foreach(int i in temp) {
				Console.Write(i + " ");
			}
			Console.WriteLine();

			// sorting the array
			
			Array.Sort(temp);
			Console.WriteLine("Sorted Array");
			
			foreach(int i in temp) {
				Console.Write(i + " ");
			}
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}			
