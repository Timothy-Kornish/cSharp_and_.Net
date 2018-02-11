using System;

namespace SimpleEvent {
	
	public class EventTest {
		
		private int value;
		
		// creating a delegate
		public delegate void NumManipulatorHandler();
		
		// creating an event
		public event NumManipulatorHandler ChangeNum;

		protected virtual void OnNumChanged() {
			if (ChangeNum != null) {
				ChangeNum();
			} else {
				Console.WriteLine("Event Fired");
			}
		}

		public void SetValue(int n) {
			if (value != n) {
				value = n;
				OnNumChanged();
			}
		}
					
		public EventTest(int n) {
			SetValue(n);
		}
	}

	public class MainClass {
		public static void Main(String[] args) {
			EventTest e = new EventTest(5);
			e.SetValue(7);
			e.SetValue(11);

			Console.ReadKey();
		}
	}
}
