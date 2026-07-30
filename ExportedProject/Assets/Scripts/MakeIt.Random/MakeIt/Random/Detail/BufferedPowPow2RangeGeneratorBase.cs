namespace MakeIt.Random.Detail
{
	public class BufferedPowPow2RangeGeneratorBase
	{
		private IRandom _random;

		private int _bitCountPerGroup;

		private ulong _bitMask;

		private ulong _bits;

		public BufferedPowPow2RangeGeneratorBase(IRandom random, int bitCount, ulong bitMask)
		{
		}

		protected ulong Next32()
		{
			return 0uL;
		}

		protected ulong Next64()
		{
			return 0uL;
		}
	}
}
