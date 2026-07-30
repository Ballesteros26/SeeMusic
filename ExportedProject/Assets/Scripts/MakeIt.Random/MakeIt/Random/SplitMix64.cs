using System;
using UnityEngine;

namespace MakeIt.Random
{
	[Serializable]
	public sealed class SplitMix64 : RandomBase, IEquatable<SplitMix64>
	{
		[SerializeField]
		private ulong _state;

		public override int stepBitCount => 0;

		private SplitMix64()
		{
		}

		private static SplitMix64 CreateUninitialized()
		{
			return null;
		}

		public static SplitMix64 Create()
		{
			return null;
		}

		public static SplitMix64 Create(int seed)
		{
			return null;
		}

		public static SplitMix64 Create(params int[] seed)
		{
			return null;
		}

		public static SplitMix64 Create(string seed)
		{
			return null;
		}

		public static SplitMix64 Create(IBitGenerator bitGenerator)
		{
			return null;
		}

		public static SplitMix64 CreateWithState(byte[] stateArray)
		{
			return null;
		}

		public static SplitMix64 CreateWithState(ulong state)
		{
			return null;
		}

		public SplitMix64 Clone()
		{
			return null;
		}

		public void CopyStateFrom(SplitMix64 source)
		{
		}

		public override byte[] SaveState()
		{
			return null;
		}

		public void SaveState(out ulong state)
		{
			state = default(ulong);
		}

		public override void RestoreState(byte[] stateArray)
		{
		}

		public void RestoreState(ulong state)
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

		public static bool operator ==(SplitMix64 lhs, SplitMix64 rhs)
		{
			return false;
		}

		public static bool operator !=(SplitMix64 lhs, SplitMix64 rhs)
		{
			return false;
		}

		public bool Equals(SplitMix64 other)
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
