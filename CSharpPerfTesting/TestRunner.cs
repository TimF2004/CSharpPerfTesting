﻿using System;
using System.Diagnostics;

namespace CSharpPerfTesting
{
    public class TestRunner
    {
		public void RunBitWiseTest(int iterations)
		{
			byte[] srcBytes = getDoubleAsBytes();

			Stopwatch sw = Stopwatch.StartNew();
			for(int i = 0; i < iterations; i++) {
				BitConverter.ToDouble(srcBytes, 0);
			}
			sw.Stop();
			Console.WriteLine(sw.Elapsed.Milliseconds);

			sw = Stopwatch.StartNew();
			for (int i = 0; i < iterations; i++) {
				BitWise.ToDouble(srcBytes, 0);
			}
			sw.Stop();
			Console.WriteLine(sw.Elapsed.Milliseconds);

		}

		private byte[] getDoubleAsBytes() {
			byte[] data = new byte[8];
			Buffer.BlockCopy(BitConverter.GetBytes(1234.1234), 0, data, 0, 8);

			return data;
		}
	}
}
