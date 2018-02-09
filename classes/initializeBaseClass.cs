using System;

namespace RectangleApplication {
	class Rectangle {
		
		// member variables

		protected double length;
		protected double width;

		public Rectangle(double length, double width) {
			this.length = length;
			this.width = width;
		}

		public double getArea() {
			return length * width;
		}

		public void display() {
			Console.WriteLine("Length: {0}", length);
			Console.WriteLine("Width: {0}", width);
			Console.WriteLine("Area: {0}", getArea());
		}
	}

	class Tabletop : Rectangle {
		
		private double cost;
		
		// initializing Rectangle constructor with base keyword

		public Tabletop(double l, double w) : base(l, w) {}
		
		public double getCost() {
			cost = getArea() * 70;
			return cost;
		}

		public void display() {
			base.display();
			Console.WriteLine("Cost: {0}", getCost());
		}
	}

	class ExecuteRectangle {
		public static void Main(String[] args) {
			Tabletop table = new Tabletop(4.5, 7.5);
			table.display();
			Console.ReadKey();
		}
	}
}

