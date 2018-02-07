using System;

namespace InternalEncapsulation {
	class Rectangle {
		// member variables

		internal double length;
		internal double width;

		double getArea() {
			return length * width;
		}

		public void display() {
			Console.WriteLine("Length: {0}",length);
			Console.WriteLine("Width: {0}", width);
			Console.WriteLine("Area: {0}", getArea());
		}

	}

	class ExecuteRectangle {
		public static void Main(String[] args) {
			Rectangle r = new Rectangle();
			r.length = 4.5;
			r.width = 3.5;
			r.display();
			Console.ReadLine();
		}
	}
}
