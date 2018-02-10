using System;

public class Myclass {
	
	// first parameter is message, second tells compiler to emit error if true, warning if false	
	[Obsolete("Don't use OldMethod, use NewMethod instead", true)]
	static void OldMethod() {
		Console.WriteLine("It is the old method");
	}

	static void NewMethod() {
		Console.WriteLine("It is the new method");
	}
	
	public static void Main() {
		OldMethod();
	}
}

