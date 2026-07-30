namespace Microsoft.CSharp.RuntimeBinder.Syntax
{
	internal sealed class NameTable
	{
		private sealed class Entry
		{
			public readonly Name Name;

			public readonly int HashCode;

			public Entry Next;

			public Entry(Name name, int hashCode, Entry next)
			{
			}
		}

		private Entry[] _entries;

		private int _count;

		private int _mask;

		internal NameTable()
		{
		}

		public Name Add(string key)
		{
			return null;
		}

		public Name Add(string key, int length)
		{
			return null;
		}

		internal void Add(Name name)
		{
		}

		private static int ComputeHashCode(string key)
		{
			return 0;
		}

		private static int ComputeHashCode(string key, int length)
		{
			return 0;
		}

		private static bool Equals(string candidate, string key, int length)
		{
			return false;
		}

		private Name AddEntry(Name name, int hashCode)
		{
			return null;
		}

		private void Grow()
		{
		}
	}
}
