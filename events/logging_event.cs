using System;
using System.IO;

namespace BoilerEventApplication {
	
	// boiler class
	class Boiler {
		
		private int temp;
		private int pressure;

		public Boiler(int temp, int pressure) {
			this.temp = temp;
			this.pressure = pressure;
		}

		public int getTemp() {
			return temp;
		}
		public int getPressure() {
			return pressure;
		}
	}

	// event publisher
	class DelegateBoilerEvent {
		
		public delegate void BoilerLogHandler(String status);

		// defining event based on the above delegate
		public event BoilerLogHandler BoilerEventLog;

		public void LogProcess() {
			String remarks = "O.K.";
			Boiler b = new Boiler(100, 12);

			int t = b.getTemp();
			int p = b.getPressure();

			if(t > 150 || t < 80 || p < 12 || p > 15) {
				remarks = "Need Maintenance";
			}

			OnBoilerEventLog("Logging Info:\n");
			OnBoilerEventLog("Temperature: " + t + "\nPressure: " + p);
			OnBoilerEventLog("\nMessage: " + remarks);
		}

		protected void OnBoilerEventLog(String message) {
			if (BoilerEventLog != null) {
				BoilerEventLog(message);
			}
		}
	}

	// this class keps a provision for writing into the log file

	class BoilerInfoLogger {
		FileStream fs;
		StreamWriter sw;

		public BoilerInfoLogger(String filename) {
			fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
			sw = new StreamWriter(fs);
		}

		public void Logger(String info) {
			sw.WriteLine(info);
		}
		public void Close() {
			sw.Close();
			fs.Close();
		}
	}

	// the event subscriber
	public class RecordBoilerInfo {
		
		public static void Logger(String info) {	
			Console.WriteLine(info);
		}

		public static void Main(String[] args) {
			BoilerInfoLogger fileLog = new BoilerInfoLogger("boiler.txt");
			DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();

			boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(Logger);
			boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(fileLog.Logger);
			boilerEvent.LogProcess();
			Console.ReadLine();
			fileLog.Close();
		}
	}
}
