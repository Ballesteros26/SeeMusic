using System;
using UnityEngine;

namespace MakeIt.Random
{
	[Serializable]
	public sealed class XorShift128Plus : RandomBase, IEquatable<XorShift128Plus>
	{
		[SerializeField]
		private ulong _state0;

		[SerializeField]
		private ulong _state1;

		public override int stepBitCount => 0;

		public override int skipAheadMagnitude => 0;

		private XorShift128Plus()
		{
		}

		private static XorShift128Plus CreateUninitialized()
		{
			return null;
		}

		public static XorShift128Plus Create()
		{
			return null;
		}

		public static XorShift128Plus Create(int seed)
		{
			return null;
		}

		public static XorShift128Plus Create(params int[] seed)
		{
			return null;
		}

		public static XorShift128Plus Create(string seed)
		{
			return null;
		}

		public static XorShift128Plus Create(IBitGenerator bitGenerator)
		{
			return null;
		}

		public static XorShift128Plus CreateWithState(byte[] stateArray)
		{
			return null;
		}

		public static XorShift128Plus CreateWithState(uint state0, uint state1, uint state2, uint state3)
		{
			return null;
		}

		public static XorShift128Plus CreateWithState(ulong state0, ulong state1)
		{
			return null;
		}

		public XorShift128Plus Clone()
		{
			return null;
		}

		public void CopyStateFrom(XorShift128Plus source)
		{
		}

		public override byte[] SaveState()
		{
			return null;
		}

		public void SaveState(out uint state0, out uint state1, out uint state2, out uint state3)
		{
			state0 = default(uint);
			state1 = default(uint);
			state2 = default(uint);
			state3 = default(uint);
		}

		public void SaveState(out ulong state0, out ulong state1)
		{
			state0 = default(ulong);
			state1 = default(ulong);
		}

		public override void RestoreState(byte[] stateArray)
		{
		}

		public void RestoreState(uint state0, uint state1, uint state2, uint state3)
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

		public override void Next64(out uint lower, out uint upper)
		{
			lower = default(uint);
			upper = default(uint);
		}

		private void SkipAhead(ulong b, ref ulong x, ref ulong y)
		{
		}

		public override void SkipAhead()
		{
		}

		public override System.Random AsSystemRandom()
		{
			return null;
		}

		public static bool operator ==(XorShift128Plus lhs, XorShift128Plus rhs)
		{
			return false;
		}

		public static bool operator !=(XorShift128Plus lhs, XorShift128Plus rhs)
		{
			return false;
		}

		public bool Equals(XorShift128Plus other)
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
