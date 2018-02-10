using System;

namespace UserDefinedException {
	
	public class Temperature {
		int temperature = 0;

		public void showTemp() {
			if(temperature == 0) {
				throw(new TempIsZeroException("Zero Temperature Found"));
			} else {
				Console.WriteLine("Temperature: " + temperature);
			}
		}
	}

	public class TempIsZeroException : ApplicationException {
		public TempIsZeroException(String message) : base(message) {}
	}

	class TestTemperature {
		static void Main(String[] args) {
			Temperature temp = new Temperature();

			try {
				temp.showTemp();
			} catch(TempIsZeroException e) {
				Console.WriteLine("TempIsZeroException: " + e.Message);
			}

			Console.ReadKey();
		}
	}
}
