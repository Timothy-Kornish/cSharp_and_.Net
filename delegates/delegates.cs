using System;

delegate int NumberChanger(int n);

namespace DelegateApplication {
	class TestDelegate {
		static int num = 10;
		public static int AddNum(int p) {
			num += p;
			return num;
		}

		public static int MultNum(int q) {
			num *= q;
			return num;
		}

		public static int GetNum() {
			return num;
		}

		public static void Main() {
			NumberChanger nc1 = new NumberChanger(AddNum);
			NumberChanger nc2 = new NumberChanger(MultNum);


			// calling methods using the delegate objects

			nc1(25);
			Console.WriteLine("Value of num: {0}", GetNum());

			nc2(5);
			Console.WriteLine("Value of num: {0}", GetNum());

			Console.ReadKey();
		}
	}
}
