using System;

delegate void NumberChanger(int n);

namespace DelegateApplication {
	class TestDelegate {
		
		static int num = 10;

		public static void AddNum(int n) {
			num += n;
			Console.WriteLine("AddNum Method: {0}", num);
		}

		public static void MultNum(int n) {
			num *= n;
			Console.WriteLine("MultNum Method: {0}", num);
		}

		public static int getNum() {
			return num;
		}

		static void Main(String[] args) {
			NumberChanger nc = delegate(int x) {
				Console.WriteLine("Anonymous Method: {0}", x);
			};

			nc(10);

			nc = new NumberChanger(AddNum);

			nc(5);

			nc = new NumberChanger(MultNum);

			nc(2);

			Console.ReadKey();
		}
	}
}
