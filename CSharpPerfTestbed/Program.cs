using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPerfTesting;

namespace CSharpPerfTestbed {
	class Program {
		static void Main(string[] args)
		{
			try {
				//	TestRunner tr = new TestRunner();
				//	tr.RunSwapTest(10000000);

				ShiftResearch();

			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
				Console.WriteLine();
			} finally {
				Console.WriteLine("Press any key to exit.");
				Console.ReadKey();
			}
		}

		static void ShiftResearch()
		{
			int value = -123456789;

			Console.WriteLine("{0} | {1} | {2}", value, value.SwapBytes(), value.SwapBytes().SwapBytes());
			Console.WriteLine("{0:x8}", value);
	//		Console.WriteLine("{0:x8}", (value & 0x000000ffU));
	//		Console.WriteLine("{0:x8}", (value & 0x0000ff00U));
	//		Console.WriteLine("{0:x8}", (value & 0x00ff0000U));
	//		Console.WriteLine("{0:x8}", (value & 0xff000000U));
			Console.WriteLine("{0:x8}", (value & 0x000000ffU) << 24);
			Console.WriteLine("{0:x8}", (value & 0x0000ff00U) << 8);
			Console.WriteLine("{0:x8}", (value & 0x00ff0000U) >> 8);
			Console.WriteLine("{0:x8}", (value & 0xff000000U) >> 24);

			Console.WriteLine("{0:x8}", (value & 0x000000ffU) << 24 | (value & 0x0000ff00U) << 8 | (value & 0x00ff0000U) >> 8 | (value & 0xff000000U) >> 24);

			ulong x = 123456789123456789;

			Console.WriteLine("{0} | {1} | {2}", x, x.SwapBytes(), x.SwapBytes().SwapBytes());
			Console.WriteLine("{0:x16}", x);

			Console.WriteLine("{0:x16}", (x & 0x00000000000000ffU) << 56);
			Console.WriteLine("{0:x16}", (x & 0x000000000000ff00U) << 40);
			Console.WriteLine("{0:x16}", (x & 0x0000000000ff0000U) << 24);
			Console.WriteLine("{0:x16}", (x & 0x00000000ff000000U) << 8);
			Console.WriteLine("{0:x16}", (x & 0x000000ff00000000U) >> 8);
			Console.WriteLine("{0:x16}", (x & 0x0000ff0000000000U) >> 24);
			Console.WriteLine("{0:x16}", (x & 0x00ff000000000000U) >> 40);
			Console.WriteLine("{0:x16}", (x & 0xff00000000000000U) >> 56);

			ushort s = 1234;
			Console.WriteLine("{0:x4}", s);
			Console.WriteLine("{0:x4}", (s & 0x00ffU));
			Console.WriteLine("{0:x4}", (s & 0x00ffU) << 8);
			Console.WriteLine("{0:x4}", (s & 0xff00U) >> 8);

			//	uint swapped = (value & 0x000000FFU) << 24
			//						| (value & 0x0000FF00U) << 8
			//						| (value & 0x00FF0000U) >> 8
			//						| (value & 0xFF000000U) >> 24;
		}
	}
}
