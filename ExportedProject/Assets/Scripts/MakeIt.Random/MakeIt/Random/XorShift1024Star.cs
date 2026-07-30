using System;
using UnityEngine;

namespace MakeIt.Random
{
	[Serializable]
	public sealed class XorShift1024Star : RandomBase, IEquatable<XorShift1024Star>
	{
		[SerializeField]
		private ulong[] _state;

		[SerializeField]
		private int _offset;

		private static readonly ulong[] _jumpTable;

		public override int stepBitCount => 0;

		public override int skipAheadMagnitude => 0;

		private XorShift1024Star()
		{
		}

		private static XorShift1024Star CreateUninitialized()
		{
			return null;
		}

		public static XorShift1024Star Create()
		{
			return null;
		}

		public static XorShift1024Star Create(int seed)
		{
			return null;
		}

		public static XorShift1024Star Create(params int[] seed)
		{
			return null;
		}

		public static XorShift1024Star Create(string seed)
		{
			return null;
		}

		public static XorShift1024Star Create(IBitGenerator bitGenerator)
		{
			return null;
		}

		public static XorShift1024Star CreateWithState(byte[] stateArray)
		{
			return null;
		}

		public static XorShift1024Star CreateWithState(ulong[] state, int offset)
		{
			return null;
		}

		public XorShift1024Star Clone()
		{
			return null;
		}

		public void CopyStateFrom(XorShift1024Star source)
		{
		}

		public override byte[] SaveState()
		{
			return null;
		}

		public void SaveState(out ulong[] state, out int offset)
		{
			state = null;
			offset = default(int);
		}

		public override void RestoreState(byte[] stateArray)
		{
		}

		public void RestoreState(ulong[] state, int offset)
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

		public static bool operator ==(XorShift1024Star lhs, XorShift1024Star rhs)
		{
			return false;
		}

		public static bool operator !=(XorShift1024Star lhs, XorShift1024Star rhs)
		{
			return false;
		}

		public bool Equals(XorShift1024Star other)
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
