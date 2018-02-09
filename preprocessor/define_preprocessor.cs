#define PI

using System;

namespace PreprocessorDApplication {
	class Program {
		public static void Main(String[] args) {
			#if (PI)
				Console.WriteLine("PI is defined");
			#else
				Console.WriteLine("PI is not defined");
			#endif
			Console.ReadKey();
		}
	}
}
