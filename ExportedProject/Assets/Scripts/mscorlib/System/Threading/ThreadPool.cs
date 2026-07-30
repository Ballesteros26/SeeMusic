using System.Runtime.CompilerServices;

namespace System.Threading
{
	/// <summary>Provides a pool of threads that can be used to execute tasks, post work items, process asynchronous I/O, wait on behalf of other threads, and process timers.</summary>
	/// <filterpriority>2</filterpriority>
	public static class ThreadPool
	{
		internal static bool IsThreadPoolThread => false;

		private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack)
		{
			return null;
		}

		/// <summary>Registers a delegate to wait for a <see cref="T:System.Threading.WaitHandle" />, specifying a 32-bit signed integer for the time-out in milliseconds.</summary>
		/// <returns>The <see cref="T:System.Threading.RegisteredWaitHandle" /> that encapsulates the native handle.</returns>
		/// <param name="waitObject">The <see cref="T:System.Threading.WaitHandle" /> to register. Use a <see cref="T:System.Threading.WaitHandle" /> other than <see cref="T:System.Threading.Mutex" />.</param>
		/// <param name="callBack">The <see cref="T:System.Threading.WaitOrTimerCallback" /> delegate to call when the <paramref name="waitObject" /> parameter is signaled. </param>
		/// <param name="state">The object that is passed to the delegate. </param>
		/// <param name="millisecondsTimeOutInterval">The time-out in milliseconds. If the <paramref name="millisecondsTimeOutInterval" /> parameter is 0 (zero), the function tests the object's state and returns immediately. If <paramref name="millisecondsTimeOutInterval" /> is -1, the function's time-out interval never elapses. </param>
		/// <param name="executeOnlyOnce">true to indicate that the thread will no longer wait on the <paramref name="waitObject" /> parameter after the delegate has been called; false to indicate that the timer is reset every time the wait operation completes until the wait is unregistered. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsTimeOutInterval" /> parameter is less than -1. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			return null;
		}

		/// <summary>Registers a delegate to wait for a <see cref="T:System.Threading.WaitHandle" />, specifying a <see cref="T:System.TimeSpan" /> value for the time-out.</summary>
		/// <returns>The <see cref="T:System.Threading.RegisteredWaitHandle" /> that encapsulates the native handle.</returns>
		/// <param name="waitObject">The <see cref="T:System.Threading.WaitHandle" /> to register. Use a <see cref="T:System.Threading.WaitHandle" /> other than <see cref="T:System.Threading.Mutex" />.</param>
		/// <param name="callBack">The <see cref="T:System.Threading.WaitOrTimerCallback" /> delegate to call when the <paramref name="waitObject" /> parameter is signaled. </param>
		/// <param name="state">The object passed to the delegate. </param>
		/// <param name="timeout">The time-out represented by a <see cref="T:System.TimeSpan" />. If <paramref name="timeout" /> is 0 (zero), the function tests the object's state and returns immediately. If <paramref name="timeout" /> is -1, the function's time-out interval never elapses. </param>
		/// <param name="executeOnlyOnce">true to indicate that the thread will no longer wait on the <paramref name="waitObject" /> parameter after the delegate has been called; false to indicate that the timer is reset every time the wait operation completes until the wait is unregistered. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="timeout" /> parameter is less than -1. </exception>
		/// <exception cref="T:System.NotSupportedException">The <paramref name="timeout" /> parameter is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce)
		{
			return null;
		}

		/// <summary>Queues a method for execution, and specifies an object containing data to be used by the method. The method executes when a thread pool thread becomes available.</summary>
		/// <returns>true if the method is successfully queued; <see cref="T:System.NotSupportedException" /> is thrown if the work item could not be queued.</returns>
		/// <param name="callBack">A <see cref="T:System.Threading.WaitCallback" /> representing the method to execute. </param>
		/// <param name="state">An object containing data to be used by the method. </param>
		/// <exception cref="T:System.NotSupportedException">The common language runtime (CLR) is hosted, and the host does not support this action.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="callBack" /> is null.</exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool QueueUserWorkItem(WaitCallback callBack, object state)
		{
			return false;
		}

		/// <summary>Queues a method for execution. The method executes when a thread pool thread becomes available.</summary>
		/// <returns>true if the method is successfully queued; <see cref="T:System.NotSupportedException" /> is thrown if the work item could not be queued.</returns>
		/// <param name="callBack">A <see cref="T:System.Threading.WaitCallback" /> that represents the method to be executed. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="callBack" /> is null.</exception>
		/// <exception cref="T:System.NotSupportedException">The common language runtime (CLR) is hosted, and the host does not support this action.</exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool QueueUserWorkItem(WaitCallback callBack)
		{
			return false;
		}

		/// <summary>Queues the specified delegate to the thread pool, but does not propagate the calling stack to the worker thread.</summary>
		/// <returns>true if the method succeeds; <see cref="T:System.OutOfMemoryException" /> is thrown if the work item could not be queued.</returns>
		/// <param name="callBack">A <see cref="T:System.Threading.WaitCallback" /> that represents the delegate to invoke when a thread in the thread pool picks up the work item. </param>
		/// <param name="state">The object that is passed to the delegate when serviced from the thread pool. </param>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ApplicationException">An out-of-memory condition was encountered.</exception>
		/// <exception cref="T:System.OutOfMemoryException">The work item could not be queued.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="callBack" /> is null.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, ControlPolicy" />
		/// </PermissionSet>
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state)
		{
			return false;
		}

		public static bool QueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal)
		{
			return false;
		}

		private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = true)
		{
			return false;
		}

		internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal)
		{
		}

		internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem)
		{
			return false;
		}

		internal static bool RequestWorkerThread()
		{
			return false;
		}

		private static void EnsureVMInitialized()
		{
		}

		internal static bool NotifyWorkItemComplete()
		{
			return false;
		}

		internal static void ReportThreadStatus(bool isWorking)
		{
		}

		internal static void NotifyWorkItemProgress()
		{
		}

		internal static void NotifyWorkItemProgressNative()
		{
		}

		internal static void NotifyWorkItemQueued()
		{
		}

		private static void InitializeVMTp(ref bool enableWorkerTracking)
		{
		}
	}
}
