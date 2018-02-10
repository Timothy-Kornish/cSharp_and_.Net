using System;
using System.IO;

namespace FileApplication {
	class Program {
		static void Main(String[] args) {
			
			try {
				// Create an instance of StreamReader to read from a file.
				// The using statement also closes the StreamReader

				using (StreamReader sr = new StreamReader("Jamaica.txt")) {
					String line;

					// Read and display lines from the file until
					// the end of the file is reached

					while ((line = sr.ReadLine()) != null) {
						Console.WriteLine(line);
					}
				}
			} catch (Exception e) {
				// let the user know what went wrong
				Console.WriteLine("The file could not be read: \n" + e.Message);
			}
			Console.ReadKey();
		}
	}
}
