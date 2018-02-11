using System;

delegate int NumberChanger(int n);

namespace DelegateApplication {
	
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

		public static void Main() {
			NumberChanger nc;
			NumberChanger nc1 = new NumberChanger(AddNum);
			NumberChanger nc2 = new NumberChanger(MultNum);
			
			// multiple delegates, in order will add by number then multiply by number
			nc = nc1;
			nc += nc2;
			
			nc(5);
			Console.WriteLine("Value of NUm: {0}", GetNum());
			Console.ReadKey();
		}
	}
}
