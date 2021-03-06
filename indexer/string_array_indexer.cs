using System;

namespace IndexerApplication {
	class IndexedNames {
		
		public static int size = 10;
		private String[] namelist = new String[size];
		
		public IndexedNames() {
			for (int i = 0; i < size; i++) {
				namelist[i] = "N.A.";
			}
		}

		public String this[int index] {
			get {
				String tmp;
				if (index >= 0 && index <= size -1) {	
					tmp = namelist[index];
				} else {
					tmp = "";
				}

				return (tmp);
			}
			set {
				if (index >= 0 && index <= size -1) {
					namelist[index] = value;
				}
			}
		}
	}

	class TestIndex {
		public static void Main(String[] args) {
			IndexedNames names = new IndexedNames();

			names[0] = "Zara";
			names[1] = "Riz";
			names[2] = "Nuha";
			names[3] = "Asif";
			names[4] = "Davinder";
			names[5] = "Sunil";
			names[6] = "Rubin";

			for (int i = 0; i < IndexedNames.size; i++) {
				Console.WriteLine(names[i]);
			}
			Console.ReadKey();
		}
	}
}				
