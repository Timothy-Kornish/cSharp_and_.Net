#define DEBUG

using System;
using System.Diagnostics;

public class Myclass {
	[Conditional("DEBUG")]
	public static void Message(String msg) {
		Console.WriteLine(msg);
	}
}

class Test {
	static void function1() {
		Myclass.Message("In Function 1");
		function2();
	}
	static void function2() {
		Myclass.Message("In function 2");
	}
	public static void Main(String[] args) {
		Myclass.Message("In Main function.");
		function1();
		Console.ReadKey();
	}
}
