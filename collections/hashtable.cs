using System;
using System.Collections;

namespace CollectionsApplication {
	class Program {
		public static void Main(String[] args) {
			Hashtable ht = new Hashtable();
			ht.Add("first", "Zara");
			ht.Add("second", "Abida");
			ht.Add("third", "Rehman");
			ht.Add("fourth", "Mausam");
			ht.Add("fifth", "Amlan");
			ht.Add("sixth", "Arif");
			ht.Add("seventh", "Ruben");
			ht.Add("eigth", "Ritesh");
			ht.Add("nineth", "Saikia");
			
			if (ht.ContainsValue("Nuha")) {
				Console.WriteLine("Student Nuha is already in the list");
			} else {
				ht.Add("tenth", "Nuha");
			}

			Console.WriteLine("Seventh student: " + ht["seventh"]);

			ICollection key = ht.Keys;

			foreach (String k in key) {
				Console.WriteLine(k + ": " + ht[k]);
			}

			Console.ReadKey();
		}
	}
}
