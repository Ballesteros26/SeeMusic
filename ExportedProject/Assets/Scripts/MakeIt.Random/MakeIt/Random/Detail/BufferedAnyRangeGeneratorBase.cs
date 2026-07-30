namespace MakeIt.Random.Detail
{
	public class BufferedAnyRangeGeneratorBase
	{
		private IRandom _random;

		private ulong _rangeMax;

		private int _bitCountPerGroup;

		private int _excessBitsPer64Bits;

		private ulong _bitMask;

		private ulong _bits;

		public BufferedAnyRangeGeneratorBase(IRandom random, ulong rangeMax, ulong bitMask)
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
