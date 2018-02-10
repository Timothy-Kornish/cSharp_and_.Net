using System;
using System.IO;

namespace FileIOApplication {
	class Program {
		static void Main(String[] args) {
			FileStream stream = new FileStream("test.data", FileMode.OpenOrCreate, FileAccess.ReadWrite);

			for (int i = 1; i <= 20; i++) {
				stream.WriteByte((byte)i);
			}

			stream.Position = 0;

			for (int i = 0; i <=20; i++) {
				Console.Write(stream.ReadByte() + " ");
			}

			stream.Close();
			Console.ReadKey();
		}
	}
}
