using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Parse.Common.Internal
{
	public class SynchronizedEventHandler<T>
	{
		private LinkedList<Tuple<Delegate, TaskFactory>> delegates;

		public void Add(Delegate del)
		{
		}

		public void Remove(Delegate del)
		{
		}

		public Task Invoke(object sender, T args)
		{
			return null;
		}
	}
}
