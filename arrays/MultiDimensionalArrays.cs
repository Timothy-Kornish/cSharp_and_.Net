using System;

namespace ArrayApplication {
	class MyArray {
		static void Main(String[] args) {
			/* creating array with 5 rows and 2 columns */
			int[,] arr = new int[5, 2] {{0,0}, {1,2}, {2,4}, {3,6}, {4,8}};

			int i, j;

			/* output each array element's value */

			for (i = 0; i < 5; i++) {
				for (j = 0; j < 2; j++) {
					Console.WriteLine("a[{0},{1}] = {2}", i, j, arr[i,j]);
				}
			}
			Console.ReadKey();
		}
	}
}
