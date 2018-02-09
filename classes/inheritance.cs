using System;

namespace InheritanceApplication {
	public class Shape {

		protected int width;
		protected int height;
	
		public void setWidth(int w) {
			width = w;
		}
		
		public void setHeight(int h) {
			height = h;
		}
	}

	// Derived class

	// Rectangle class inherets shape, rectangle extends shape (java syntax)

	public class Rectangle : Shape {
		public int getArea() {
			return (width * height);
		}
	}

	class RectangleTester {
		public static void Main(String[] args) 	{
			Rectangle Rect = new Rectangle();
			Rect.setWidth(5);
			Rect.setHeight(7);

			// Print the area of the rectangle
			Console.WriteLine("Total area: {0}", Rect.getArea());
			Console.ReadKey();
		}
	}
}
