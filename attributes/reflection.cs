using System;

[AttributeUsage(AttributeTargets.All)]
public class HelpAttribute : System.Attribute {
	
	public readonly String url;
	private String topic;

	public String Topic {
		get {
			return topic;
		}
		set {
			topic = value;
		}
	}

	public HelpAttribute(String url) {
		this.url = url;
	}
}

[HelpAttribute("information on the class MyClass")]
class MyClass {}

namespace AttributeApplication {
	class Program {
		public static void Main() {
			System.Reflection.MemberInfo info = typeof(MyClass);
			object[] attributes = info.GetCustomAttributes(true);

			for (int i = 0; i < attributes.Length; i++) {
				System.Console.WriteLine(attributes[i]);
			}
			Console.ReadKey();
		}
	}
}
