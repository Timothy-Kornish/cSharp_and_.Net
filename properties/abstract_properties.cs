using System;

namespace AbstractProperties {
	
	public abstract class Person {
		public abstract String Name {
			get;
			set;
		}
		public abstract int Age {
			get;
			set;
		}
	}

	class Student : Person {
		
		private String code = "NA";
		private String name = "NA";
		private int age = 0;
		
		public String Code {
			get {
				return code;
			}
			set {
				code = value;
			}
		}

		public override String Name {
			get {
				return name;
			}
			set {
				name = value;
			}
		}
		public override int Age {
			get {
				return age;
			}
			set {
				age = value;
			}
		}

		public override String ToString() {
			return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
		}
	}

	class AbstractExample {
		
		public static void Main() {
			Student s = new Student();

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
