using System;
using UnityEngine;

namespace MakeIt.Random
{
	[Serializable]
	public sealed class XoroShiro128Plus : RandomBase, IEquatable<XoroShiro128Plus>
	{
		[SerializeField]
		private ulong _state0;

		[SerializeField]
		private ulong _state1;

		public override int stepBitCount => 0;

		public override int skipAheadMagnitude => 0;

		private XoroShiro128Plus()
		{
		}

		private static XoroShiro128Plus CreateUninitialized()
		{
			return null;
		}

		public static XoroShiro128Plus Create()
		{
			return null;
		}

		public static XoroShiro128Plus Create(int seed)
		{
			return null;
		}

		public static XoroShiro128Plus Create(params int[] seed)
		{
			return null;
		}

		public static XoroShiro128Plus Create(string seed)
		{
			return null;
		}

		public static XoroShiro128Plus Create(IBitGenerator bitGenerator)
		{
			return null;
		}

		public static XoroShiro128Plus CreateWithState(byte[] stateArray)
		{
			return null;
		}

		public static XoroShiro128Plus CreateWithState(ulong state0, ulong state1)
		{
			return null;
		}

		public XoroShiro128Plus Clone()
		{
			return null;
		}

		public void CopyStateFrom(XoroShiro128Plus source)
		{
		}

		public override byte[] SaveState()
		{
			return null;
		}

		public void SaveState(out ulong state0, out ulong state1)
		{
			state0 = default(ulong);
			state1 = default(ulong);
		}

		public override void RestoreState(byte[] stateArray)
		{
		}

		public void RestoreState(ulong state0, ulong state1)
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

		public override void SkipAhead()
		{
		}

		public override System.Random AsSystemRandom()
		{
			return null;
		}

		public bool Equals(XoroShiro128Plus other)
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
