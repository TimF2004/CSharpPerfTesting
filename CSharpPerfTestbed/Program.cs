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
				TestRunner tr = new TestRunner();
				tr.RunBitWiseTest(1000000000);

			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
				Console.WriteLine();
			} finally {
				Console.WriteLine("Press any key to exit.");
				Console.ReadKey();
			}
		}
	}
}
