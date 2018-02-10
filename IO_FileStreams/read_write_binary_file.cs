using System;
using System.IO;

namespace BinaryFileApplication {
	class Program {
		static void Main(String[] args) {
			BinaryWriter bw;
			BinaryReader br;

			int i = 25;
			double pi = 3.14159;
			bool b = true;
			String str = "Happy Gilmore";

			// create the file
			try {
				bw = new BinaryWriter(new FileStream("mydata", FileMode.Create));
			} catch (IOException e) {
				Console.WriteLine(e.Message + "\n Cannot create file.");
				return;
			}

			// writing into file

			try {
				bw.Write(i);
				bw.Write(pi);
				bw.Write(b);
				bw.Write(str);
			} catch (IOException e) {
				Console.WriteLine(e.Message + "\n Cannot write to file.");
				return;
			}

			bw.Close();

			// opening the file
			try {
				br = new BinaryReader(new FileStream("mydata", FileMode.Open));
			} catch (IOException e) {
				Console.WriteLine(e.Message + "\n Cannot open file.");
				return;
			}

			// reading the file
			try {
				int i_read = br.ReadInt32();
				Console.WriteLine("Integer data: {0}", i_read);

				double pi_read = br.ReadDouble();
				Console.WriteLine("Double data: {0}", pi_read);

				bool b_read = br.ReadBoolean();
				Console.WriteLine("Boolean data: {0}", b_read);

				String str_read = br.ReadString();
				Console.WriteLine("String data: {0}", str_read);

			} catch (IOException e) {
				Console.WriteLine(e.Message + "\n Cannot read from file.");
				return;
			}
			br.Close();
			Console.ReadKey();
		}
	}
}			
