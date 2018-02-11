using System;
using System.Collections.Generic;

namespace GenericApplication {
	public class MyGenericArray<T> {
		
		private T[] array;

		public MyGenericArray(int size) {
			array = new T[size + 1];
		}

		public T getItem(int index) {
			return array[index];
		}

		public void setItem(int index, T value) {
			array[index] = value;
		}
	}

	class Tester {
		
		public static void Main(String[] args) {
			
			MyGenericArray<int> intArray = new MyGenericArray<int>(5);

			for (int i = 0; i < 5; i++) {
				intArray.setItem(i, i*5);
			}

			for (int i = 0; i < 5; i++) {
				Console.Write(intArray.getItem(i) + " ");
			}

			Console.WriteLine();

			MyGenericArray<char> charArray = new MyGenericArray<char>(5);

			for (int i = 0; i < 5; i++) {
				charArray.setItem(i, (char)(i+97));
			}

			for (int i = 0; i < 5; i++) {
				Console.Write(charArray.getItem(i) + " ");
			}

			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
