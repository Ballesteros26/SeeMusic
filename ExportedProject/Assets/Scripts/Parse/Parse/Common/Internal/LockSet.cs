using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Parse.Common.Internal
{
	public class LockSet
	{
		private static readonly ConditionalWeakTable<object, IComparable> stableIds;

		private static long nextStableId;

		private readonly IEnumerable<object> mutexes;

		public LockSet(IEnumerable<object> mutexes)
		{
		}

		public void Enter()
		{
		}

		public void Exit()
		{
		}

		private static IComparable GetStableId(object mutex)
		{
			return null;
		}
	}
}
