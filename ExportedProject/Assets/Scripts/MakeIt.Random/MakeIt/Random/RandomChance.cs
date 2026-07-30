using MakeIt.Random.Detail;

namespace MakeIt.Random
{
	public static class RandomChance
	{
		private class UniformChanceGenerator : BufferedBitGenerator, IBooleanGenerator
		{
			public UniformChanceGenerator(IRandom random)
				: base(null)
			{
			}

			public bool Next()
			{
				return false;
			}
		}

		private class IntWeightedProbabilityGenerator : IBooleanGenerator
		{
			private IRangeGenerator<int> _rangeGenerator;

			private int _numerator;

			public IntWeightedProbabilityGenerator(IRandom random, int numerator)
			{
			}

			public IntWeightedProbabilityGenerator(IRandom random, int numerator, int denominator)
			{
			}

			public bool Next()
			{
				return false;
			}
		}

		private class UIntWeightedProbabilityGenerator : IBooleanGenerator
		{
			private IRangeGenerator<uint> _rangeGenerator;

			private uint _numerator;

			public UIntWeightedProbabilityGenerator(IRandom random, uint numerator)
			{
			}

			public UIntWeightedProbabilityGenerator(IRandom random, uint numerator, uint denominator)
			{
			}

			public bool Next()
			{
				return false;
			}
		}

		private class LongWeightedProbabilityGenerator : IBooleanGenerator
		{
			private IRangeGenerator<long> _rangeGenerator;

			private long _numerator;

			public LongWeightedProbabilityGenerator(IRandom random, long numerator)
			{
			}

			public LongWeightedProbabilityGenerator(IRandom random, long numerator, long denominator)
			{
			}

			public bool Next()
			{
				return false;
			}
		}

		private class ULongWeightedProbabilityGenerator : IBooleanGenerator
		{
			private IRangeGenerator<ulong> _rangeGenerator;

			private ulong _numerator;

			public ULongWeightedProbabilityGenerator(IRandom random, ulong numerator)
			{
			}

			public ULongWeightedProbabilityGenerator(IRandom random, ulong numerator, ulong denominator)
			{
			}

			public bool Next()
			{
				return false;
			}
		}

		private class FloatWeightedProbabilityGenerator : IBooleanGenerator
		{
			private IRangeGenerator<float> _rangeGenerator;

			private float _numerator;

			public FloatWeightedProbabilityGenerator(IRandom random, float numerator)
			{
			}

			public FloatWeightedProbabilityGenerator(IRandom random, float numerator, float denominator)
			{
			}

			public bool Next()
			{
				return false;
			}
		}

		private class DoubleWeightedProbabilityGenerator : IBooleanGenerator
		{
			private IRangeGenerator<double> _rangeGenerator;

			private double _numerator;

			public DoubleWeightedProbabilityGenerator(IRandom random, double numerator)
			{
			}

			public DoubleWeightedProbabilityGenerator(IRandom random, double numerator, double denominator)
			{
			}

			public bool Next()
			{
				return false;
			}
		}

		public static bool Chance(this IRandom random)
		{
			return false;
		}

		public static IBooleanGenerator MakeChanceGenerator(this IRandom random)
		{
			return null;
		}

		public static bool Chance(this IRandom random, int ratioTrue, int ratioFalse)
		{
			return false;
		}

		public static IBooleanGenerator MakeChanceGenerator(this IRandom random, int ratioTrue, int ratioFalse)
		{
			return null;
		}

		public static bool Chance(this IRandom random, uint ratioTrue, uint ratioFalse)
		{
			return false;
		}

		public static IBooleanGenerator MakeChanceGenerator(this IRandom random, uint ratioTrue, uint ratioFalse)
		{
			return null;
		}

		public static bool Chance(this IRandom random, long ratioTrue, long ratioFalse)
		{
			return false;
		}

		public static IBooleanGenerator MakeChanceGenerator(this IRandom random, long ratioTrue, long ratioFalse)
		{
			return null;
		}

		public static bool Chance(this IRandom random, ulong ratioTrue, ulong ratioFalse)
		{
			return false;
		}

		public static IBooleanGenerator MakeChanceGenerator(this IRandom random, ulong ratioTrue, ulong ratioFalse)
		{
			return null;
		}

		public static bool Chance(this IRandom random, float ratioTrue, float ratioFalse)
		{
			return false;
		}

		public static IBooleanGenerator MakeChanceGenerator(this IRandom random, float ratioTrue, float ratioFalse)
		{
			return null;
		}

		public static bool Chance(this IRandom random, double ratioTrue, double ratioFalse)
		{
			return false;
		}

		public static IBooleanGenerator MakeChanceGenerator(this IRandom random, double ratioTrue, double ratioFalse)
		{
			return null;
		}

		public static bool Probability(this IRandom random, int numerator)
		{
			return false;
		}

		public static IBooleanGenerator MakeProbabilityGenerator(this IRandom random, int numerator)
		{
			return null;
		}

		public static bool Probability(this IRandom random, uint numerator)
		{
			return false;
		}

		public static IBooleanGenerator MakeProbabilityGenerator(this IRandom random, uint numerator)
		{
			return null;
		}

		public static bool Probability(this IRandom random, long numerator)
		{
			return false;
		}

		public static IBooleanGenerator MakeProbabilityGenerator(this IRandom random, long numerator)
		{
			return null;
		}

		public static bool Probability(this IRandom random, ulong numerator)
		{
			return false;
		}

		public static IBooleanGenerator MakeProbabilityGenerator(this IRandom random, ulong numerator)
		{
			return null;
		}

		public static bool Probability(this IRandom random, float probability)
		{
			return false;
		}

		public static IBooleanGenerator MakeProbabilityGenerator(this IRandom random, float probability)
		{
			return null;
		}

		public static bool Probability(this IRandom random, double probability)
		{
			return false;
		}

		public static IBooleanGenerator MakeProbabilityGenerator(this IRandom random, double probability)
		{
			return null;
		}

		public static bool Probability(this IRandom random, int numerator, int denominator)
		{
			return false;
		}

		public static IBooleanGenerator MakeProbabilityGenerator(this IRandom random, int numerator, int denominator)
		{
			return null;
		}

		public static bool Probability(this IRandom random, uint numerator, uint denominator)
		{
			return false;
		}

		public static IBooleanGenerator MakeProbabilityGenerator(this IRandom random, uint numerator, uint denominator)
		{
			return null;
		}

		public static bool Probability(this IRandom random, long numerator, long denominator)
		{
			return false;
		}

		public static IBooleanGenerator MakeProbabilityGenerator(this IRandom random, long numerator, long denominator)
		{
			return null;
		}

		public static bool Probability(this IRandom random, ulong numerator, ulong denominator)
		{
			return false;
		}

		public static IBooleanGenerator MakeProbabilityGenerator(this IRandom random, ulong numerator, ulong denominator)
		{
			return null;
		}

		public static bool Probability(this IRandom random, float numerator, float denominator)
		{
			return false;
		}

		public static IBooleanGenerator MakeProbabilityGenerator(this IRandom random, float numerator, float denominator)
		{
			return null;
		}

		public static bool Probability(this IRandom random, double numerator, double denominator)
		{
			return false;
		}

		public static IBooleanGenerator MakeProbabilityGenerator(this IRandom random, double numerator, double denominator)
		{
			return null;
		}
	}
}
