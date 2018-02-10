// A custom attribute BugFix to be assigned to a class and its members
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class |
		AttributeTargets.Constructor |
		AttributeTargets.Field |
		AttributeTargets.Method |
		AttributeTargets.Property, AllowMultiple = true)]

public class DeBugInfo : System.Attribute {
	private int bugNo;
	private String developer;
	private String lastReview;
	private String message;

	public DeBugInfo(int bg, String dev, String review) {
		this.bugNo = bg;
		this.developer = dev;
		this.lastReview = review;
	}

	public int BugNo {
		get {
			return bugNo;
		}
	}

	public String Developer {
		get {
			return developer;
		}
	}

	public String LastReview {
		get {
			return lastReview;
		}
	}

	public String Message {
		get {
			return message;
		}
		set {
			message = value;
		}
	}
}

// Applying the custom attribute

[DeBugInfo(45, "Timothy Kornish", "02/09/2018", Message = "Return type mismatch")]
[DeBugInfo(49, "Other Dev.", "1/14/2018", Message = "Unused variable")]
class Rectangle {
	
	// member variables
	protected double length;
	protected double width;

	public Rectangle(double l, double w) {
		this.length = l;
		this.width = w;
	}
	
	[DeBugInfo(55, "Timothy Kornish", "12/12/2017", Message = "Return type mismatch")]
	public double getArea() {
		return length * width;
	}

	[DeBugInfo(56, "Timothy Kornish", "12/14/2017")]
	public void display() {
		Console.WriteLine("Length: {0}", length);
		Console.WriteLine("Width: {0}", width);
		Console.WriteLine("Area: {0}", getArea());
	}
}

class execute {
	public static void Main() {
		Rectangle r = new Rectangle(12, 4);
		r.display();
		
		Type type = typeof(Rectangle);
		
		// iterating through the attributes of the Rectangle class
		foreach(Object attributes in type.GetCustomAttributes(false)) {
			DeBugInfo dbi = (DeBugInfo)attributes;
			if(null != dbi) {
				Console.WriteLine("Bug Num: {0}", dbi.BugNo);
				Console.WriteLine("Developer: {0}:", dbi.Developer);
				Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
				Console.WriteLine("Remarks: {0}", dbi.Message);
			}
		}

		// iterating through the method attributes
		foreach(MethodInfo m in type.GetMethods()) {
			foreach(Attribute a in m.GetCustomAttributes(true)) {
				DeBugInfo dbi = (DeBugInfo)a;
				if(null != dbi) {
					 Console.WriteLine("Bug Num: {0}", dbi.BugNo);
				     	 Console.WriteLine("Developer: {0}:", dbi.Developer);
				         Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
				         Console.WriteLine("Remarks: {0}", dbi.Message);
				  }
			}
		}
		Console.ReadKey();
	}
}
