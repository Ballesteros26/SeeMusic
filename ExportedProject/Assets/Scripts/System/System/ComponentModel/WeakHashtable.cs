using System.Collections;

namespace System.ComponentModel
{
	internal sealed class WeakHashtable : Hashtable
	{
		private class WeakKeyComparer : IEqualityComparer
		{
			bool IEqualityComparer.Equals(object x, object y)
			{
				return false;
			}

			int IEqualityComparer.GetHashCode(object obj)
			{
				return 0;
			}
		}

		private static IEqualityComparer _comparer;

		internal WeakHashtable()
		{
		}

		public override void Clear()
		{
		}

		public override void Remove(object key)
		{
		}
	}
}
