using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESRIReader.Utilities {

	static public class Extensions {
	
		public static int SwapBytes(this int value)
		{
			return (int)SwapBytes((uint)value);
		}

		public static uint SwapBytes(this uint value)
		{
			uint swapped = (value & 0x000000FFU) << 24
							| (value & 0x0000FF00U) << 8
							| (value & 0x00FF0000U) >> 8
							| (value & 0xFF000000U) >> 24;
			return swapped;
		}

		public static long SwapBytes(this long value)
		{
			return (long)SwapBytes((ulong)value);
		}

		public static ulong SwapBytes(this ulong value)
		{
			ulong swapped = ((0x00000000000000FF) & (value >> 56)
							 | (0x000000000000FF00) & (value >> 40)
							 | (0x0000000000FF0000) & (value >> 24)
							 | (0x00000000FF000000) & (value >> 8)
							 | (0x000000FF00000000) & (value << 8)
							 | (0x0000FF0000000000) & (value << 24)
							 | (0x00FF000000000000) & (value << 40)
							 | (0xFF00000000000000) & (value << 56));
			return swapped;
		}

		/*
		public static int SwapBytes(this int val)
		{
			return (val & 0x000000FF) << 24
					| (val & 0x0000FF00) << 8
					| (val & 0x00FF0000) >> 8
					| ((int)(val & 0xFF000000)) >> 24;
		}
		
		public static short SwapBytes(this short number) {
			byte[] data = BitWise.GetBytes(number);
			Array.Reverse(data);

			return BitConverter.ToInt16(data, 0);
		}
		
		public static long SwapBytes(this long number) {
			byte[] data = BitWise.GetBytes(number);
			Array.Reverse(data);

			return BitConverter.ToInt64(data, 0);
		} 

		public static double SwapBytes(this double number) {
			byte[] data = BitWise.GetBytes(number);
			Array.Reverse(data);

			return BitWise.ToDouble(data, 0);
		} 
		
		public static short GetRangeAsShort(this byte[] data, int skip, int take, bool swapBytes) {
			short retVal = BitWise.ToInt16(data.Skip(skip).Take(take).ToArray(),0);
			return (swapBytes ? retVal.SwapBytes() : retVal);
		}

		public static int GetRangeAsInt(this byte[] data, int skip, int take, bool swapBytes=false) {
			int retVal = BitWise.ToInt32(data.Skip(skip).Take(take).ToArray(),0);
			return (swapBytes ? retVal.SwapBytes() : retVal);
		}
		
		public static long GetRangeAsLong(this byte[] data, int skip, int take, bool swapBytes=false) {
			long retVal = BitWise.ToInt64(data.Skip(skip).Take(take).ToArray(),0);
			return (swapBytes ? retVal.SwapBytes() : retVal);
		}

		public static double GetRangeAsDouble(this byte[] data, int skip, int take, bool swapBytes=false) {
			double retVal = BitWise.ToDouble(data.Skip(skip).Take(take).ToArray(),0);
			return (swapBytes ? retVal.SwapBytes() : retVal);
		}
		*/
	}
}
