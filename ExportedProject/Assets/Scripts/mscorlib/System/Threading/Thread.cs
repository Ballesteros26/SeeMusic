using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;

namespace System.Threading
{
	/// <summary>Creates and controls a thread, sets its priority, and gets its status. </summary>
	/// <filterpriority>1</filterpriority>
	[StructLayout((LayoutKind)0)]
	public sealed class Thread : CriticalFinalizerObject
	{
		private static LocalDataStoreMgr s_LocalDataStoreMgr;

		[ThreadStatic]
		private static LocalDataStoreHolder s_LocalDataStore;

		[ThreadStatic]
		internal static CultureInfo m_CurrentCulture;

		[ThreadStatic]
		internal static CultureInfo m_CurrentUICulture;

		private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture;

		private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture;

		private InternalThread internal_thread;

		private object m_ThreadStartArg;

		private object pending_exception;

		[ThreadStatic]
		private static Thread current_thread;

		private MulticastDelegate m_Delegate;

		private ExecutionContext m_ExecutionContext;

		private bool m_ExecutionContextBelongsToOuterScope;

		private IPrincipal principal;

		private int principal_version;

		internal bool ExecutionContextBelongsToCurrentScope
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the current culture used by the Resource Manager to look up culture-specific resources at run time.</summary>
		/// <returns>An object that represents the current culture.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is set to null. </exception>
		/// <exception cref="T:System.ArgumentException">The property is set to a culture name that cannot be used to locate a resource file. Resource filenames must include only letters, numbers, hyphens or underscores.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public CultureInfo CurrentUICulture => null;

		/// <summary>Gets or sets the culture for the current thread.</summary>
		/// <returns>An object that represents the culture for the current thread.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is set to null.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlThread" />
		/// </PermissionSet>
		public CultureInfo CurrentCulture => null;

		private InternalThread Internal => null;

		/// <summary>Gets the current context in which the thread is executing.</summary>
		/// <returns>A <see cref="T:System.Runtime.Remoting.Contexts.Context" /> representing the current thread context.</returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public static Context CurrentContext => null;

		/// <summary>Gets the currently running thread.</summary>
		/// <returns>A <see cref="T:System.Threading.Thread" /> that is the representation of the currently running thread.</returns>
		/// <filterpriority>1</filterpriority>
		public static Thread CurrentThread
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
			get
			{
				return null;
			}
		}

		internal static int CurrentThreadId => 0;

		/// <summary>Gets a value indicating whether or not a thread belongs to the managed thread pool.</summary>
		/// <returns>true if this thread belongs to the managed thread pool; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		public bool IsThreadPoolThread => false;

		internal bool IsThreadPoolThreadInternal => false;

		/// <summary>Gets a value indicating the execution status of the current thread.</summary>
		/// <returns>true if this thread has been started and has not terminated normally or aborted; otherwise, false.</returns>
		/// <filterpriority>1</filterpriority>
		public bool IsAlive => false;

		/// <summary>Gets or sets a value indicating whether or not a thread is a background thread.</summary>
		/// <returns>true if this thread is or is to become a background thread; otherwise, false.</returns>
		/// <exception cref="T:System.Threading.ThreadStateException">The thread is dead. </exception>
		/// <filterpriority>1</filterpriority>
		public bool IsBackground
		{
			set
			{
			}
		}

		/// <summary>Gets or sets the name of the thread.</summary>
		/// <returns>A string containing the name of the thread, or null if no name was set.</returns>
		/// <exception cref="T:System.InvalidOperationException">A set operation was requested, and the Name property has already been set. </exception>
		/// <filterpriority>1</filterpriority>
		public string Name
		{
			set
			{
			}
		}

		/// <summary>Gets a unique identifier for the current managed thread.</summary>
		/// <returns>An integer that represents a unique identifier for this managed thread.</returns>
		/// <filterpriority>1</filterpriority>
		public int ManagedThreadId
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return 0;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Thread" /> class.</summary>
		/// <param name="start">A <see cref="T:System.Threading.ThreadStart" /> delegate that represents the methods to be invoked when this thread begins executing. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="start" /> parameter is null. </exception>
		public Thread(ThreadStart start)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Thread" /> class, specifying a delegate that allows an object to be passed to the thread when the thread is started.</summary>
		/// <param name="start">A <see cref="T:System.Threading.ParameterizedThreadStart" /> delegate that represents the methods to be invoked when this thread begins executing.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="start" /> is null. </exception>
		public Thread(ParameterizedThreadStart start)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Thread" /> class, specifying a delegate that allows an object to be passed to the thread when the thread is started and specifying the maximum stack size for the thread.</summary>
		/// <param name="start">A <see cref="T:System.Threading.ParameterizedThreadStart" /> delegate that represents the methods to be invoked when this thread begins executing.</param>
		/// <param name="maxStackSize">The maximum stack size, in bytes, to be used by the thread, or 0 to use the default maximum stack size specified in the header for the executable.Important   For partially trusted code, <paramref name="maxStackSize" /> is ignored if it is greater than the default stack size. No exception is thrown.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="start" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="maxStackSize" /> is less than zero.</exception>
		public Thread(ParameterizedThreadStart start, int maxStackSize)
		{
		}

		/// <summary>Causes the operating system to change the state of the current instance to <see cref="F:System.Threading.ThreadState.Running" />.</summary>
		/// <exception cref="T:System.Threading.ThreadStateException">The thread has already been started. </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is not enough memory available to start this thread. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
		}

		/// <summary>Causes the operating system to change the state of the current instance to <see cref="F:System.Threading.ThreadState.Running" />, and optionally supplies an object containing data to be used by the method the thread executes.</summary>
		/// <param name="parameter">An object that contains data to be used by the method the thread executes.</param>
		/// <exception cref="T:System.Threading.ThreadStateException">The thread has already been started. </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is not enough memory available to start this thread. </exception>
		/// <exception cref="T:System.InvalidOperationException">This thread was created using a <see cref="T:System.Threading.ThreadStart" /> delegate instead of a <see cref="T:System.Threading.ParameterizedThreadStart" /> delegate.</exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start(object parameter)
		{
		}

		private void Start(ref StackCrawlMark stackMark)
		{
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal ExecutionContext.Reader GetExecutionContextReader()
		{
			return default(ExecutionContext.Reader);
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal ExecutionContext GetMutableExecutionContext()
		{
			return null;
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope)
		{
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope)
		{
		}

		private bool JoinInternal(int millisecondsTimeout)
		{
			return false;
		}

		/// <summary>Blocks the calling thread until a thread terminates, while continuing to perform standard COM and SendMessage pumping.</summary>
		/// <exception cref="T:System.Threading.ThreadStateException">The caller attempted to join a thread that is in the <see cref="F:System.Threading.ThreadState.Unstarted" /> state. </exception>
		/// <exception cref="T:System.Threading.ThreadInterruptedException">The thread is interrupted while waiting. </exception>
		/// <filterpriority>1</filterpriority>
		public void Join()
		{
		}

		/// <summary>Blocks the calling thread until a thread terminates or the specified time elapses, while continuing to perform standard COM and SendMessage pumping.</summary>
		/// <returns>true if the thread has terminated; false if the thread has not terminated after the amount of time specified by the <paramref name="millisecondsTimeout" /> parameter has elapsed.</returns>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait for the thread to terminate. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="millisecondsTimeout" /> is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> in milliseconds. </exception>
		/// <exception cref="T:System.Threading.ThreadStateException">The thread has not been started. </exception>
		/// <filterpriority>1</filterpriority>
		public bool Join(int millisecondsTimeout)
		{
			return false;
		}

		private static void SleepInternal(int millisecondsTimeout)
		{
		}

		/// <summary>Suspends the current thread for a specified time.</summary>
		/// <param name="millisecondsTimeout">The number of milliseconds for which the thread is blocked. Specify zero (0) to indicate that this thread should be suspended to allow other waiting threads to execute. Specify <see cref="F:System.Threading.Timeout.Infinite" /> to block the thread indefinitely. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The time-out value is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static void Sleep(int millisecondsTimeout)
		{
		}

		/// <summary>Blocks the current thread for a specified time.</summary>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> set to the amount of time for which the thread is blocked. Specify zero to indicate that this thread should be suspended to allow other waiting threads to execute. Specify <see cref="F:System.Threading.Timeout.Infinite" /> to block the thread indefinitely. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="timeout" /> is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> in milliseconds, or is greater than <see cref="F:System.Int32.MaxValue" /> milliseconds. </exception>
		/// <filterpriority>1</filterpriority>
		public static void Sleep(TimeSpan timeout)
		{
		}

		private static bool YieldInternal()
		{
			return false;
		}

		/// <summary>Causes the calling thread to yield execution to another thread that is ready to run on the current processor. The operating system selects the thread to yield to.</summary>
		/// <returns>true if the operating system switched execution to another thread; otherwise, false.</returns>
		public static bool Yield()
		{
			return false;
		}

		private void SetStartHelper(Delegate start, int maxStackSize)
		{
		}

		internal CultureInfo GetCurrentUICultureNoAppX()
		{
			return null;
		}

		private CultureInfo GetCurrentCultureNoAppX()
		{
			return null;
		}

		/// <summary>Synchronizes memory access as follows: The processor executing the current thread cannot reorder instructions in such a way that memory accesses prior to the call to <see cref="M:System.Threading.Thread.MemoryBarrier" /> execute after memory accesses that follow the call to <see cref="M:System.Threading.Thread.MemoryBarrier" />.</summary>
		/// <filterpriority>2</filterpriority>
		public static void MemoryBarrier()
		{
		}

		private void ConstructInternalThread()
		{
		}

		private static void GetCurrentThread_icall(ref Thread thread)
		{
		}

		private static Thread GetCurrentThread()
		{
			return null;
		}

		/// <summary>Returns a unique application domain identifier.</summary>
		/// <returns>A 32-bit signed integer uniquely identifying the application domain.</returns>
		/// <filterpriority>2</filterpriority>
		public static int GetDomainID()
		{
			return 0;
		}

		private bool Thread_internal(MulticastDelegate start)
		{
			return false;
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		~Thread()
		{
		}

		private unsafe static void SetName_icall(InternalThread thread, char* name, int nameLength)
		{
		}

		private static void SetName_internal(InternalThread thread, string name)
		{
		}

		private static void Abort_internal(InternalThread thread, object stateInfo)
		{
		}

		/// <summary>Raises a <see cref="T:System.Threading.ThreadAbortException" /> in the thread on which it is invoked, to begin the process of terminating the thread. Calling this method usually terminates the thread.</summary>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.Threading.ThreadStateException">The thread that is being aborted is currently suspended.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlThread" />
		/// </PermissionSet>
		public void Abort()
		{
		}

		private static void SpinWait_nop()
		{
		}

		/// <summary>Causes a thread to wait the number of times defined by the <paramref name="iterations" /> parameter.</summary>
		/// <param name="iterations">A 32-bit signed integer that defines how long a thread is to wait. </param>
		/// <filterpriority>1</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void SpinWait(int iterations)
		{
		}

		private void StartInternal(object principal, ref StackCrawlMark stackMark)
		{
		}

		private static void SetState(InternalThread thread, ThreadState set)
		{
		}

		private static void ClrState(InternalThread thread, ThreadState clr)
		{
		}

		private static ThreadState GetState(InternalThread thread)
		{
			return default(ThreadState);
		}

		private static int SystemMaxStackStize()
		{
			return 0;
		}

		private static int GetProcessDefaultStackSize(int maxStackSize)
		{
			return 0;
		}

		private void SetStart(MulticastDelegate start, int maxStackSize)
		{
		}

		/// <summary>Notifies a host that execution is about to enter a region of code in which the effects of a thread abort or unhandled exception might jeopardize other tasks in the application domain.</summary>
		/// <filterpriority>2</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void BeginCriticalRegion()
		{
		}

		/// <summary>Notifies a host that execution is about to enter a region of code in which the effects of a thread abort or unhandled exception are limited to the current task.</summary>
		/// <filterpriority>2</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void EndCriticalRegion()
		{
		}

		/// <summary>Returns a hash code for the current thread.</summary>
		/// <returns>An integer hash code value.</returns>
		/// <filterpriority>2</filterpriority>
		[ComVisible(false)]
		public override int GetHashCode()
		{
			return 0;
		}

		private ThreadState ValidateThreadState()
		{
			return default(ThreadState);
		}
	}
}
