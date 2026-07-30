using System;
using System.IO;

namespace MakeIt.Random
{
	public abstract class RandomBase : IRandom, IBitGenerator
	{
		public abstract int stepBitCount { get; }

		public virtual int skipAheadMagnitude => 0;

		public virtual int skipBackMagnitude => 0;

		public virtual byte[] SaveState()
		{
			return null;
		}

		public virtual void RestoreState(byte[] stateArray)
		{
		}

		public virtual void Seed()
		{
		}

		public virtual void Seed(int seed)
		{
		}

		public virtual void Seed(params int[] seed)
		{
		}

		public virtual void Seed(string seed)
		{
		}

		public abstract void Seed(IBitGenerator bitGenerator);

		public virtual void MergeSeed()
		{
		}

		public virtual void MergeSeed(int seed)
		{
		}

		public virtual void MergeSeed(params int[] seed)
		{
		}

		public virtual void MergeSeed(string seed)
		{
		}

		public abstract void MergeSeed(IBitGenerator bitGenerator);

		public virtual void Step()
		{
		}

		public virtual uint Next32()
		{
			return 0u;
		}

		public abstract ulong Next64();

		public virtual void Next64(out uint lower, out uint upper)
		{
			lower = default(uint);
			upper = default(uint);
		}

		public virtual void SkipAhead()
		{
		}

		public virtual void SkipBack()
		{
		}

		public virtual System.Random AsSystemRandom()
		{
			return null;
		}

		protected static void SaveState(BinaryWriter writer, byte stateElement)
		{
		}

		protected static void SaveState(BinaryWriter writer, uint stateElement)
		{
		}

		protected static void SaveState(BinaryWriter writer, ulong stateElement)
		{
		}

		protected static void RestoreState(BinaryReader reader, out byte stateElement)
		{
			stateElement = default(byte);
		}

		protected static void RestoreState(BinaryReader reader, out uint stateElement)
		{
			stateElement = default(uint);
		}

		protected static void RestoreState(BinaryReader reader, out ulong stateElement)
		{
			stateElement = default(ulong);
		}
	}
}
