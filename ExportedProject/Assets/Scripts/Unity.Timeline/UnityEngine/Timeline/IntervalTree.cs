using System.Collections.Generic;

namespace UnityEngine.Timeline
{
	internal class IntervalTree<T> where T : IInterval
	{
		internal struct Entry
		{
			public long intervalStart;

			public long intervalEnd;

			public T item;
		}

		private readonly List<Entry> m_Entries;

		private readonly List<IntervalTreeNode> m_Nodes;

		public bool dirty { get; internal set; }

		public void Add(T item)
		{
		}

		public void IntersectsWith(long value, List<T> results)
		{
		}

		private void Query(IntervalTreeNode intervalTreeNode, long value, List<T> results)
		{
		}

		private void Rebuild()
		{
		}

		private int Rebuild(int start, int end)
		{
			return 0;
		}
	}
}
