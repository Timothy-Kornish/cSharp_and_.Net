using System;

namespace PolymorphismApplication {
	class Shape {
		protected int width, height;

		public Shape(int width = 0, int height = 0) {
			this.width = width;
			this.height = height;
		}

		public virtual int area() {
			Console.WriteLine("Parent class area:");
			return 0;
		}
	}

	class Rectangle : Shape {
		public Rectangle(int width = 0, int height = 0) : base(width, height) {}

		public override int area() {
			Console.WriteLine("Rectangle class Area:");
			return width * height;
		}
	}

	class Triangle : Shape {
		public Triangle(int width = 0, int height = 0) : base (width, height) {}

		public override int area() {
			Console.WriteLine("Triangle class area:");
			return (width * height / 2);
		}
	}

	class Caller {
		public void CallArea(Shape sh) {
			int area = sh.area();
			Console.WriteLine("Area: {0}", area);
		}
	}

	class Tester {
		public static void Main(String[] args) {
			Caller c = new Caller();
			Rectangle r = new Rectangle(10,7);
			Triangle t = new Triangle(10,5);

			c.CallArea(r);
			c.CallArea(t);
			Console.ReadKey();
		}
	}
}
