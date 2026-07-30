using MakeIt.Random.Detail;

namespace MakeIt.Random
{
	public static class RandomRangeGenerator
	{
		private static class BufferedSByteRangeGenerator
		{
			private class AnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<sbyte>
			{
				public AnyRangeGenerator(IRandom random, uint rangeSizeMinusOne, uint bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public sbyte Next()
				{
					return 0;
				}
			}

			private class Pow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<sbyte>
			{
				public Pow2RangeGenerator(IRandom random, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public sbyte Next()
				{
					return 0;
				}
			}

			private class PowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<sbyte>
			{
				public PowPow2RangeGenerator(IRandom random, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public sbyte Next()
				{
					return 0;
				}
			}

			private class OffsetAnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<sbyte>
			{
				private uint _rangeMin;

				public OffsetAnyRangeGenerator(IRandom random, sbyte rangeMin, uint rangeSizeMinusOne, uint bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public sbyte Next()
				{
					return 0;
				}
			}

			private class OffsetPow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<sbyte>
			{
				private uint _rangeMin;

				public OffsetPow2RangeGenerator(IRandom random, sbyte rangeMin, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public sbyte Next()
				{
					return 0;
				}
			}

			private class OffsetPowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<sbyte>
			{
				private uint _rangeMin;

				public OffsetPowPow2RangeGenerator(IRandom random, sbyte rangeMin, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public sbyte Next()
				{
					return 0;
				}
			}

			public static IRangeGenerator<sbyte> Create(IRandom random, sbyte rangeMin, sbyte rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<sbyte> Create(IRandom random, sbyte rangeMax)
			{
				return null;
			}
		}

		private static class BufferedByteRangeGenerator
		{
			private class AnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<byte>
			{
				public AnyRangeGenerator(IRandom random, uint rangeSizeMinusOne, uint bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public byte Next()
				{
					return 0;
				}
			}

			private class Pow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<byte>
			{
				public Pow2RangeGenerator(IRandom random, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public byte Next()
				{
					return 0;
				}
			}

			private class PowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<byte>
			{
				public PowPow2RangeGenerator(IRandom random, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public byte Next()
				{
					return 0;
				}
			}

			private class OffsetAnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<byte>
			{
				private uint _rangeMin;

				public OffsetAnyRangeGenerator(IRandom random, byte rangeMin, uint rangeSizeMinusOne, uint bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public byte Next()
				{
					return 0;
				}
			}

			private class OffsetPow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<byte>
			{
				private uint _rangeMin;

				public OffsetPow2RangeGenerator(IRandom random, byte rangeMin, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public byte Next()
				{
					return 0;
				}
			}

			private class OffsetPowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<byte>
			{
				private uint _rangeMin;

				public OffsetPowPow2RangeGenerator(IRandom random, byte rangeMin, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public byte Next()
				{
					return 0;
				}
			}

			public static IRangeGenerator<byte> Create(IRandom random, byte rangeMin, byte rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<byte> Create(IRandom random, byte rangeMax)
			{
				return null;
			}
		}

		private static class BufferedShortRangeGenerator
		{
			private class AnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<short>
			{
				public AnyRangeGenerator(IRandom random, uint rangeSizeMinusOne, uint bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public short Next()
				{
					return 0;
				}
			}

			private class Pow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<short>
			{
				public Pow2RangeGenerator(IRandom random, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public short Next()
				{
					return 0;
				}
			}

			private class PowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<short>
			{
				public PowPow2RangeGenerator(IRandom random, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public short Next()
				{
					return 0;
				}
			}

			private class OffsetAnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<short>
			{
				private uint _rangeMin;

				public OffsetAnyRangeGenerator(IRandom random, short rangeMin, uint rangeSizeMinusOne, uint bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public short Next()
				{
					return 0;
				}
			}

			private class OffsetPow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<short>
			{
				private uint _rangeMin;

				public OffsetPow2RangeGenerator(IRandom random, short rangeMin, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public short Next()
				{
					return 0;
				}
			}

			private class OffsetPowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<short>
			{
				private uint _rangeMin;

				public OffsetPowPow2RangeGenerator(IRandom random, short rangeMin, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public short Next()
				{
					return 0;
				}
			}

			public static IRangeGenerator<short> Create(IRandom random, short rangeMin, short rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<short> Create(IRandom random, short rangeMax)
			{
				return null;
			}
		}

		private static class BufferedUShortRangeGenerator
		{
			private class AnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<ushort>
			{
				public AnyRangeGenerator(IRandom random, uint rangeSizeMinusOne, uint bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public ushort Next()
				{
					return 0;
				}
			}

			private class Pow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<ushort>
			{
				public Pow2RangeGenerator(IRandom random, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public ushort Next()
				{
					return 0;
				}
			}

			private class PowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<ushort>
			{
				public PowPow2RangeGenerator(IRandom random, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public ushort Next()
				{
					return 0;
				}
			}

			private class OffsetAnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<ushort>
			{
				private uint _rangeMin;

				public OffsetAnyRangeGenerator(IRandom random, ushort rangeMin, uint rangeSizeMinusOne, uint bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public ushort Next()
				{
					return 0;
				}
			}

			private class OffsetPow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<ushort>
			{
				private uint _rangeMin;

				public OffsetPow2RangeGenerator(IRandom random, ushort rangeMin, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public ushort Next()
				{
					return 0;
				}
			}

			private class OffsetPowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<ushort>
			{
				private uint _rangeMin;

				public OffsetPowPow2RangeGenerator(IRandom random, ushort rangeMin, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public ushort Next()
				{
					return 0;
				}
			}

			public static IRangeGenerator<ushort> Create(IRandom random, ushort rangeMin, ushort rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<ushort> Create(IRandom random, ushort rangeMax)
			{
				return null;
			}
		}

		private static class BufferedIntRangeGenerator
		{
			private class AnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<int>
			{
				public AnyRangeGenerator(IRandom random, uint rangeSizeMinusOne, uint bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public int Next()
				{
					return 0;
				}
			}

			private class Pow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<int>
			{
				public Pow2RangeGenerator(IRandom random, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public int Next()
				{
					return 0;
				}
			}

			private class PowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<int>
			{
				public PowPow2RangeGenerator(IRandom random, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public int Next()
				{
					return 0;
				}
			}

			private class OffsetAnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<int>
			{
				private uint _rangeMin;

				public OffsetAnyRangeGenerator(IRandom random, int rangeMin, uint rangeSizeMinusOne, uint bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public int Next()
				{
					return 0;
				}
			}

			private class OffsetPow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<int>
			{
				private uint _rangeMin;

				public OffsetPow2RangeGenerator(IRandom random, int rangeMin, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public int Next()
				{
					return 0;
				}
			}

			private class OffsetPowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<int>
			{
				private uint _rangeMin;

				public OffsetPowPow2RangeGenerator(IRandom random, int rangeMin, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public int Next()
				{
					return 0;
				}
			}

			public static IRangeGenerator<int> Create(IRandom random, int rangeMin, int rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<int> Create(IRandom random, int rangeMax)
			{
				return null;
			}
		}

		private static class BufferedUIntRangeGenerator
		{
			private class AnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<uint>
			{
				public AnyRangeGenerator(IRandom random, uint rangeSizeMinusOne, uint bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public uint Next()
				{
					return 0u;
				}
			}

			private class Pow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<uint>
			{
				public Pow2RangeGenerator(IRandom random, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public uint Next()
				{
					return 0u;
				}
			}

			private class PowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<uint>
			{
				public PowPow2RangeGenerator(IRandom random, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public uint Next()
				{
					return 0u;
				}
			}

			private class OffsetAnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<uint>
			{
				private uint _rangeMin;

				public OffsetAnyRangeGenerator(IRandom random, uint rangeMin, uint rangeSizeMinusOne, uint bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public uint Next()
				{
					return 0u;
				}
			}

			private class OffsetPow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<uint>
			{
				private uint _rangeMin;

				public OffsetPow2RangeGenerator(IRandom random, uint rangeMin, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public uint Next()
				{
					return 0u;
				}
			}

			private class OffsetPowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<uint>
			{
				private uint _rangeMin;

				public OffsetPowPow2RangeGenerator(IRandom random, uint rangeMin, int bitCount, uint bitMask)
					: base(null, 0, 0uL)
				{
				}

				public uint Next()
				{
					return 0u;
				}
			}

			public static IRangeGenerator<uint> Create(IRandom random, uint rangeMin, uint rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<uint> Create(IRandom random, uint rangeMax)
			{
				return null;
			}
		}

		private static class BufferedLongRangeGenerator
		{
			private class AnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<long>
			{
				public AnyRangeGenerator(IRandom random, ulong rangeSizeMinusOne, ulong bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public long Next()
				{
					return 0L;
				}
			}

			private class Pow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<long>
			{
				public Pow2RangeGenerator(IRandom random, int bitCount, ulong bitMask)
					: base(null, 0, 0uL)
				{
				}

				public long Next()
				{
					return 0L;
				}
			}

			private class PowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<long>
			{
				public PowPow2RangeGenerator(IRandom random, int bitCount, ulong bitMask)
					: base(null, 0, 0uL)
				{
				}

				public long Next()
				{
					return 0L;
				}
			}

			private class OffsetAnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<long>
			{
				private ulong _rangeMin;

				public OffsetAnyRangeGenerator(IRandom random, long rangeMin, ulong rangeSizeMinusOne, ulong bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public long Next()
				{
					return 0L;
				}
			}

			private class OffsetPow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<long>
			{
				private ulong _rangeMin;

				public OffsetPow2RangeGenerator(IRandom random, long rangeMin, int bitCount, ulong bitMask)
					: base(null, 0, 0uL)
				{
				}

				public long Next()
				{
					return 0L;
				}
			}

			private class OffsetPowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<long>
			{
				private ulong _rangeMin;

				public OffsetPowPow2RangeGenerator(IRandom random, long rangeMin, int bitCount, ulong bitMask)
					: base(null, 0, 0uL)
				{
				}

				public long Next()
				{
					return 0L;
				}
			}

			private class Int64RangeGenerator : IRangeGenerator<long>
			{
				private IRandom _random;

				public Int64RangeGenerator(IRandom random)
				{
				}

				public long Next()
				{
					return 0L;
				}
			}

			public static IRangeGenerator<long> Create(IRandom random, long rangeMin, long rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<long> Create(IRandom random, long rangeMax)
			{
				return null;
			}
		}

		private static class BufferedULongRangeGenerator
		{
			private class AnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<ulong>
			{
				public AnyRangeGenerator(IRandom random, ulong rangeSizeMinusOne, ulong bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public ulong Next()
				{
					return 0uL;
				}
			}

			private class Pow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<ulong>
			{
				public Pow2RangeGenerator(IRandom random, int bitCount, ulong bitMask)
					: base(null, 0, 0uL)
				{
				}

				public ulong Next()
				{
					return 0uL;
				}
			}

			private class PowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<ulong>
			{
				public PowPow2RangeGenerator(IRandom random, int bitCount, ulong bitMask)
					: base(null, 0, 0uL)
				{
				}

				public ulong Next()
				{
					return 0uL;
				}
			}

			private class OffsetAnyRangeGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<ulong>
			{
				private ulong _rangeMin;

				public OffsetAnyRangeGenerator(IRandom random, ulong rangeMin, ulong rangeSizeMinusOne, ulong bitMask)
					: base(null, 0uL, 0uL)
				{
				}

				public ulong Next()
				{
					return 0uL;
				}
			}

			private class OffsetPow2RangeGenerator : BufferedPow2RangeGeneratorBase, IRangeGenerator<ulong>
			{
				private ulong _rangeMin;

				public OffsetPow2RangeGenerator(IRandom random, ulong rangeMin, int bitCount, ulong bitMask)
					: base(null, 0, 0uL)
				{
				}

				public ulong Next()
				{
					return 0uL;
				}
			}

			private class OffsetPowPow2RangeGenerator : BufferedPowPow2RangeGeneratorBase, IRangeGenerator<ulong>
			{
				private ulong _rangeMin;

				public OffsetPowPow2RangeGenerator(IRandom random, ulong rangeMin, int bitCount, ulong bitMask)
					: base(null, 0, 0uL)
				{
				}

				public ulong Next()
				{
					return 0uL;
				}
			}

			private class UInt64RangeGenerator : IRangeGenerator<ulong>
			{
				private IRandom _random;

				public UInt64RangeGenerator(IRandom random)
				{
				}

				public ulong Next()
				{
					return 0uL;
				}
			}

			public static IRangeGenerator<ulong> Create(IRandom random, ulong rangeMin, ulong rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<ulong> Create(IRandom random, ulong rangeMax)
			{
				return null;
			}
		}

		private static class FloatRangeGenerator
		{
			private class UnitOOGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public UnitOOGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class UnitCOGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public UnitCOGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class UnitOCGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public UnitOCGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class UnitCCGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public UnitCCGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class SignedOOGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public SignedOOGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class SignedCOGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public SignedCOGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class SignedOCGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public SignedOCGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class SignedCCGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public SignedCCGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class UnitC1O2Generator : IRangeGenerator<float>
			{
				private IRandom _random;

				public UnitC1O2Generator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class UnitC2O4Generator : IRangeGenerator<float>
			{
				private IRandom _random;

				public UnitC2O4Generator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseUnitOOGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public PreciseUnitOOGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseUnitCOGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public PreciseUnitCOGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseUnitOCGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public PreciseUnitOCGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseUnitCCGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public PreciseUnitCCGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseSignedOOGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public PreciseSignedOOGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseSignedCOGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public PreciseSignedCOGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseSignedOCGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public PreciseSignedOCGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseSignedCCGenerator : IRangeGenerator<float>
			{
				private IRandom _random;

				public PreciseSignedCCGenerator(IRandom random)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class RangeGeneratorBase
			{
				protected IRandom _random;

				protected float _rangeMax;

				protected RangeGeneratorBase(IRandom random, float rangeMax)
				{
				}
			}

			private class RangeOOGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				private float _rangeMin;

				public RangeOOGenerator(IRandom random, float rangeMin, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class RangeZOOGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				public RangeZOOGenerator(IRandom random, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class RangeCOGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				private float _rangeMin;

				public RangeCOGenerator(IRandom random, float rangeMin, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class RangeZCOGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				public RangeZCOGenerator(IRandom random, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class RangeOCGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				private float _rangeMin;

				public RangeOCGenerator(IRandom random, float rangeMin, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class RangeZOCGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				public RangeZOCGenerator(IRandom random, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class RangeCCGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				private float _rangeMin;

				public RangeCCGenerator(IRandom random, float rangeMin, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class RangeZCCGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				public RangeZCCGenerator(IRandom random, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseRangeOOGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				private float _rangeMin;

				public PreciseRangeOOGenerator(IRandom random, float rangeMin, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseRangeZOOGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				public PreciseRangeZOOGenerator(IRandom random, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseRangeCOGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				private float _rangeMin;

				public PreciseRangeCOGenerator(IRandom random, float rangeMin, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseRangeZCOGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				public PreciseRangeZCOGenerator(IRandom random, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseRangeOCGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				private float _rangeMin;

				public PreciseRangeOCGenerator(IRandom random, float rangeMin, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseRangeZOCGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				public PreciseRangeZOCGenerator(IRandom random, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseRangeCCGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				private float _rangeMin;

				public PreciseRangeCCGenerator(IRandom random, float rangeMin, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			private class PreciseRangeZCCGenerator : RangeGeneratorBase, IRangeGenerator<float>
			{
				public PreciseRangeZCCGenerator(IRandom random, float rangeMax)
				{
				}

				public float Next()
				{
					return 0f;
				}
			}

			public static IRangeGenerator<float> CreateOO(IRandom random, float rangeMin, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateOO(IRandom random, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateOO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateCO(IRandom random, float rangeMin, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateCO(IRandom random, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateCO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateOC(IRandom random, float rangeMin, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateOC(IRandom random, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateOC(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateCC(IRandom random, float rangeMin, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateCC(IRandom random, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateCC(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateSignedOO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateSignedCO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateSignedOC(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateSignedCC(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateC1O2(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreateC2O4(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseOO(IRandom random, float rangeMin, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseOO(IRandom random, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseOO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseCO(IRandom random, float rangeMin, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseCO(IRandom random, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseCO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseOC(IRandom random, float rangeMin, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseOC(IRandom random, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseOC(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseCC(IRandom random, float rangeMin, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseCC(IRandom random, float rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseCC(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseSignedOO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseSignedCO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseSignedOC(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<float> CreatePreciseSignedCC(IRandom random)
			{
				return null;
			}
		}

		private static class DoubleRangeGenerator
		{
			private class UnitOOGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public UnitOOGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class UnitCOGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public UnitCOGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class UnitOCGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public UnitOCGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class UnitCCGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public UnitCCGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class SignedOOGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public SignedOOGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class SignedCOGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public SignedCOGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class SignedOCGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public SignedOCGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class SignedCCGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public SignedCCGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class UnitC1O2Generator : IRangeGenerator<double>
			{
				private IRandom _random;

				public UnitC1O2Generator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class UnitC2O4Generator : IRangeGenerator<double>
			{
				private IRandom _random;

				public UnitC2O4Generator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseUnitOOGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public PreciseUnitOOGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseUnitCOGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public PreciseUnitCOGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseUnitOCGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public PreciseUnitOCGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseUnitCCGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public PreciseUnitCCGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseSignedOOGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public PreciseSignedOOGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseSignedCOGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public PreciseSignedCOGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseSignedOCGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public PreciseSignedOCGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseSignedCCGenerator : IRangeGenerator<double>
			{
				private IRandom _random;

				public PreciseSignedCCGenerator(IRandom random)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class RangeGeneratorBase
			{
				protected IRandom _random;

				protected double _rangeMax;

				protected RangeGeneratorBase(IRandom random, double rangeMax)
				{
				}
			}

			private class RangeOOGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				private double _rangeMin;

				public RangeOOGenerator(IRandom random, double rangeMin, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class RangeZOOGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				public RangeZOOGenerator(IRandom random, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class RangeCOGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				private double _rangeMin;

				public RangeCOGenerator(IRandom random, double rangeMin, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class RangeZCOGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				public RangeZCOGenerator(IRandom random, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class RangeOCGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				private double _rangeMin;

				public RangeOCGenerator(IRandom random, double rangeMin, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class RangeZOCGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				public RangeZOCGenerator(IRandom random, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class RangeCCGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				private double _rangeMin;

				public RangeCCGenerator(IRandom random, double rangeMin, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class RangeZCCGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				public RangeZCCGenerator(IRandom random, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseRangeOOGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				private double _rangeMin;

				public PreciseRangeOOGenerator(IRandom random, double rangeMin, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseRangeZOOGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				public PreciseRangeZOOGenerator(IRandom random, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseRangeCOGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				private double _rangeMin;

				public PreciseRangeCOGenerator(IRandom random, double rangeMin, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseRangeZCOGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				public PreciseRangeZCOGenerator(IRandom random, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseRangeOCGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				private double _rangeMin;

				public PreciseRangeOCGenerator(IRandom random, double rangeMin, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseRangeZOCGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				public PreciseRangeZOCGenerator(IRandom random, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseRangeCCGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				private double _rangeMin;

				public PreciseRangeCCGenerator(IRandom random, double rangeMin, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			private class PreciseRangeZCCGenerator : RangeGeneratorBase, IRangeGenerator<double>
			{
				public PreciseRangeZCCGenerator(IRandom random, double rangeMax)
				{
				}

				public double Next()
				{
					return 0.0;
				}
			}

			public static IRangeGenerator<double> CreateOO(IRandom random, double rangeMin, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateOO(IRandom random, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateOO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateCO(IRandom random, double rangeMin, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateCO(IRandom random, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateCO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateOC(IRandom random, double rangeMin, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateOC(IRandom random, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateOC(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateCC(IRandom random, double rangeMin, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateCC(IRandom random, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateCC(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateSignedOO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateSignedCO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateSignedOC(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateSignedCC(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateC1O2(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreateC2O4(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseOO(IRandom random, double rangeMin, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseOO(IRandom random, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseOO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseCO(IRandom random, double rangeMin, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseCO(IRandom random, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseCO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseOC(IRandom random, double rangeMin, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseOC(IRandom random, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseOC(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseCC(IRandom random, double rangeMin, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseCC(IRandom random, double rangeMax)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseCC(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseSignedOO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseSignedCO(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseSignedOC(IRandom random)
			{
				return null;
			}

			public static IRangeGenerator<double> CreatePreciseSignedCC(IRandom random)
			{
				return null;
			}
		}

		public static IRangeGenerator<sbyte> MakeSByteGenerator(this IRandom random, bool excludeNegative = false)
		{
			return null;
		}

		public static IRangeGenerator<byte> MakeByteGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<short> MakeShortGenerator(this IRandom random, bool excludeNegative = false)
		{
			return null;
		}

		public static IRangeGenerator<ushort> MakeUShortGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<int> MakeIntGenerator(this IRandom random, bool excludeNegative = false)
		{
			return null;
		}

		public static IRangeGenerator<uint> MakeUIntGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<long> MakeLongGenerator(this IRandom random, bool excludeNegative = false)
		{
			return null;
		}

		public static IRangeGenerator<ulong> MakeULongGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<sbyte> MakeRangeOOGenerator(this IRandom random, sbyte lowerExclusive, sbyte upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<sbyte> MakeRangeOOGenerator(this IRandom random, sbyte upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<byte> MakeRangeOOGenerator(this IRandom random, byte lowerExclusive, byte upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<byte> MakeRangeOOGenerator(this IRandom random, byte upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<short> MakeRangeOOGenerator(this IRandom random, short lowerExclusive, short upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<short> MakeRangeOOGenerator(this IRandom random, short upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<ushort> MakeRangeOOGenerator(this IRandom random, ushort lowerExclusive, ushort upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<ushort> MakeRangeOOGenerator(this IRandom random, ushort upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<int> MakeRangeOOGenerator(this IRandom random, int lowerExclusive, int upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<int> MakeRangeOOGenerator(this IRandom random, int upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<uint> MakeRangeOOGenerator(this IRandom random, uint lowerExclusive, uint upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<uint> MakeRangeOOGenerator(this IRandom random, uint upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<long> MakeRangeOOGenerator(this IRandom random, long lowerExclusive, long upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<long> MakeRangeOOGenerator(this IRandom random, long upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<ulong> MakeRangeOOGenerator(this IRandom random, ulong lowerExclusive, ulong upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<ulong> MakeRangeOOGenerator(this IRandom random, ulong upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeRangeOOGenerator(this IRandom random, float lowerExclusive, float upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeRangeOOGenerator(this IRandom random, float upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseRangeOOGenerator(this IRandom random, float lowerExclusive, float upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseRangeOOGenerator(this IRandom random, float upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseRangeOOGenerator(this IRandom random, double lowerExclusive, double upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseRangeOOGenerator(this IRandom random, double upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<sbyte> MakeRangeCOGenerator(this IRandom random, sbyte lowerInclusive, sbyte upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<sbyte> MakeRangeCOGenerator(this IRandom random, sbyte upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<byte> MakeRangeCOGenerator(this IRandom random, byte lowerInclusive, byte upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<byte> MakeRangeCOGenerator(this IRandom random, byte upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<short> MakeRangeCOGenerator(this IRandom random, short lowerInclusive, short upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<short> MakeRangeCOGenerator(this IRandom random, short upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<ushort> MakeRangeCOGenerator(this IRandom random, ushort lowerInclusive, ushort upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<ushort> MakeRangeCOGenerator(this IRandom random, ushort upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<int> MakeRangeCOGenerator(this IRandom random, int lowerInclusive, int upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<int> MakeRangeCOGenerator(this IRandom random, int upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<uint> MakeRangeCOGenerator(this IRandom random, uint lowerInclusive, uint upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<uint> MakeRangeCOGenerator(this IRandom random, uint upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<long> MakeRangeCOGenerator(this IRandom random, long lowerInclusive, long upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<long> MakeRangeCOGenerator(this IRandom random, long upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<ulong> MakeRangeCOGenerator(this IRandom random, ulong lowerInclusive, ulong upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<ulong> MakeRangeCOGenerator(this IRandom random, ulong upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeRangeCOGenerator(this IRandom random, float lowerInclusive, float upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeRangeCOGenerator(this IRandom random, float upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeRangeCOGenerator(this IRandom random, double lowerInclusive, double upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeRangeCOGenerator(this IRandom random, double upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseRangeCOGenerator(this IRandom random, float lowerInclusive, float upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseRangeCOGenerator(this IRandom random, float upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseRangeCOGenerator(this IRandom random, double lowerInclusive, double upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseRangeCOGenerator(this IRandom random, double upperExclusive)
		{
			return null;
		}

		public static IRangeGenerator<sbyte> MakeRangeOCGenerator(this IRandom random, sbyte lowerExclusive, sbyte upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<sbyte> MakeRangeOCGenerator(this IRandom random, sbyte upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<byte> MakeRangeOCGenerator(this IRandom random, byte lowerExclusive, byte upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<byte> MakeRangeOCGenerator(this IRandom random, byte upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<short> MakeRangeOCGenerator(this IRandom random, short lowerExclusive, short upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<short> MakeRangeOCGenerator(this IRandom random, short upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<ushort> MakeRangeOCGenerator(this IRandom random, ushort lowerExclusive, ushort upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<ushort> MakeRangeOCGenerator(this IRandom random, ushort upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<int> MakeRangeOCGenerator(this IRandom random, int lowerExclusive, int upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<int> MakeRangeOCGenerator(this IRandom random, int upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<uint> MakeRangeOCGenerator(this IRandom random, uint lowerExclusive, uint upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<uint> MakeRangeOCGenerator(this IRandom random, uint upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<long> MakeRangeOCGenerator(this IRandom random, long lowerExclusive, long upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<long> MakeRangeOCGenerator(this IRandom random, long upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<ulong> MakeRangeOCGenerator(this IRandom random, ulong lowerExclusive, ulong upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<ulong> MakeRangeOCGenerator(this IRandom random, ulong upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeRangeOCGenerator(this IRandom random, float lowerExclusive, float upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeRangeOCGenerator(this IRandom random, float upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeRangeOCGenerator(this IRandom random, double lowerExclusive, double upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeRangeOCGenerator(this IRandom random, double upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseRangeOCGenerator(this IRandom random, float lowerExclusive, float upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseRangeOCGenerator(this IRandom random, float upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseRangeOCGenerator(this IRandom random, double lowerExclusive, double upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseRangeOCGenerator(this IRandom random, double upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<sbyte> MakeRangeCCGenerator(this IRandom random, sbyte lowerInclusive, sbyte upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<sbyte> MakeRangeCCGenerator(this IRandom random, sbyte upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<byte> MakeRangeCCGenerator(this IRandom random, byte lowerInclusive, byte upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<byte> MakeRangeCCGenerator(this IRandom random, byte upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<short> MakeRangeCCGenerator(this IRandom random, short lowerInclusive, short upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<short> MakeRangeCCGenerator(this IRandom random, short upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<ushort> MakeRangeCCGenerator(this IRandom random, ushort lowerInclusive, ushort upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<ushort> MakeRangeCCGenerator(this IRandom random, ushort upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<int> MakeRangeCCGenerator(this IRandom random, int lowerInclusive, int upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<int> MakeRangeCCGenerator(this IRandom random, int upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<uint> MakeRangeCCGenerator(this IRandom random, uint lowerInclusive, uint upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<uint> MakeRangeCCGenerator(this IRandom random, uint upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<long> MakeRangeCCGenerator(this IRandom random, long lowerInclusive, long upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<long> MakeRangeCCGenerator(this IRandom random, long upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<ulong> MakeRangeCCGenerator(this IRandom random, ulong lowerInclusive, ulong upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<ulong> MakeRangeCCGenerator(this IRandom random, ulong upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeRangeCCGenerator(this IRandom random, float lowerInclusive, float upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeRangeCCGenerator(this IRandom random, float upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeRangeCCGenerator(this IRandom random, double lowerInclusive, double upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeRangeCCGenerator(this IRandom random, double upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseRangeCCGenerator(this IRandom random, float lowerInclusive, float upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseRangeCCGenerator(this IRandom random, float upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseRangeCCGenerator(this IRandom random, double lowerInclusive, double upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseRangeCCGenerator(this IRandom random, double upperInclusive)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeFloatOOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeFloatCOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeFloatOCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeFloatCCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeSignedFloatOOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeSignedFloatCOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeSignedFloatOCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeSignedFloatCCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeFloatC1O2Generator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakeFloatC2O4Generator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseFloatOOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseFloatCOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseFloatOCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseFloatCCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseSignedFloatOOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseSignedFloatCOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseSignedFloatOCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<float> MakePreciseSignedFloatCCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeDoubleOOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeDoubleCOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeDoubleOCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeDoubleCCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeSignedDoubleOOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeSignedDoubleCOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeSignedDoubleOCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeSignedDoubleCCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeDoubleC1O2Generator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakeDoubleC2O4Generator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseDoubleOOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseDoubleCOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseDoubleOCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseDoubleCCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseSignedDoubleOOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseSignedDoubleCOGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseSignedDoubleOCGenerator(this IRandom random)
		{
			return null;
		}

		public static IRangeGenerator<double> MakePreciseSignedDoubleCCGenerator(this IRandom random)
		{
			return null;
		}
	}
}
