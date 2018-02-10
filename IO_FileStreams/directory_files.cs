using System;
using System.IO;

namespace WindowsFileApplication {
	class Program {
		static void Main(String[] args) {
			
			// create a DirectoryInfo object
			DirectoryInfo mydir = new DirectoryInfo(@"/Users/TimmehK/cSharp_and_.Net/IO_FileStreams");

			// getting the files in the directory, their names and size
			FileInfo[] f = mydir.GetFiles();

			foreach (FileInfo file in f) {
				Console.WriteLine("File Name: {0}\n Size: {1}", file.Name, file.Length);
			}

			Console.ReadKey();
		}
	}
}
