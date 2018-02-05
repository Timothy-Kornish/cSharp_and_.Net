using System;

namespace CommonTypeSystem {
	class CommonTypes {
		static void Main(String[] args) {		
			// Reference Types
			// Three built in types: object, dynamic, and string
		
			// objects
			// type checking happends at compile time like auto in c++
			object obj;
			obj = 100; // this is boxing
			Console.WriteLine("obj variable: {0}", obj);

			// dynamic, similar to auto in c++, which is checked at compile time
			// type is checked at runtime
			dynamic value = 100;
			dynamic dynamicString = "hello";
		
			Console.WriteLine("dynamic value: {0}", value);
			Console.WriteLine("dynamic string value: {0}", dynamicString);
		
			// string
			String str = "\"quoted string\"";
			String nextStr = @"@quoted string";
			
			Console.WriteLine("Quoted string: {0}", str);
			Console.WriteLine("@Quoted string: {0}", nextStr);
			
			// Pointer Types
			// pointer types store memory address of another type

			// type* identifier;
			// char* charPtr;
			// int* intPtr;
		}
	}
}
