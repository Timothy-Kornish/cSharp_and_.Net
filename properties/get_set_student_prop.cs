using System;

namespace StudentProperties {
	class Student {
		private String code = "N.A.";
		private String name = "not known";
		private int age = 0;

		// declare a code property of type String

		public String Code {
			get {
				return code;
			}
			set {
				code = value;
			}
		}

		// declare a Name property of type String
		public String Name {
			get {	
				return name;
			}
			set {	
				name = value;
			}
		}

		// declaring a Age property of type int
		public int Age {
			get {
				return age;
			}
			set {
				age = value;
			}
		}

		public override String ToString() {

			return "Code = " + Code + ", Name = " + ", Age = " + Age;
		}
	}

	class ExecuteStudent {
		public static void Main() {
			Student s = new Student();

			// setting code, name, and age
			s.Code = "001";
			s.Name = "Timothy";
			s.Age = 22;

			Console.WriteLine("Student Info: {0}", s);

			s.Age += 1;
			Console.WriteLine("Student Info: {0}", s);
			Console.ReadKey();
		}
	}
}
