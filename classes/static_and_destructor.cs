using System;

namespace StaticVarApplication {
	class StaticVar {
		public static int num;

		public StaticVar() {
			Console.WriteLine("Inside Constructor");
		}
		
		~StaticVar() {
			Console.WriteLine("Inside Destructor");
		}

		public void count() {
			num++;
		}
		public int getNum() {
			return num;
		}
	}

	class StaticTester {
		public static void Main(String[] args) {
			StaticVar s1 = new StaticVar();
			StaticVar s2 = new StaticVar();

			s1.count();
			s1.count();
			s1.count();
			s1.count();
			s1.count();
			s1.count();
			s1.count();
			s1.count();

			Console.WriteLine("Variable num for s1: {0}", s1.getNum());
			Console.WriteLine("Variable num for s2: {0}", s2.getNum());
			Console.ReadKey();
		}
	}
}
