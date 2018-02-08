using System;

namespace ArrayApplication {
	class MyArray {
		static void Main(String[] args) {
			int[] nums = new int[10];

			for(int i = 0; i < nums.Length; i++ ) {
				nums[i] = i + 100;
			}

			foreach(int j in nums) {
				int i = j - 100;
				Console.WriteLine("Element[{0}] = {1}", i, j);
				i++;
			}
			Console.ReadKey();
		}
	}
}
