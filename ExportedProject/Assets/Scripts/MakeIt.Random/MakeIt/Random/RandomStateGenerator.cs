using System;

namespace MakeIt.Random
{
	public class RandomStateGenerator : IBitGenerator, IEquatable<RandomStateGenerator>
	{
		private byte[] _seedData;

		private int _seedOffset;

		private int _seedOffsetIncrement;

		private int _callSeed;

		private static int _unstableSeed;

		private const int _internalSeedIncrement = -1511514573;

		private static readonly int[] _primeNumbers;

		private const uint _hashInitializer32 = 2166136261u;

		private const uint _hashMultiplier32 = 16777619u;

		private const ulong _hashInitializer64 = 14695981039346656037uL;

		private const ulong _hashMultiplier64 = 1099511628211uL;

		public RandomStateGenerator()
		{
		}

		public RandomStateGenerator(int seed)
		{
		}

		public RandomStateGenerator(uint seed)
		{
		}

		public RandomStateGenerator(long seed)
		{
		}

		public RandomStateGenerator(ulong seed)
		{
		}

		public RandomStateGenerator(float seed)
		{
		}

		public RandomStateGenerator(double seed)
		{
		}

		public RandomStateGenerator(params int[] seeds)
		{
		}

		public RandomStateGenerator(params uint[] seeds)
		{
		}

		public RandomStateGenerator(params long[] seeds)
		{
		}

		public RandomStateGenerator(params ulong[] seeds)
		{
		}

		public RandomStateGenerator(params float[] seeds)
		{
		}

		public RandomStateGenerator(params double[] seeds)
		{
		}

		public RandomStateGenerator(byte[] seedData)
		{
		}

		public RandomStateGenerator(string seed)
		{
		}

		private static int GetSeedOffsetIncrement(int seedLength)
		{
			return 0;
		}

		public uint Next32()
		{
			return 0u;
		}

		public ulong Next64()
		{
			return 0uL;
		}

		public virtual void Next64(out uint lower, out uint upper)
		{
			lower = default(uint);
			upper = default(uint);
		}

		public static bool operator ==(RandomStateGenerator lhs, RandomStateGenerator rhs)
		{
			return false;
		}

		public static bool operator !=(RandomStateGenerator lhs, RandomStateGenerator rhs)
		{
			return false;
		}

		public bool Equals(RandomStateGenerator other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
