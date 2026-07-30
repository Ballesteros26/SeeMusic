using System;
using UnityEngine;

namespace MakeIt.Random
{
	[Serializable]
	public sealed class SystemRandom : RandomBase, IEquatable<SystemRandom>, IEquatable<System.Random>
	{
		[SerializeField]
		private System.Random _random;

		public override int stepBitCount => 0;

		private SystemRandom()
		{
		}

		private static SystemRandom CreateUninitialized()
		{
			return null;
		}

		public static SystemRandom Create()
		{
			return null;
		}

		public static SystemRandom Create(int seed)
		{
			return null;
		}

		public static SystemRandom Create(params int[] seed)
		{
			return null;
		}

		public static SystemRandom Create(string seed)
		{
			return null;
		}

		public static SystemRandom Create(IBitGenerator bitGenerator)
		{
			return null;
		}

		public static SystemRandom CreateWithState(byte[] stateArray)
		{
			return null;
		}

		public SystemRandom Clone()
		{
			return null;
		}

		public void CopyStateFrom(SystemRandom source)
		{
		}

		public override byte[] SaveState()
		{
			return null;
		}

		public override void RestoreState(byte[] stateArray)
		{
		}

		public override void Seed()
		{
		}

		public override void Seed(int seed)
		{
		}

		public override void Seed(IBitGenerator bitGenerator)
		{
		}

		public override void MergeSeed()
		{
		}

		public override void MergeSeed(int seed)
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

		public static bool operator ==(SystemRandom lhs, SystemRandom rhs)
		{
			return false;
		}

		public static bool operator !=(SystemRandom lhs, SystemRandom rhs)
		{
			return false;
		}

		public bool Equals(SystemRandom other)
		{
			return false;
		}

		public bool Equals(System.Random other)
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
