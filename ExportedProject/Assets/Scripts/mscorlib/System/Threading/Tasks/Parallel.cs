using System.Collections;

namespace System.Threading.Tasks
{
	/// <summary>Provides support for parallel loops and regions.</summary>
	public static class Parallel
	{
		internal static int s_forkJoinContextID;

		internal static readonly ParallelOptions s_defaultParallelOptions;

		/// <summary>Executes each of the provided actions, possibly in parallel.</summary>
		/// <param name="actions">An array of <see cref="T:System.Action" /> to execute.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="actions" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">The exception that is thrown when any action in the <paramref name="actions" /> array throws an exception.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="actions" /> array contains a null element.</exception>
		public static void Invoke(params Action[] actions)
		{
		}

		/// <summary>Executes each of the provided actions, possibly in parallel, unless the operation is cancelled by the user.</summary>
		/// <param name="parallelOptions">An object that configures the behavior of this operation.</param>
		/// <param name="actions">An array of actions to execute.</param>
		/// <exception cref="T:System.OperationCanceledException">The <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> is set.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="actions" /> argument is null.-or-The <paramref name="parallelOptions" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">The exception that is thrown when any action in the <paramref name="actions" /> array throws an exception.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="actions" /> array contains a null element.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with the <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> has been disposed.</exception>
		public static void Invoke(ParallelOptions parallelOptions, params Action[] actions)
		{
		}

		/// <summary>Executes a for (For in Visual Basic) loop in which iterations may run in parallel and loop options can be configured.</summary>
		/// <returns>A  structure that contains information about which portion of the loop completed.</returns>
		/// <param name="fromInclusive">The start index, inclusive.</param>
		/// <param name="toExclusive">The end index, exclusive.</param>
		/// <param name="parallelOptions">An object that configures the behavior of this operation.</param>
		/// <param name="body">The delegate that is invoked once per iteration.</param>
		/// <exception cref="T:System.OperationCanceledException">The <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> argument is canceled.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="body" /> argument is null.-or-The <paramref name="parallelOptions" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">The exception that contains all the individual exceptions thrown on all threads.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with the <see cref="T:System.Threading.CancellationToken" /> in the <paramref name="parallelOptions" /> has been disposed.</exception>
		public static ParallelLoopResult For(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Action<int> body)
		{
			return default(ParallelLoopResult);
		}

		private static bool CheckTimeoutReached(int timeoutOccursAt)
		{
			return false;
		}

		private static int ComputeTimeoutPoint(int timeoutLength)
		{
			return 0;
		}

		private static ParallelLoopResult ForWorker<TLocal>(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Action<int> body, Action<int, ParallelLoopState> bodyWithState, Func<int, ParallelLoopState, TLocal, TLocal> bodyWithLocal, Func<TLocal> localInit, Action<TLocal> localFinally)
		{
			return default(ParallelLoopResult);
		}

		private static OperationCanceledException ReduceToSingleCancellationException(ICollection exceptions, CancellationToken cancelToken)
		{
			return null;
		}

		private static void ThrowSingleCancellationExceptionOrOtherException(ICollection exceptions, CancellationToken cancelToken, Exception otherException)
		{
		}
	}
}
