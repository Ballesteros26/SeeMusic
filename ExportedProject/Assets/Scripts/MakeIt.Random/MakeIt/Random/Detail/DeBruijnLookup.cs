namespace MakeIt.Random.Detail
{
	public static class DeBruijnLookup
	{
		public static readonly byte[] bitCountTable32;

		public static readonly byte[] bitCountTable64;

		public static uint GetBitMaskForRangeMax(byte rangeMax)
		{
			return 0u;
		}

		public static uint GetBitMaskForRangeMax(int rangeMax)
		{
			return 0u;
		}

		public static int GetBitCountForRangeSize(int rangeSize)
		{
			return 0;
		}

		public static uint GetBitMaskForRangeMax(uint rangeMax)
		{
			return 0u;
		}

		public static int GetBitCountForRangeMax(uint rangeMax)
		{
			return 0;
		}

		public static int GetBitCountForBitMask(uint bitMask)
		{
			return 0;
		}

		public static ulong GetBitMaskForRangeMax(ulong rangeMax)
		{
			return 0uL;
		}

		public static int GetBitCountForBitMask(ulong bitMask)
		{
			return 0;
		}

		public static bool IsPowerOfTwo(byte rangeSize)
		{
			return false;
		}
	}
}
