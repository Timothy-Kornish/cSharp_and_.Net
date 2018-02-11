using System;
using System.Collections;

namespace CollectionsApplication {
	class Program {
		public static void Main(String[] args) {
			
			// creating two bit arrays of size 8
			BitArray ba1 = new BitArray(8);
			BitArray ba2 = new BitArray(8);

			byte[] a = {60};
			byte[] b = {13};

			ba1 = new BitArray(a);
			ba2 = new BitArray(b);

			Console.WriteLine("Bit Array ba1: 60");
			for (int i = 0; i < ba1.Count; i++) {
				Console.Write("{0, -6} ", ba1[i]);
			}

			Console.WriteLine();

			Console.WriteLine("Bit Array ba1: 60");
                        for (int i = 0; i < ba1.Count; i++) {
                                Console.Write("{0, -6} ", ba1[i]);
                        }       
                        Console.WriteLine();
			
			BitArray ba3 = new BitArray(8);
			ba3 = ba1.And(ba2);

			Console.WriteLine("Bit Array ba3 after AND operation: 12");
			for (int i = 0; i < ba3.Count; i++) {
				Console.Write("{0, -6} ", ba3[i]);
			}
			Console.WriteLine();

			ba3 = ba1.Or(ba2);

			Console.WriteLine("Bit Array ba3 after OR opertaion: 61");
			for (int i = 0; i < ba3.Count; i++) {
				Console.Write("{0, -6} ", ba3[i]);
			}
			Console.WriteLine();
			
			Console.ReadKey();
		}
	}
}
