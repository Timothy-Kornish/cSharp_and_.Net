using System;

namespace UnsafeCodeApplication {
	class SwapPointer {
		public unsafe void swap(int* p, int* q) {
			int temp = *p;
			*p = *q;
			*q = temp;
		}
	}

	class TestPointer { 
		public unsafe static void Main() {
			SwapPointer p = new SwapPointer();

			int var1 = 10;
			int var2 = 20;

			int* x = &var1;
			int* y = &var2;

			Console.WriteLine("Before swap: var1:{0}, var2:{1}", var1, var2);

			p.swap(x,y);

			Console.WriteLine("After swap: var1:{0}, var2:{1}", var1, var2);
			Console.ReadKey();
		}
	}
}
