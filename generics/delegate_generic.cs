using System;
using System.Collections.Generic;

delegate T NumberChanger<T>(T n);

namespace GenericDelegateApplication {
	class TestDelegate {
		
		static int num = 10;

		public static int AddNum(int n) {
			num += n;
			return num;
		}

		public static int MultNum(int n) {
			num *= n;
			return num;
		}

		public static int GetNum() {
			return num;
		}

		public static void Main(String[] args) {
			
			NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
			NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

			nc1(25);

			Console.WriteLine("Value of num: {0}", GetNum());

			nc2(5);

			Console.WriteLine("Value of num: {0}", GetNum());

			Console.ReadKey();
		}
	}
}
