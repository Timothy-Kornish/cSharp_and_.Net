using System;

namespace InheritanceApplication{
	class Shape {
		
		protected int width;
		protected int height;

		public void setWidth(int width) {
			this.width = width;
		}

		public void setHeight(int height) {
			this.height = height;
		}
	}

	public interface PaintCost {
		int getCost(int area);
	}

	class Rectangle : Shape, PaintCost {
		
		public int getArea() {
			return width * height;
		}

		public int getCost(int area) {
			return area * 70;
		}
	}

	class RectangleTester {
		public static void Main(String[] args) {
			Rectangle rect = new Rectangle();

			int area;
			rect.setWidth(5);
			rect.setHeight(7);
			area = rect.getArea();

			Console.WriteLine("Total area: {0}", area);
			Console.WriteLine("Total paint cost: ${0}", rect.getCost(area));
			Console.ReadKey();
		}
	}
}
