#define DEBUG
#define VC_V10

using System;

public class TestClass {
	public static void Main(String[] args) {
		#if (DEBUG && !VC_V10) 
			Console.WriteLine("only Debug is defined");
		#elif (!DEBUG && VC_V10) 
			Console.WriteLine("Only VC_V10 is defined");
		#elif (DEBUG && VC_V10)
			Console.WriteLine("DEBUG and VC_V10 are both defined");
		#else
			Console.WriteLine("DEBUG AND VC_V10 are both undefined");
		#endif
		Console.ReadKey();
	}
}
