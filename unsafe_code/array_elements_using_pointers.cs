using System;

namespace UnsafeCodeApplication {
	class TestPointer {
		public unsafe static void Main(String[] args) {
			
			int[] list = {10, 100, 1000};
			fixed(int* ptr = list)

			for (int i = 0; i < 3; i++) {
				Console.WriteLine("Address of list[{0}] = {1}", i, (int)(ptr + i));
				Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
			}
			Console.ReadKey();
		}
	}
}
