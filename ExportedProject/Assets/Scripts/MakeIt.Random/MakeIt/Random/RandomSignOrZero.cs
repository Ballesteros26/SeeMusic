using MakeIt.Random.Detail;

namespace MakeIt.Random
{
	public static class RandomSignOrZero
	{
		private class OneOrZeroGenerator : BufferedBitGenerator, IRangeGenerator<int>
		{
			public OneOrZeroGenerator(IRandom random)
				: base(null)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class SignGenerator : BufferedBitGenerator, IRangeGenerator<int>
		{
			public SignGenerator(IRandom random)
				: base(null)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class SignOrZeroGenerator : BufferedAnyRangeGeneratorBase, IRangeGenerator<int>
		{
			public SignOrZeroGenerator(IRandom random)
				: base(null, 0uL, 0uL)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class IntWeightedOneProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<int> _rangeGenerator;

			private int _numerator;

			public IntWeightedOneProbabilityGenerator(IRandom random, int numerator)
			{
			}

			public IntWeightedOneProbabilityGenerator(IRandom random, int numerator, int denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class UIntWeightedOneProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<uint> _rangeGenerator;

			private uint _numerator;

			public UIntWeightedOneProbabilityGenerator(IRandom random, uint numerator)
			{
			}

			public UIntWeightedOneProbabilityGenerator(IRandom random, uint numerator, uint denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class LongWeightedOneProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<long> _rangeGenerator;

			private long _numerator;

			public LongWeightedOneProbabilityGenerator(IRandom random, long numerator)
			{
			}

			public LongWeightedOneProbabilityGenerator(IRandom random, long numerator, long denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class ULongWeightedOneProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<ulong> _rangeGenerator;

			private ulong _numerator;

			public ULongWeightedOneProbabilityGenerator(IRandom random, ulong numerator)
			{
			}

			public ULongWeightedOneProbabilityGenerator(IRandom random, ulong numerator, ulong denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class FloatWeightedOneProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<float> _rangeGenerator;

			private float _numerator;

			public FloatWeightedOneProbabilityGenerator(IRandom random, float probability)
			{
			}

			public FloatWeightedOneProbabilityGenerator(IRandom random, float numerator, float denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class DoubleWeightedOneProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<double> _rangeGenerator;

			private double _numerator;

			public DoubleWeightedOneProbabilityGenerator(IRandom random, double probability)
			{
			}

			public DoubleWeightedOneProbabilityGenerator(IRandom random, double numerator, double denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class IntWeightedZeroProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<int> _rangeGenerator;

			private int _numerator;

			public IntWeightedZeroProbabilityGenerator(IRandom random, int numerator)
			{
			}

			public IntWeightedZeroProbabilityGenerator(IRandom random, int numerator, int denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class UIntWeightedZeroProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<uint> _rangeGenerator;

			private uint _numerator;

			public UIntWeightedZeroProbabilityGenerator(IRandom random, uint numerator)
			{
			}

			public UIntWeightedZeroProbabilityGenerator(IRandom random, uint numerator, uint denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class LongWeightedZeroProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<long> _rangeGenerator;

			private long _numerator;

			public LongWeightedZeroProbabilityGenerator(IRandom random, long numerator)
			{
			}

			public LongWeightedZeroProbabilityGenerator(IRandom random, long numerator, long denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class ULongWeightedZeroProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<ulong> _rangeGenerator;

			private ulong _numerator;

			public ULongWeightedZeroProbabilityGenerator(IRandom random, ulong numerator)
			{
			}

			public ULongWeightedZeroProbabilityGenerator(IRandom random, ulong numerator, ulong denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class FloatWeightedZeroProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<float> _rangeGenerator;

			private float _numerator;

			public FloatWeightedZeroProbabilityGenerator(IRandom random, float probability)
			{
			}

			public FloatWeightedZeroProbabilityGenerator(IRandom random, float numerator, float denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class DoubleWeightedZeroProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<double> _rangeGenerator;

			private double _numerator;

			public DoubleWeightedZeroProbabilityGenerator(IRandom random, double probability)
			{
			}

			public DoubleWeightedZeroProbabilityGenerator(IRandom random, double numerator, double denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class IntWeightedPositiveProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<int> _rangeGenerator;

			private int _numerator;

			public IntWeightedPositiveProbabilityGenerator(IRandom random, int numerator)
			{
			}

			public IntWeightedPositiveProbabilityGenerator(IRandom random, int numerator, int denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class UIntWeightedPositiveProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<uint> _rangeGenerator;

			private uint _numerator;

			public UIntWeightedPositiveProbabilityGenerator(IRandom random, uint numerator)
			{
			}

			public UIntWeightedPositiveProbabilityGenerator(IRandom random, uint numerator, uint denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class LongWeightedPositiveProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<long> _rangeGenerator;

			private long _numerator;

			public LongWeightedPositiveProbabilityGenerator(IRandom random, long numerator)
			{
			}

			public LongWeightedPositiveProbabilityGenerator(IRandom random, long numerator, long denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class ULongWeightedPositiveProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<ulong> _rangeGenerator;

			private ulong _numerator;

			public ULongWeightedPositiveProbabilityGenerator(IRandom random, ulong numerator)
			{
			}

			public ULongWeightedPositiveProbabilityGenerator(IRandom random, ulong numerator, ulong denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class FloatWeightedPositiveProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<float> _rangeGenerator;

			private float _numerator;

			public FloatWeightedPositiveProbabilityGenerator(IRandom random, float probability)
			{
			}

			public FloatWeightedPositiveProbabilityGenerator(IRandom random, float numerator, float denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class DoubleWeightedPositiveProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<double> _rangeGenerator;

			private double _numerator;

			public DoubleWeightedPositiveProbabilityGenerator(IRandom random, double probability)
			{
			}

			public DoubleWeightedPositiveProbabilityGenerator(IRandom random, double numerator, double denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class IntWeightedNegativeProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<int> _rangeGenerator;

			private int _numerator;

			public IntWeightedNegativeProbabilityGenerator(IRandom random, int numerator)
			{
			}

			public IntWeightedNegativeProbabilityGenerator(IRandom random, int numerator, int denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class UIntWeightedNegativeProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<uint> _rangeGenerator;

			private uint _numerator;

			public UIntWeightedNegativeProbabilityGenerator(IRandom random, uint numerator)
			{
			}

			public UIntWeightedNegativeProbabilityGenerator(IRandom random, uint numerator, uint denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class LongWeightedNegativeProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<long> _rangeGenerator;

			private long _numerator;

			public LongWeightedNegativeProbabilityGenerator(IRandom random, long numerator)
			{
			}

			public LongWeightedNegativeProbabilityGenerator(IRandom random, long numerator, long denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class ULongWeightedNegativeProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<ulong> _rangeGenerator;

			private ulong _numerator;

			public ULongWeightedNegativeProbabilityGenerator(IRandom random, ulong numerator)
			{
			}

			public ULongWeightedNegativeProbabilityGenerator(IRandom random, ulong numerator, ulong denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class FloatWeightedNegativeProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<float> _rangeGenerator;

			private float _numerator;

			public FloatWeightedNegativeProbabilityGenerator(IRandom random, float probability)
			{
			}

			public FloatWeightedNegativeProbabilityGenerator(IRandom random, float numerator, float denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class DoubleWeightedNegativeProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<double> _rangeGenerator;

			private double _numerator;

			public DoubleWeightedNegativeProbabilityGenerator(IRandom random, double probability)
			{
			}

			public DoubleWeightedNegativeProbabilityGenerator(IRandom random, double numerator, double denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class IntWeightedSignProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<int> _rangeGenerator;

			private int _numeratorNonZero;

			private int _numeratorPositive;

			public IntWeightedSignProbabilityGenerator(IRandom random, int numeratorPositive, int numeratorNegative)
			{
			}

			public IntWeightedSignProbabilityGenerator(IRandom random, int numeratorPositive, int numeratorNegative, int denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class UIntWeightedSignProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<uint> _rangeGenerator;

			private uint _numeratorNonZero;

			private uint _numeratorPositive;

			public UIntWeightedSignProbabilityGenerator(IRandom random, uint numeratorPositive, uint numeratorNegative)
			{
			}

			public UIntWeightedSignProbabilityGenerator(IRandom random, uint numeratorPositive, uint numeratorNegative, uint denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class LongWeightedSignProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<long> _rangeGenerator;

			private long _numeratorNonZero;

			private long _numeratorPositive;

			public LongWeightedSignProbabilityGenerator(IRandom random, long numeratorPositive, long numeratorNegative)
			{
			}

			public LongWeightedSignProbabilityGenerator(IRandom random, long numeratorPositive, long numeratorNegative, long denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class ULongWeightedSignProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<ulong> _rangeGenerator;

			private ulong _numeratorNonZero;

			private ulong _numeratorPositive;

			public ULongWeightedSignProbabilityGenerator(IRandom random, ulong numeratorPositive, ulong numeratorNegative)
			{
			}

			public ULongWeightedSignProbabilityGenerator(IRandom random, ulong numeratorPositive, ulong numeratorNegative, ulong denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class FloatWeightedSignProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<float> _rangeGenerator;

			private float _numeratorNonZero;

			private float _numeratorPositive;

			public FloatWeightedSignProbabilityGenerator(IRandom random, float probabilityPositive, float probabilityNegative)
			{
			}

			public FloatWeightedSignProbabilityGenerator(IRandom random, float numeratorPositive, float numeratorNegative, float denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		private class DoubleWeightedSignProbabilityGenerator : IRangeGenerator<int>
		{
			private IRangeGenerator<double> _rangeGenerator;

			private double _numeratorNonZero;

			private double _numeratorPositive;

			public DoubleWeightedSignProbabilityGenerator(IRandom random, double probabilityPositive, double probabilityNegative)
			{
			}

			public DoubleWeightedSignProbabilityGenerator(IRandom random, double numeratorPositive, double numeratorNegative, double denominator)
			{
			}

			public int Next()
			{
				return 0;
			}
		}

		public static int OneOrZero(this IRandom random)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneOrZeroGenerator(this IRandom random)
		{
			return null;
		}

		public static int Sign(this IRandom random)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignGenerator(this IRandom random)
		{
			return null;
		}

		public static int SignOrZero(this IRandom random)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignOrZeroGenerator(this IRandom random)
		{
			return null;
		}

		public static int OneOrZero(this IRandom random, int ratioOne, int ratioZero)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneOrZeroGenerator(this IRandom random, int ratioOne, int ratioZero)
		{
			return null;
		}

		public static int OneOrZero(this IRandom random, uint ratioOne, uint ratioZero)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneOrZeroGenerator(this IRandom random, uint ratioOne, uint ratioZero)
		{
			return null;
		}

		public static int OneOrZero(this IRandom random, long ratioOne, long ratioZero)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneOrZeroGenerator(this IRandom random, long ratioOne, long ratioZero)
		{
			return null;
		}

		public static int OneOrZero(this IRandom random, ulong ratioOne, ulong ratioZero)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneOrZeroGenerator(this IRandom random, ulong ratioOne, ulong ratioZero)
		{
			return null;
		}

		public static int OneOrZero(this IRandom random, float ratioOne, float ratioZero)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneOrZeroGenerator(this IRandom random, float ratioOne, float ratioZero)
		{
			return null;
		}

		public static int OneOrZero(this IRandom random, double ratioOne, double ratioZero)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneOrZeroGenerator(this IRandom random, double ratioOne, double ratioZero)
		{
			return null;
		}

		public static int Sign(this IRandom random, int ratioPositive, int ratioNegative)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignGenerator(this IRandom random, int ratioPositive, int ratioNegative)
		{
			return null;
		}

		public static int Sign(this IRandom random, uint ratioPositive, uint ratioNegative)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignGenerator(this IRandom random, uint ratioPositive, uint ratioNegative)
		{
			return null;
		}

		public static int Sign(this IRandom random, long ratioPositive, long ratioNegative)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignGenerator(this IRandom random, long ratioPositive, long ratioNegative)
		{
			return null;
		}

		public static int Sign(this IRandom random, ulong ratioPositive, ulong ratioNegative)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignGenerator(this IRandom random, ulong ratioPositive, ulong ratioNegative)
		{
			return null;
		}

		public static int Sign(this IRandom random, float ratioPositive, float ratioNegative)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignGenerator(this IRandom random, float ratioPositive, float ratioNegative)
		{
			return null;
		}

		public static int Sign(this IRandom random, double ratioPositive, double ratioNegative)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignGenerator(this IRandom random, double ratioPositive, double ratioNegative)
		{
			return null;
		}

		public static int SignOrZero(this IRandom random, int ratioPositive, int ratioNegative, int ratioZero)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignOrZeroGenerator(this IRandom random, int ratioPositive, int ratioNegative, int ratioZero)
		{
			return null;
		}

		public static int SignOrZero(this IRandom random, uint ratioPositive, uint ratioNegative, uint ratioZero)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignOrZeroGenerator(this IRandom random, uint ratioPositive, uint ratioNegative, uint ratioZero)
		{
			return null;
		}

		public static int SignOrZero(this IRandom random, long ratioPositive, long ratioNegative, long ratioZero)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignOrZeroGenerator(this IRandom random, long ratioPositive, long ratioNegative, long ratioZero)
		{
			return null;
		}

		public static int SignOrZero(this IRandom random, ulong ratioPositive, ulong ratioNegative, ulong ratioZero)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignOrZeroGenerator(this IRandom random, ulong ratioPositive, ulong ratioNegative, ulong ratioZero)
		{
			return null;
		}

		public static int SignOrZero(this IRandom random, float ratioPositive, float ratioNegative, float ratioZero)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignOrZeroGenerator(this IRandom random, float ratioPositive, float ratioNegative, float ratioZero)
		{
			return null;
		}

		public static int SignOrZero(this IRandom random, double ratioPositive, double ratioNegative, double ratioZero)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignOrZeroGenerator(this IRandom random, double ratioPositive, double ratioNegative, double ratioZero)
		{
			return null;
		}

		public static int OneProbability(this IRandom random, int numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneProbabilityGenerator(this IRandom random, int numerator)
		{
			return null;
		}

		public static int OneProbability(this IRandom random, uint numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneProbabilityGenerator(this IRandom random, uint numerator)
		{
			return null;
		}

		public static int OneProbability(this IRandom random, long numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneProbabilityGenerator(this IRandom random, long numerator)
		{
			return null;
		}

		public static int OneProbability(this IRandom random, ulong numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneProbabilityGenerator(this IRandom random, ulong numerator)
		{
			return null;
		}

		public static int OneProbability(this IRandom random, float probability)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneProbabilityGenerator(this IRandom random, float probability)
		{
			return null;
		}

		public static int OneProbability(this IRandom random, double probability)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneProbabilityGenerator(this IRandom random, double probability)
		{
			return null;
		}

		public static int OneProbability(this IRandom random, int numerator, int denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneProbabilityGenerator(this IRandom random, int numerator, int denominator)
		{
			return null;
		}

		public static int OneProbability(this IRandom random, uint numerator, uint denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneProbabilityGenerator(this IRandom random, uint numerator, uint denominator)
		{
			return null;
		}

		public static int OneProbability(this IRandom random, long numerator, long denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneProbabilityGenerator(this IRandom random, long numerator, long denominator)
		{
			return null;
		}

		public static int OneProbability(this IRandom random, ulong numerator, ulong denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneProbabilityGenerator(this IRandom random, ulong numerator, ulong denominator)
		{
			return null;
		}

		public static int OneProbability(this IRandom random, float numerator, float denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneProbabilityGenerator(this IRandom random, float numerator, float denominator)
		{
			return null;
		}

		public static int OneProbability(this IRandom random, double numerator, double denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeOneProbabilityGenerator(this IRandom random, double numerator, double denominator)
		{
			return null;
		}

		public static int ZeroProbability(this IRandom random, int numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeZeroProbabilityGenerator(this IRandom random, int numerator)
		{
			return null;
		}

		public static int ZeroProbability(this IRandom random, uint numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeZeroProbabilityGenerator(this IRandom random, uint numerator)
		{
			return null;
		}

		public static int ZeroProbability(this IRandom random, long numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeZeroProbabilityGenerator(this IRandom random, long numerator)
		{
			return null;
		}

		public static int ZeroProbability(this IRandom random, ulong numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeZeroProbabilityGenerator(this IRandom random, ulong numerator)
		{
			return null;
		}

		public static int ZeroProbability(this IRandom random, float probability)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeZeroProbabilityGenerator(this IRandom random, float probability)
		{
			return null;
		}

		public static int ZeroProbability(this IRandom random, double probability)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeZeroProbabilityGenerator(this IRandom random, double probability)
		{
			return null;
		}

		public static int ZeroProbability(this IRandom random, int numerator, int denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeZeroProbabilityGenerator(this IRandom random, int numerator, int denominator)
		{
			return null;
		}

		public static int ZeroProbability(this IRandom random, uint numerator, uint denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeZeroProbabilityGenerator(this IRandom random, uint numerator, uint denominator)
		{
			return null;
		}

		public static int ZeroProbability(this IRandom random, long numerator, long denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeZeroProbabilityGenerator(this IRandom random, long numerator, long denominator)
		{
			return null;
		}

		public static int ZeroProbability(this IRandom random, ulong numerator, ulong denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeZeroProbabilityGenerator(this IRandom random, ulong numerator, ulong denominator)
		{
			return null;
		}

		public static int ZeroProbability(this IRandom random, float numerator, float denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeZeroProbabilityGenerator(this IRandom random, float numerator, float denominator)
		{
			return null;
		}

		public static int ZeroProbability(this IRandom random, double numerator, double denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeZeroProbabilityGenerator(this IRandom random, double numerator, double denominator)
		{
			return null;
		}

		public static int PositiveProbability(this IRandom random, int numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakePositiveProbabilityGenerator(this IRandom random, int numerator)
		{
			return null;
		}

		public static int PositiveProbability(this IRandom random, uint numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakePositiveProbabilityGenerator(this IRandom random, uint numerator)
		{
			return null;
		}

		public static int PositiveProbability(this IRandom random, long numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakePositiveProbabilityGenerator(this IRandom random, long numerator)
		{
			return null;
		}

		public static int PositiveProbability(this IRandom random, ulong numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakePositiveProbabilityGenerator(this IRandom random, ulong numerator)
		{
			return null;
		}

		public static int PositiveProbability(this IRandom random, float probability)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakePositiveProbabilityGenerator(this IRandom random, float probability)
		{
			return null;
		}

		public static int PositiveProbability(this IRandom random, double probability)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakePositiveProbabilityGenerator(this IRandom random, double probability)
		{
			return null;
		}

		public static int PositiveProbability(this IRandom random, int numerator, int denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakePositiveProbabilityGenerator(this IRandom random, int numerator, int denominator)
		{
			return null;
		}

		public static int PositiveProbability(this IRandom random, uint numerator, uint denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakePositiveProbabilityGenerator(this IRandom random, uint numerator, uint denominator)
		{
			return null;
		}

		public static int PositiveProbability(this IRandom random, long numerator, long denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakePositiveProbabilityGenerator(this IRandom random, long numerator, long denominator)
		{
			return null;
		}

		public static int PositiveProbability(this IRandom random, ulong numerator, ulong denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakePositiveProbabilityGenerator(this IRandom random, ulong numerator, ulong denominator)
		{
			return null;
		}

		public static int PositiveProbability(this IRandom random, float numerator, float denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakePositiveProbabilityGenerator(this IRandom random, float numerator, float denominator)
		{
			return null;
		}

		public static int PositiveProbability(this IRandom random, double numerator, double denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakePositiveProbabilityGenerator(this IRandom random, double numerator, double denominator)
		{
			return null;
		}

		public static int NegativeProbability(this IRandom random, int numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeNegativeProbabilityGenerator(this IRandom random, int numerator)
		{
			return null;
		}

		public static int NegativeProbability(this IRandom random, uint numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeNegativeProbabilityGenerator(this IRandom random, uint numerator)
		{
			return null;
		}

		public static int NegativeProbability(this IRandom random, long numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeNegativeProbabilityGenerator(this IRandom random, long numerator)
		{
			return null;
		}

		public static int NegativeProbability(this IRandom random, ulong numerator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeNegativeProbabilityGenerator(this IRandom random, ulong numerator)
		{
			return null;
		}

		public static int NegativeProbability(this IRandom random, float probability)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeNegativeProbabilityGenerator(this IRandom random, float probability)
		{
			return null;
		}

		public static int NegativeProbability(this IRandom random, double probability)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeNegativeProbabilityGenerator(this IRandom random, double probability)
		{
			return null;
		}

		public static int NegativeProbability(this IRandom random, int numerator, int denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeNegativeProbabilityGenerator(this IRandom random, int numerator, int denominator)
		{
			return null;
		}

		public static int NegativeProbability(this IRandom random, uint numerator, uint denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeNegativeProbabilityGenerator(this IRandom random, uint numerator, uint denominator)
		{
			return null;
		}

		public static int NegativeProbability(this IRandom random, long numerator, long denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeNegativeProbabilityGenerator(this IRandom random, long numerator, long denominator)
		{
			return null;
		}

		public static int NegativeProbability(this IRandom random, ulong numerator, ulong denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeNegativeProbabilityGenerator(this IRandom random, ulong numerator, ulong denominator)
		{
			return null;
		}

		public static int NegativeProbability(this IRandom random, float numerator, float denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeNegativeProbabilityGenerator(this IRandom random, float numerator, float denominator)
		{
			return null;
		}

		public static int NegativeProbability(this IRandom random, double numerator, double denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeNegativeProbabilityGenerator(this IRandom random, double numerator, double denominator)
		{
			return null;
		}

		public static int SignProbability(this IRandom random, int numeratorPositive, int numeratorNegative)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignProbabilityGenerator(this IRandom random, int numeratorPositive, int numeratorNegative)
		{
			return null;
		}

		public static int SignProbability(this IRandom random, uint numeratorPositive, uint numeratorNegative)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignProbabilityGenerator(this IRandom random, uint numeratorPositive, uint numeratorNegative)
		{
			return null;
		}

		public static int SignProbability(this IRandom random, long numeratorPositive, long numeratorNegative)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignProbabilityGenerator(this IRandom random, long numeratorPositive, long numeratorNegative)
		{
			return null;
		}

		public static int SignProbability(this IRandom random, ulong numeratorPositive, ulong numeratorNegative)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignProbabilityGenerator(this IRandom random, ulong numeratorPositive, ulong numeratorNegative)
		{
			return null;
		}

		public static int SignProbability(this IRandom random, float probabilityPositive, float probabilityNegative)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignProbabilityGenerator(this IRandom random, float probabilityPositive, float probabilityNegative)
		{
			return null;
		}

		public static int SignProbability(this IRandom random, double probabilityPositive, double probabilityNegative)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignProbabilityGenerator(this IRandom random, double probabilityPositive, double probabilityNegative)
		{
			return null;
		}

		public static int SignProbability(this IRandom random, int numeratorPositive, int numeratorNegative, int denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignProbabilityGenerator(this IRandom random, int numeratorPositive, int numeratorNegative, int denominator)
		{
			return null;
		}

		public static int SignProbability(this IRandom random, uint numeratorPositive, uint numeratorNegative, uint denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignProbabilityGenerator(this IRandom random, uint numeratorPositive, uint numeratorNegative, uint denominator)
		{
			return null;
		}

		public static int SignProbability(this IRandom random, long numeratorPositive, long numeratorNegative, long denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignProbabilityGenerator(this IRandom random, long numeratorPositive, long numeratorNegative, long denominator)
		{
			return null;
		}

		public static int SignProbability(this IRandom random, ulong numeratorPositive, ulong numeratorNegative, ulong denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignProbabilityGenerator(this IRandom random, ulong numeratorPositive, ulong numeratorNegative, ulong denominator)
		{
			return null;
		}

		public static int SignProbability(this IRandom random, float numeratorPositive, float numeratorNegative, float denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignProbabilityGenerator(this IRandom random, float numeratorPositive, float numeratorNegative, float denominator)
		{
			return null;
		}

		public static int SignProbability(this IRandom random, double numeratorPositive, double numeratorNegative, double denominator)
		{
			return 0;
		}

		public static IRangeGenerator<int> MakeSignProbabilityGenerator(this IRandom random, double numeratorPositive, double numeratorNegative, double denominator)
		{
			return null;
		}
	}
}
