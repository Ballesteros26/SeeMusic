using System;
using UnityEngine;

namespace MakeIt.Random
{
	public sealed class UnityRandom : RandomBase
	{
		public override int stepBitCount => 0;

		private UnityRandom()
		{
		}

		private static UnityRandom CreateUninitialized()
		{
			return null;
		}

		public static UnityRandom Create()
		{
			return null;
		}

		public static UnityRandom Create(int seed)
		{
			return null;
		}

		public static UnityRandom Create(params int[] seed)
		{
			return null;
		}

		public static UnityRandom Create(string seed)
		{
			return null;
		}

		public static UnityRandom Create(IBitGenerator bitGenerator)
		{
			return null;
		}

		public static UnityRandom CreateWithState(byte[] stateArray)
		{
			return null;
		}

		public static UnityRandom CreateWithState(UnityEngine.Random.State state)
		{
			return null;
		}

		public UnityRandom Clone()
		{
			return null;
		}

		public void CopyStateFrom(UnityRandom source)
		{
		}

		public override byte[] SaveState()
		{
			return null;
		}

		public void SaveState(out UnityEngine.Random.State state)
		{
			state = default(UnityEngine.Random.State);
		}

		public override void RestoreState(byte[] stateArray)
		{
		}

		public void RestoreState(UnityEngine.Random.State state)
		{
		}

		public override void Seed(int seed)
		{
		}

		public override void Seed(IBitGenerator bitGenerator)
		{
		}

		public override void MergeSeed(IBitGenerator bitGenerator)
		{
		}

		public override void Step()
		{
		}

		public override uint Next32()
		{
			return 0u;
		}

		public override ulong Next64()
		{
			return 0uL;
		}

		public override System.Random AsSystemRandom()
		{
			return null;
		}

		public static bool operator ==(UnityRandom lhs, UnityRandom rhs)
		{
			return false;
		}

		public static bool operator !=(UnityRandom lhs, UnityRandom rhs)
		{
			return false;
		}

		public bool Equals(UnityRandom other)
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
