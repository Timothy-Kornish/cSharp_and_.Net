using System;

namespace BitwiseOperators {
	class Program {
		static void Main(String[] args) {
			int a = 60;    /* 60 = 0011 1100 */
			int b = 13;    /* 13 = 0000 1101 */
			int c = 0;

			c =  a & b;    /* 0000 1100 = 12 */
			Console.WriteLine("Line 1 - Value of c = a & b is {0}", c);

			c = a | b;     /* 0011 1101 = 61 */
			Console.WriteLine("Line 2 - Value of c = a | b is {0}", c);

			c = a ^ b;     /* 0011 0001 = 49 */ // counts 1 bits where only one variable has 1 bit
			Console.WriteLine("Line 3 - Value of c = a ^ b is {0}", c);

			c = ~a;        /* 1100 0011 = -61 */ // flipping bits with sign flip
			Console.WriteLine("Line 4 - value of c = ~a is {0}", c);

			c = a << 2;    /* 1111 0000 = 240 */ // left bitshift 2 bits
			Console.WriteLine("Line 5 - value of c = a << 2 is {0}", c);

			c = a >> 2;    /* 0000 1111 = 15 */ // right bitshift 2 bits
			Console.WriteLine("Line 6 - value of c = a >> 2 is {0}", c);
			
			Console.ReadLine();

		}
	}
}
