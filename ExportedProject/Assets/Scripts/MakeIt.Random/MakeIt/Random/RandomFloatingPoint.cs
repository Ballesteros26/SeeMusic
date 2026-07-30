namespace MakeIt.Random
{
	public static class RandomFloatingPoint
	{
		private const uint _maxUnsignedFixed32LessThanFloatOne = 4294967167u;

		private const int _maxSignedFixed32LessThanFloatOne = 2147483583;

		private const uint _floatExponent31 = 260046848u;

		private const uint _floatExponent32 = 268435456u;

		private const ulong _maxUnsignedFixed64LessThanFloatOne = 18446744073709550591uL;

		private const long _maxSignedFixed64LessThanFloatOne = 9223372036854775295L;

		private const ulong _doubleExponent63 = 144115188075855872uL;

		private const ulong _doubleExponent64 = 288230376151711744uL;

		public static float FloatOO(this IRandom random)
		{
			return 0f;
		}

		public static double DoubleOO(this IRandom random)
		{
			return 0.0;
		}

		public static float FloatCO(this IRandom random)
		{
			return 0f;
		}

		public static double DoubleCO(this IRandom random)
		{
			return 0.0;
		}

		public static float FloatOC(this IRandom random)
		{
			return 0f;
		}

		public static double DoubleOC(this IRandom random)
		{
			return 0.0;
		}

		public static float FloatCC(this IRandom random)
		{
			return 0f;
		}

		public static double DoubleCC(this IRandom random)
		{
			return 0.0;
		}

		public static float SignedFloatOO(this IRandom random)
		{
			return 0f;
		}

		public static double SignedDoubleOO(this IRandom random)
		{
			return 0.0;
		}

		public static float SignedFloatCO(this IRandom random)
		{
			return 0f;
		}

		public static double SignedDoubleCO(this IRandom random)
		{
			return 0.0;
		}

		public static float SignedFloatOC(this IRandom random)
		{
			return 0f;
		}

		public static double SignedDoubleOC(this IRandom random)
		{
			return 0.0;
		}

		public static float SignedFloatCC(this IRandom random)
		{
			return 0f;
		}

		public static double SignedDoubleCC(this IRandom random)
		{
			return 0.0;
		}

		public static float FloatC1O2(this IRandom random)
		{
			return 0f;
		}

		public static double DoubleC1O2(this IRandom random)
		{
			return 0.0;
		}

		public static float FloatC2O4(this IRandom random)
		{
			return 0f;
		}

		public static double DoubleC2O4(this IRandom random)
		{
			return 0.0;
		}

		public static float RangeOO(this IRandom random, float lowerExclusive, float upperExclusive)
		{
			return 0f;
		}

		public static float RangeOO(this IRandom random, float upperExclusive)
		{
			return 0f;
		}

		public static double RangeOO(this IRandom random, double lowerExclusive, double upperExclusive)
		{
			return 0.0;
		}

		public static double RangeOO(this IRandom random, double upperExclusive)
		{
			return 0.0;
		}

		public static float RangeCO(this IRandom random, float lowerInclusive, float upperExclusive)
		{
			return 0f;
		}

		public static float RangeCO(this IRandom random, float upperExclusive)
		{
			return 0f;
		}

		public static double RangeCO(this IRandom random, double lowerInclusive, double upperExclusive)
		{
			return 0.0;
		}

		public static double RangeCO(this IRandom random, double upperExclusive)
		{
			return 0.0;
		}

		public static float RangeOC(this IRandom random, float lowerExclusive, float upperInclusive)
		{
			return 0f;
		}

		public static float RangeOC(this IRandom random, float upperInclusive)
		{
			return 0f;
		}

		public static double RangeOC(this IRandom random, double lowerExclusive, double upperInclusive)
		{
			return 0.0;
		}

		public static double RangeOC(this IRandom random, double upperInclusive)
		{
			return 0.0;
		}

		public static float RangeCC(this IRandom random, float lowerInclusive, float upperInclusive)
		{
			return 0f;
		}

		public static float RangeCC(this IRandom random, float upperInclusive)
		{
			return 0f;
		}

		public static double RangeCC(this IRandom random, double lowerInclusive, double upperInclusive)
		{
			return 0.0;
		}

		public static double RangeCC(this IRandom random, double upperInclusive)
		{
			return 0.0;
		}

		public static float PreciseFloatOO(this IRandom random)
		{
			return 0f;
		}

		public static double PreciseDoubleOO(this IRandom random)
		{
			return 0.0;
		}

		public static float PreciseFloatCO(this IRandom random)
		{
			return 0f;
		}

		public static double PreciseDoubleCO(this IRandom random)
		{
			return 0.0;
		}

		public static float PreciseFloatOC(this IRandom random)
		{
			return 0f;
		}

		public static double PreciseDoubleOC(this IRandom random)
		{
			return 0.0;
		}

		public static float PreciseFloatCC(this IRandom random)
		{
			return 0f;
		}

		public static double PreciseDoubleCC(this IRandom random)
		{
			return 0.0;
		}

		public static float PreciseSignedFloatOO(this IRandom random)
		{
			return 0f;
		}

		public static double PreciseSignedDoubleOO(this IRandom random)
		{
			return 0.0;
		}

		public static float PreciseSignedFloatCO(this IRandom random)
		{
			return 0f;
		}

		public static double PreciseSignedDoubleCO(this IRandom random)
		{
			return 0.0;
		}

		public static float PreciseSignedFloatOC(this IRandom random)
		{
			return 0f;
		}

		public static double PreciseSignedDoubleOC(this IRandom random)
		{
			return 0.0;
		}

		public static float PreciseSignedFloatCC(this IRandom random)
		{
			return 0f;
		}

		public static double PreciseSignedDoubleCC(this IRandom random)
		{
			return 0.0;
		}

		public static float PreciseRangeOO(this IRandom random, float lowerExclusive, float upperExclusive)
		{
			return 0f;
		}

		public static float PreciseRangeOO(this IRandom random, float upperExclusive)
		{
			return 0f;
		}

		public static double PreciseRangeOO(this IRandom random, double lowerExclusive, double upperExclusive)
		{
			return 0.0;
		}

		public static double PreciseRangeOO(this IRandom random, double upperExclusive)
		{
			return 0.0;
		}

		public static float PreciseRangeCO(this IRandom random, float lowerInclusive, float upperExclusive)
		{
			return 0f;
		}

		public static float PreciseRangeCO(this IRandom random, float upperExclusive)
		{
			return 0f;
		}

		public static double PreciseRangeCO(this IRandom random, double lowerInclusive, double upperExclusive)
		{
			return 0.0;
		}

		public static double PreciseRangeCO(this IRandom random, double upperExclusive)
		{
			return 0.0;
		}

		public static float PreciseRangeOC(this IRandom random, float lowerExclusive, float upperInclusive)
		{
			return 0f;
		}

		public static float PreciseRangeOC(this IRandom random, float upperInclusive)
		{
			return 0f;
		}

		public static double PreciseRangeOC(this IRandom random, double lowerExclusive, double upperInclusive)
		{
			return 0.0;
		}

		public static double PreciseRangeOC(this IRandom random, double upperInclusive)
		{
			return 0.0;
		}

		public static float PreciseRangeCC(this IRandom random, float lowerInclusive, float upperInclusive)
		{
			return 0f;
		}

		public static float PreciseRangeCC(this IRandom random, float upperInclusive)
		{
			return 0f;
		}

		public static double PreciseRangeCC(this IRandom random, double lowerInclusive, double upperInclusive)
		{
			return 0.0;
		}

		public static double PreciseRangeCC(this IRandom random, double upperInclusive)
		{
			return 0.0;
		}
	}
}
