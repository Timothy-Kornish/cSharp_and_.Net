using System;
using System.Threading;

namespace MultithreadingApplication {
	class MainThreadProgram {
		public static void Main(String[] args) {
			Thread th = Thread.CurrentThread;
			th.Name = "MainThread";

			Console.WriteLine("This is {0}", th.Name);
			Console.ReadKey();
		}
	}
}
