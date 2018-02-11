using System;
using System.Threading;

namespace MultithreadingApplication {
	class ThreadCreationProgram {
		public static void CallToChildThread() {
			Console.WriteLine("Child Thread starts");

			int sleepfor = 5000; // milliseconds
			Console.WriteLine("Child Thread paused for {0} seconds", sleepfor/1000);
			Thread.Sleep(sleepfor);
			Console.WriteLine("Child thread resumes");
		}

		public static void Main(String[] args) {
			ThreadStart childref = new ThreadStart(CallToChildThread);
			Console.WriteLine("In Main: Creating the Child thread");

			Thread childThread = new Thread(childref);

			childThread.Start();
			Console.ReadKey();
		}
	}
}
