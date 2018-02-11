using System;
using System.IO;

namespace DelegateApplication {
	class PrintString {
		
		static FileStream fs;
		static StreamWriter sw;
		
		// delegate declaration
		public delegate void printString(String s);

		// this method prints to the console
		public static void WriteToScreen(String s) {
			Console.WriteLine("The String is: {0}", s);
		}

		// this method prints to a file
		public static void WriteToFile(String s) {
			fs = new FileStream("message.txt", FileMode.Append, FileAccess.Write);
			sw = new StreamWriter(fs);
			sw.WriteLine(s);
			sw.Flush();
			sw.Close();
			fs.Close();
		}

		// this method takes the delegate as parameter and uses it to
		// call the methods as required

		public static void sendString(printString ps) {
			ps("Hello World");
		}

		public static void Main(String[] args) {	
			printString ps1 = new printString(WriteToScreen);
			printString ps2 = new printString(WriteToFile);

			sendString(ps1);
			sendString(ps2);

			Console.ReadKey();
		}
	}
}
