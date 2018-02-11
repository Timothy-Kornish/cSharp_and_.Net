using System;
using System.Collections;

namespace CollectionsApplication {
	class Program {
		public static void Main(String[] args) {
			SortedList sl = new SortedList();

			sl.Add("001", "Zara");
			sl.Add("002", "Abida");
			sl.Add("003", "Joe");
			sl.Add("004", "Mausam");
			sl.Add("005", "Amlan");
			sl.Add("006", "Arif");
			sl.Add("007", "Saikia");

			if (sl.ContainsValue("Nuha")) {
				Console.WriteLine("Nuha is already registered as a student");
			} else {
				sl.Add("008", "Nuha");
			}

			ICollection key = sl.Keys;

			foreach (String k in key) {
				Console.WriteLine(k + ": " + sl[k]);
			}
			Console.WriteLine();

			for (int i = 0; i < sl.Count; i++) {
				Console.WriteLine(sl.GetByIndex(i));
			}
			Console.ReadKey();
		}
	}
}
