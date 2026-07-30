using System.Runtime.InteropServices;

namespace MakeIt.Random.Detail
{
	public static class FloatingPoint
	{
		[StructLayout((LayoutKind)2)]
		public struct BitwiseFloat
		{
			[FieldOffset(0)]
			public uint bits;

			[FieldOffset(0)]
			public float number;
		}

		[StructLayout((LayoutKind)2)]
		public struct BitwiseDouble
		{
			[FieldOffset(0)]
			public ulong bits;

			[FieldOffset(0)]
			public double number;
		}

		public static readonly uint[] fastSqrtUpper;

		public static readonly uint[] fastSqrtLower;
	}
}
