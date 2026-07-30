using System;
using UnityEngine;

namespace MakeIt.Random
{
	[Serializable]
	public sealed class XorShiftAdd : RandomBase, IEquatable<XorShiftAdd>
	{
		[SerializeField]
		private uint _state0;

		[SerializeField]
		private uint _state1;

		[SerializeField]
		private uint _state2;

		[SerializeField]
		private uint _state3;

		public override int stepBitCount => 0;

		public override int skipAheadMagnitude => 0;

		private XorShiftAdd()
		{
		}

		private static XorShiftAdd CreateUninitialized()
		{
			return null;
		}

		public static XorShiftAdd Create()
		{
			return null;
		}

		public static XorShiftAdd Create(int seed)
		{
			return null;
		}

		public static XorShiftAdd Create(params int[] seed)
		{
			return null;
		}

		public static XorShiftAdd Create(string seed)
		{
			return null;
		}

		public static XorShiftAdd Create(IBitGenerator bitGenerator)
		{
			return null;
		}

		public static XorShiftAdd CreateWithState(byte[] stateArray)
		{
			return null;
		}

		public static XorShiftAdd CreateWithState(uint state0, uint state1, uint state2, uint state3)
		{
			return null;
		}

		public XorShiftAdd Clone()
		{
			return null;
		}

		public void CopyStateFrom(XorShiftAdd source)
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

		public override void RestoreState(byte[] stateArray)
		{
		}

		public void RestoreState(uint state0, uint state1, uint state2, uint state3)
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

		private void SkipAhead(uint b, ref uint x0, ref uint x1, ref uint x2, ref uint x3)
		{
		}

		public override void SkipAhead()
		{
		}

		public override System.Random AsSystemRandom()
		{
			return null;
		}

		public static bool operator ==(XorShiftAdd lhs, XorShiftAdd rhs)
		{
			return false;
		}

		public static bool operator !=(XorShiftAdd lhs, XorShiftAdd rhs)
		{
			return false;
		}

		public bool Equals(XorShiftAdd other)
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
