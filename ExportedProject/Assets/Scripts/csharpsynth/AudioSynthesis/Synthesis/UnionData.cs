using System.Runtime.InteropServices;

namespace AudioSynthesis.Synthesis
{
	[StructLayout((LayoutKind)2)]
	public struct UnionData
	{
		[FieldOffset(0)]
		public double double1;

		[FieldOffset(0)]
		public float float1;

		[FieldOffset(4)]
		public float float2;

		[FieldOffset(0)]
		public int int1;

		[FieldOffset(4)]
		public int int2;
	}
}
