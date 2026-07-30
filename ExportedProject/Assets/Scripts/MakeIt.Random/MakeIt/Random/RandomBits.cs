using MakeIt.Random.Detail;

namespace MakeIt.Random
{
	public static class RandomBits
	{
		private class SingleBitGenerator32 : BufferedBitGenerator, IRangeGenerator<uint>
		{
			public SingleBitGenerator32(IRandom random)
				: base(null)
			{
			}

			public uint Next()
			{
				return 0u;
			}
		}

		private class SingleBitGenerator64 : BufferedBitGenerator, IRangeGenerator<ulong>
		{
			public SingleBitGenerator64(IRandom random)
				: base(null)
			{
			}

			public ulong Next()
			{
				return 0uL;
			}
		}

		private class MultiBitPow2Generator32 : BufferedPow2RangeGeneratorBase, IRangeGenerator<uint>
		{
			public MultiBitPow2Generator32(IRandom random, int bitCount, ulong bitMask)
				: base(null, 0, 0uL)
			{
			}

			public uint Next()
			{
				return 0u;
			}
		}

		private class MultiBitPowPow2Generator32 : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<uint>
		{
			public MultiBitPowPow2Generator32(IRandom random, int bitCount, ulong bitMask)
				: base(null, 0, 0uL)
			{
			}

			public uint Next()
			{
				return 0u;
			}
		}

		private class MultiBitPow2Generator64 : BufferedPow2RangeGeneratorBase, IRangeGenerator<ulong>
		{
			public MultiBitPow2Generator64(IRandom random, int bitCount, ulong bitMask)
				: base(null, 0, 0uL)
			{
			}

			public ulong Next()
			{
				return 0uL;
			}
		}

		private class MultiBitPowPow2Generator64 : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<ulong>
		{
			public MultiBitPowPow2Generator64(IRandom random, int bitCount, ulong bitMask)
				: base(null, 0, 0uL)
			{
			}

			public ulong Next()
			{
				return 0uL;
			}
		}

		private class MultiBitGeneratorUInt64 : IRangeGenerator<ulong>
		{
			private IRandom _random;

			public MultiBitGeneratorUInt64(IRandom random)
			{
			}

			public ulong Next()
			{
				return 0uL;
			}
		}

		public static uint Bit(this IRandom random)
		{
			return 0u;
		}

		public static IRangeGenerator<uint> MakeBitGenerator(this IRandom random)
		{
			return null;
		}

		public static uint Bits32(this IRandom random)
		{
			return 0u;
		}

		public static IRangeGenerator<uint> MakeBits32Generator(this IRandom random)
		{
			return null;
		}

		public static uint Bits32(this IRandom random, int bitCount)
		{
			return 0u;
		}

		public static IRangeGenerator<uint> MakeBits32Generator(this IRandom random, int bitCount)
		{
			return null;
		}

		public static ulong Bits64(this IRandom random)
		{
			return 0uL;
		}

		public static IRangeGenerator<ulong> MakeBits64Generator(this IRandom random)
		{
			return null;
		}

		public static ulong Bits64(this IRandom random, int bitCount)
		{
			return 0uL;
		}

		public static IRangeGenerator<ulong> MakeBits64Generator(this IRandom random, int bitCount)
		{
			return null;
		}
	}
}
