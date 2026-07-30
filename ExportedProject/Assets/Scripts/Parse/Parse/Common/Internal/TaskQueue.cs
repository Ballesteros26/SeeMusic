using System;
using System.Threading;
using System.Threading.Tasks;

namespace Parse.Common.Internal
{
	public class TaskQueue
	{
		private Task tail;

		private readonly object mutex;

		public object Mutex => null;

		private Task GetTaskToAwait(CancellationToken cancellationToken)
		{
			return null;
		}

		public T Enqueue<T>(Func<Task, T> taskStart, CancellationToken cancellationToken = default(CancellationToken)) where T : Task
		{
			return null;
		}
	}
}
