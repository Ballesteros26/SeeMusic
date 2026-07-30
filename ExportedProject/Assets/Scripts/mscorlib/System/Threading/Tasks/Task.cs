using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace System.Threading.Tasks
{
	/// <summary>Represents an asynchronous operation that can return a value.</summary>
	/// <typeparam name="TResult">The type of the result produced by this <see cref="T:System.Threading.Tasks.Task`1" />. </typeparam>
	[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
	[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<>))]
	public class Task<TResult> : Task
	{
		internal TResult m_result;

		private static TaskFactory<TResult> s_defaultFactory;

		/// <summary>Gets the result value of this <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <returns>The result value of this <see cref="T:System.Threading.Tasks.Task`1" />, which is the same type as the task's type parameter.</returns>
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public TResult Result => default(TResult);

		internal TResult ResultOnSuccess => default(TResult);

		/// <summary>Provides access to factory methods for creating <see cref="T:System.Threading.Tasks.Task`1" /> instances.</summary>
		/// <returns>A default instance of <see cref="T:System.Threading.Tasks.TaskFactory`1" />.</returns>
		public new static TaskFactory<TResult> Factory => null;

		internal Task()
			: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
		{
		}

		internal Task(object state, TaskCreationOptions options)
			: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
		{
		}

		internal Task(TResult result)
			: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
		{
		}

		internal Task(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct)
			: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
		{
		}

		/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task`1" /> with the specified action, state, and options.</summary>
		/// <param name="function">The delegate that represents the code to execute in the task. When the function has completed, the task's <see cref="P:System.Threading.Tasks.Task`1.Result" /> property will be set to return the result value of the function.</param>
		/// <param name="state">An object representing data to be used by the function.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> to be assigned to the new task.</param>
		/// <param name="creationOptions">The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to customize the task's behavior.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created<paramref name=" cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> argument is null.</exception>
		public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
			: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
		{
		}

		internal Task(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
			: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
		{
		}

		internal Task(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
			: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
		{
		}

		internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			return null;
		}

		internal static Task<TResult> StartNew(Task parent, Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			return null;
		}

		internal bool TrySetResult(TResult result)
		{
			return false;
		}

		internal void DangerousSetResult(TResult result)
		{
		}

		internal TResult GetResultCore(bool waitCompletionNotification)
		{
			return default(TResult);
		}

		internal override void InnerInvoke()
		{
		}

		/// <summary>Gets an awaiter used to await this <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <returns>An awaiter instance.</returns>
		public new TaskAwaiter<TResult> GetAwaiter()
		{
			return default(TaskAwaiter<TResult>);
		}

		/// <summary>Configures an awaiter used to await this <see cref="T:System.Threading.Tasks.Task`1" />.</summary>
		/// <returns>An object used to await this task.</returns>
		/// <param name="continueOnCapturedContext">true to attempt to marshal the continuation back to the original context captured; otherwise, false.</param>
		public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			return default(ConfiguredTaskAwaitable<TResult>);
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		public Task ContinueWith(Action<Task<TResult>> continuationAction)
		{
			return null;
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its execution.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.-or-The <paramref name="scheduler" /> argument is null.</exception>
		public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler)
		{
			return null;
		}

		internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task`1" /> completes.</summary>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task`1" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <typeparam name="TNewResult"> The type of the result produced by the continuation.</typeparam>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction)
		{
			return null;
		}

		/// <summary>Creates a continuation that executes according the condition specified in <paramref name="continuationOptions" />.</summary>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <param name="continuationFunction">A function to run according the condition specified in <paramref name="continuationOptions" />.When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <typeparam name="TNewResult"> The type of the result produced by the continuation.</typeparam>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task`1" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, object, TNewResult> continuationFunction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			return null;
		}
	}
	/// <summary>Represents an asynchronous operation.</summary>
	[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
	[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
	public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable
	{
		internal class ContingentProperties
		{
			internal ExecutionContext m_capturedContext;

			internal ManualResetEventSlim m_completionEvent;

			internal TaskExceptionHolder m_exceptionsHolder;

			internal CancellationToken m_cancellationToken;

			internal object m_cancellationRegistration;

			internal int m_internalCancellationRequested;

			internal int m_completionCountdown;

			internal LowLevelListWithIList<Task> m_exceptionalChildren;

			internal void SetCompleted()
			{
			}

			internal void UnregisterCancellationCallback()
			{
			}
		}

		private sealed class SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction
		{
			public bool InvokeMayRunArbitraryCode => false;

			internal SetOnInvokeMres()
			{
			}

			public void Invoke(Task completingTask)
			{
			}
		}

		private sealed class SetOnCountdownMres : ManualResetEventSlim, ITaskCompletionAction
		{
			private int _count;

			public bool InvokeMayRunArbitraryCode => false;

			internal SetOnCountdownMres(int count)
			{
			}

			public void Invoke(Task completingTask)
			{
			}
		}

		private sealed class DelayPromise : Task<VoidTaskResult>
		{
			internal readonly CancellationToken Token;

			internal CancellationTokenRegistration Registration;

			internal Timer Timer;

			internal DelayPromise(CancellationToken token)
			{
			}

			internal void Complete()
			{
			}
		}

		private sealed class WhenAllPromise : Task<VoidTaskResult>, ITaskCompletionAction
		{
			private readonly Task[] m_tasks;

			private int m_count;

			internal override bool ShouldNotifyDebuggerOfWaitCompletion => false;

			public bool InvokeMayRunArbitraryCode => false;

			internal WhenAllPromise(Task[] tasks)
			{
			}

			public void Invoke(Task ignored)
			{
			}
		}

		private sealed class WhenAllPromise<T> : Task<T[]>, ITaskCompletionAction
		{
			private readonly Task<T>[] m_tasks;

			private int m_count;

			internal override bool ShouldNotifyDebuggerOfWaitCompletion => false;

			public bool InvokeMayRunArbitraryCode => false;

			internal WhenAllPromise(Task<T>[] tasks)
			{
			}

			public void Invoke(Task ignored)
			{
			}
		}

		internal static int s_taskIdCounter;

		private int m_taskId;

		internal Delegate m_action;

		internal object m_stateObject;

		internal TaskScheduler m_taskScheduler;

		internal readonly Task m_parent;

		internal int m_stateFlags;

		private const int OptionsMask = 65535;

		internal const int TASK_STATE_STARTED = 65536;

		internal const int TASK_STATE_DELEGATE_INVOKED = 131072;

		internal const int TASK_STATE_DISPOSED = 262144;

		internal const int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = 524288;

		internal const int TASK_STATE_CANCELLATIONACKNOWLEDGED = 1048576;

		internal const int TASK_STATE_FAULTED = 2097152;

		internal const int TASK_STATE_CANCELED = 4194304;

		internal const int TASK_STATE_WAITING_ON_CHILDREN = 8388608;

		internal const int TASK_STATE_RAN_TO_COMPLETION = 16777216;

		internal const int TASK_STATE_WAITINGFORACTIVATION = 33554432;

		internal const int TASK_STATE_COMPLETION_RESERVED = 67108864;

		internal const int TASK_STATE_THREAD_WAS_ABORTED = 134217728;

		internal const int TASK_STATE_WAIT_COMPLETION_NOTIFICATION = 268435456;

		private const int TASK_STATE_COMPLETED_MASK = 23068672;

		private const int CANCELLATION_REQUESTED = 1;

		private object m_continuationObject;

		private static readonly object s_taskCompletionSentinel;

		internal static bool s_asyncDebuggingEnabled;

		internal ContingentProperties m_contingentProperties;

		private static readonly Action<object> s_taskCancelCallback;

		[ThreadStatic]
		internal static Task t_currentTask;

		[ThreadStatic]
		private static StackGuard t_stackGuard;

		private static readonly Func<ContingentProperties> s_createContingentProperties;

		private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate;

		private static ContextCallback s_ecCallback;

		private static readonly Predicate<object> s_IsTaskContinuationNullPredicate;

		private static readonly Dictionary<int, Task> s_currentActiveTasks;

		private static readonly object s_activeTasksLock;

		internal TaskCreationOptions Options => default(TaskCreationOptions);

		internal bool IsWaitNotificationEnabledOrNotRanToCompletion
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		internal virtual bool ShouldNotifyDebuggerOfWaitCompletion => false;

		internal bool IsWaitNotificationEnabled => false;

		/// <summary>Gets a unique ID for this <see cref="T:System.Threading.Tasks.Task" /> instance.</summary>
		/// <returns>An integer that was assigned by the system to this task instance.</returns>
		public int Id => 0;

		/// <summary>Returns the unique ID of the currently executing <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <returns>An integer that was assigned by the system to the currently-executing task.</returns>
		public static int? CurrentId => null;

		internal static Task InternalCurrent => null;

		internal static StackGuard CurrentStackGuard => null;

		/// <summary>Gets the <see cref="T:System.AggregateException" /> that caused the <see cref="T:System.Threading.Tasks.Task" /> to end prematurely. If the <see cref="T:System.Threading.Tasks.Task" /> completed successfully or has not yet thrown any exceptions, this will return null.</summary>
		/// <returns>The <see cref="T:System.AggregateException" /> that caused the <see cref="T:System.Threading.Tasks.Task" /> to end prematurely.</returns>
		public AggregateException Exception => null;

		/// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskStatus" /> of this task.</summary>
		/// <returns>The current <see cref="T:System.Threading.Tasks.TaskStatus" /> of this task instance.</returns>
		public TaskStatus Status => default(TaskStatus);

		/// <summary>Gets whether this <see cref="T:System.Threading.Tasks.Task" /> instance has completed execution due to being canceled.</summary>
		/// <returns>true if the task has completed due to being canceled; otherwise false.</returns>
		public bool IsCanceled => false;

		internal bool IsCancellationRequested => false;

		internal CancellationToken CancellationToken => default(CancellationToken);

		internal bool IsCancellationAcknowledged => false;

		/// <summary>Gets whether this <see cref="T:System.Threading.Tasks.Task" /> has completed.</summary>
		/// <returns>true if the task has completed; otherwise false.</returns>
		public bool IsCompleted => false;

		public bool IsCompletedSuccessfully => false;

		/// <summary>Gets the <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to create this task.</summary>
		/// <returns>The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to create this task.</returns>
		public TaskCreationOptions CreationOptions => default(TaskCreationOptions);

		/// <summary>Gets a <see cref="T:System.Threading.WaitHandle" /> that can be used to wait for the task to complete.</summary>
		/// <returns>A <see cref="T:System.Threading.WaitHandle" /> that can be used to wait for the task to complete.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		WaitHandle IAsyncResult.AsyncWaitHandle => null;

		/// <summary>Gets the state object supplied when the <see cref="T:System.Threading.Tasks.Task" /> was created, or null if none was supplied.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the state data that was passed in to the task when it was created.</returns>
		public object AsyncState => null;

		/// <summary>Gets an indication of whether the operation completed synchronously.</summary>
		/// <returns>true if the operation completed synchronously; otherwise, false.</returns>
		bool IAsyncResult.CompletedSynchronously => false;

		internal TaskScheduler ExecutingTaskScheduler => null;

		/// <summary>Provides access to factory methods for creating <see cref="T:System.Threading.Tasks.Task" /> and <see cref="T:System.Threading.Tasks.Task`1" /> instances.</summary>
		/// <returns>The default <see cref="T:System.Threading.Tasks.TaskFactory" /> for the current task.</returns>
		public static TaskFactory Factory { get; }

		public static Task CompletedTask { get; }

		internal ManualResetEventSlim CompletedEvent => null;

		internal bool ExceptionRecorded => false;

		/// <summary>Gets whether the <see cref="T:System.Threading.Tasks.Task" /> completed due to an unhandled exception.</summary>
		/// <returns>true if the task has thrown an unhandled exception; otherwise false.</returns>
		public bool IsFaulted => false;

		internal ExecutionContext CapturedContext
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsExceptionObservedByParent => false;

		internal bool IsDelegateInvoked => false;

		internal Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct)
		{
		}

		internal Task()
		{
		}

		internal Task(object state, TaskCreationOptions creationOptions, bool promiseStyle)
		{
		}

		/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task" /> with the specified action and creation options.</summary>
		/// <param name="action">The delegate that represents the code to execute in the task.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that the new task will observe.</param>
		/// <param name="creationOptions">The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to customize the task's behavior.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		public Task(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
		{
		}

		/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task" /> with the specified action and state.</summary>
		/// <param name="action">The delegate that represents the code to execute in the task.</param>
		/// <param name="state">An object representing data to be used by the action.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
		public Task(Action<object> action, object state)
		{
		}

		/// <summary>Initializes a new <see cref="T:System.Threading.Tasks.Task" /> with the specified action, state, and options.</summary>
		/// <param name="action">The delegate that represents the code to execute in the task.</param>
		/// <param name="state">An object representing data to be used by the action.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that that the new task will observe..</param>
		/// <param name="creationOptions">The <see cref="T:System.Threading.Tasks.TaskCreationOptions" /> used to customize the task's behavior.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="creationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskCreationOptions" />.</exception>
		public Task(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
		{
		}

		internal Task(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
		}

		internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
		}

		private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation)
		{
		}

		private static void TaskCancelCallback(object o)
		{
		}

		internal bool TrySetCanceled(CancellationToken tokenToRecord)
		{
			return false;
		}

		internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException)
		{
			return false;
		}

		internal bool TrySetException(object exceptionObject)
		{
			return false;
		}

		internal static TaskCreationOptions OptionsMethod(int flags)
		{
			return default(TaskCreationOptions);
		}

		internal bool AtomicStateUpdate(int newBits, int illegalBits)
		{
			return false;
		}

		internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags)
		{
			return false;
		}

		internal void SetNotificationForWaitCompletion(bool enabled)
		{
		}

		internal bool NotifyDebuggerOfWaitCompletionIfNecessary()
		{
			return false;
		}

		internal static bool AnyTaskRequiresNotifyDebuggerOfWaitCompletion(Task[] tasks)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void NotifyDebuggerOfWaitCompletion()
		{
		}

		internal bool MarkStarted()
		{
			return false;
		}

		internal void AddNewChild()
		{
		}

		internal void DisregardChild()
		{
		}

		/// <summary>Starts the <see cref="T:System.Threading.Tasks.Task" />, scheduling it for execution to the current <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> instance has been disposed.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.Tasks.Task" /> is not in a valid state to be started. It may have already been started, executed, or canceled, or it may have been created in a manner that doesn't support direct scheduling.</exception>
		public void Start()
		{
		}

		/// <summary>Starts the <see cref="T:System.Threading.Tasks.Task" />, scheduling it for execution to the specified <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> with which to associate and execute this task.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> instance has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.Tasks.Task" /> is not in a valid state to be started. It may have already been started, executed, or canceled, or it may have been created in a manner that doesn't support direct scheduling.</exception>
		public void Start(TaskScheduler scheduler)
		{
		}

		/// <summary>Runs the <see cref="T:System.Threading.Tasks.Task" /> synchronously on the <see cref="T:System.Threading.Tasks.TaskScheduler" /> provided.</summary>
		/// <param name="scheduler">The scheduler on which to attempt to run this task inline.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> instance has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> parameter is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Threading.Tasks.Task" /> is not in a valid state to be started. It may have already been started, executed, or canceled, or it may have been created in a manner that doesn't support direct scheduling.</exception>
		public void RunSynchronously(TaskScheduler scheduler)
		{
		}

		internal void InternalRunSynchronously(TaskScheduler scheduler, bool waitForCompletion)
		{
		}

		internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions)
		{
			return null;
		}

		internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions)
		{
			return null;
		}

		internal ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection)
		{
			return null;
		}

		private ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection)
		{
			return null;
		}

		private static bool IsCompletedMethod(int flags)
		{
			return false;
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.Tasks.Task" /> class.</summary>
		/// <exception cref="T:System.InvalidOperationException">The exception that is thrown if the <see cref="T:System.Threading.Tasks.Task" /> is not in one of the final states: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />, or <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
		public void Dispose()
		{
		}

		/// <summary>Disposes the <see cref="T:System.Threading.Tasks.Task" />, releasing all of its unmanaged resources.</summary>
		/// <param name="disposing">A Boolean value that indicates whether this method is being called due to a call to <see cref="M:System.Threading.Tasks.Task.Dispose" />.</param>
		/// <exception cref="T:System.InvalidOperationException">The exception that is thrown if the <see cref="T:System.Threading.Tasks.Task" /> is not in one of the final states: <see cref="F:System.Threading.Tasks.TaskStatus.RanToCompletion" />, <see cref="F:System.Threading.Tasks.TaskStatus.Faulted" />, or <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" />.</exception>
		protected virtual void Dispose(bool disposing)
		{
		}

		internal void ScheduleAndStart(bool needsProtection)
		{
		}

		internal void AddException(object exceptionObject)
		{
		}

		internal void AddException(object exceptionObject, bool representsCancellation)
		{
		}

		private AggregateException GetExceptions(bool includeTaskCanceledExceptions)
		{
			return null;
		}

		internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			return null;
		}

		internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			return null;
		}

		internal void ThrowIfExceptional(bool includeTaskCanceledExceptions)
		{
		}

		internal void UpdateExceptionObservedStatus()
		{
		}

		internal void Finish(bool bUserDelegateExecuted)
		{
		}

		internal void FinishStageTwo()
		{
		}

		internal void FinishStageThree()
		{
		}

		internal void ProcessChildCompletion(Task childTask)
		{
		}

		internal void AddExceptionsFromChildren()
		{
		}

		private void Execute()
		{
		}

		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
		}

		internal bool ExecuteEntry(bool bPreventDoubleExecution)
		{
			return false;
		}

		private static void ExecutionContextCallback(object obj)
		{
		}

		internal virtual void InnerInvoke()
		{
		}

		private void HandleException(Exception unhandledException)
		{
		}

		/// <summary>Gets an awaiter used to await this <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <returns>An awaiter instance.</returns>
		public TaskAwaiter GetAwaiter()
		{
			return default(TaskAwaiter);
		}

		/// <summary>Configures an awaiter used to await this <see cref="T:System.Threading.Tasks.Task" />.</summary>
		/// <returns>An object used to await this task.</returns>
		/// <param name="continueOnCapturedContext">true to attempt to marshal the continuation back to the original context captured; otherwise, false.</param>
		public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			return default(ConfiguredTaskAwaitable);
		}

		internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext)
		{
		}

		/// <summary>Creates an awaitable task that asynchronously yields back to the current context when awaited.</summary>
		/// <returns>A context that, when awaited, will asynchronously transition back into the current context at the time of the await. If the current <see cref="T:System.Threading.SynchronizationContext" /> is non-null, it is treated as the current context. Otherwise, the task scheduler that is associated with the currently executing task is treated as the current context. </returns>
		public static YieldAwaitable Yield()
		{
			return default(YieldAwaitable);
		}

		/// <summary>Waits for the <see cref="T:System.Threading.Tasks.Task" /> to complete execution.</summary>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.AggregateException">The <see cref="T:System.Threading.Tasks.Task" /> was canceled -or- an exception was thrown during the execution of the <see cref="T:System.Threading.Tasks.Task" />. If the task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.</exception>
		public void Wait()
		{
		}

		/// <summary>Waits for the cancellable <see cref="T:System.Threading.Tasks.Task" /> to complete execution.</summary>
		/// <returns>true if the <see cref="T:System.Threading.Tasks.Task" /> completed execution within the allotted time; otherwise, false.</returns>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for the task to complete.</param>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.AggregateException">The <see cref="T:System.Threading.Tasks.Task" /> was canceled -or- an exception was thrown during the execution of the <see cref="T:System.Threading.Tasks.Task" />. If the task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.</exception>
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return false;
		}

		private bool WrappedTryRunInline()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return false;
		}

		private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return false;
		}

		private bool SpinWait(int millisecondsTimeout)
		{
			return false;
		}

		internal bool InternalCancel(bool bCancelNonExecutingOnly)
		{
			return false;
		}

		internal void RecordInternalCancellationRequest()
		{
		}

		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord)
		{
		}

		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException)
		{
		}

		internal void CancellationCleanupLogic()
		{
		}

		private void SetCancellationAcknowledged()
		{
		}

		internal void FinishContinuations()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void LogFinishCompletionNotification()
		{
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes.</summary>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> that created <paramref name="cancellationToken" /> has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		public Task ContinueWith(Action<Task> continuationAction)
		{
			return null;
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes.</summary>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="cancellationToken">The <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.-or-The <see cref="T:System.Threading.CancellationTokenSource" /> that created the token has already been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken)
		{
			return null;
		}

		/// <summary>Creates a continuation that executes according to the specified <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</summary>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <param name="continuationAction">An action to run according to the specified <paramref name="continuationOptions" />. When run, the delegate will be passed the completed task as an argument.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		/// <summary>Creates a continuation that executes when the target <see cref="T:System.Threading.Tasks.Task" /> completes.</summary>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation action.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		public Task ContinueWith(Action<Task, object> continuationAction, object state, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		/// <summary>Creates a continuation that executes when the target <see cref="T:System.Threading.Tasks.Task" /> completes.</summary>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task" />.</returns>
		/// <param name="continuationAction">An action to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be  passed the completed task and the caller-supplied state object as arguments.</param>
		/// <param name="state">An object representing data to be used by the continuation action.</param>
		/// <param name="cancellationToken">The <see cref="T:System.Threading.CancellationToken" /> that will be assigned to the new continuation task.</param>
		/// <param name="continuationOptions">Options for when the continuation is scheduled and how it behaves. This includes criteria, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.OnlyOnCanceled" />, as well as execution options, such as <see cref="F:System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously" />.</param>
		/// <param name="scheduler">The <see cref="T:System.Threading.Tasks.TaskScheduler" /> to associate with the continuation task and to use for its  execution.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationAction" /> argument is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="continuationOptions" /> argument specifies an invalid value for <see cref="T:System.Threading.Tasks.TaskContinuationOptions" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="scheduler" /> argument is null.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The provided <see cref="T:System.Threading.CancellationToken" /> has already been disposed.</exception>
		public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return null;
		}

		private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		/// <summary>Creates a continuation that executes asynchronously when the target <see cref="T:System.Threading.Tasks.Task" /> completes.</summary>
		/// <returns>A new continuation <see cref="T:System.Threading.Tasks.Task`1" />.</returns>
		/// <param name="continuationFunction">A function to run when the <see cref="T:System.Threading.Tasks.Task" /> completes. When run, the delegate will be passed the completed task as an argument.</param>
		/// <typeparam name="TResult"> The type of the result produced by the continuation.</typeparam>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.Tasks.Task" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="continuationFunction" /> argument is null.</exception>
		public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction)
		{
			return null;
		}

		private Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions)
		{
			creationOptions = default(TaskCreationOptions);
			internalOptions = default(InternalTaskOptions);
		}

		internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options)
		{
		}

		internal void AddCompletionAction(ITaskCompletionAction action)
		{
		}

		private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers)
		{
		}

		private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers)
		{
			return false;
		}

		private bool AddTaskContinuation(object tc, bool addBeforeOthers)
		{
			return false;
		}

		internal void RemoveContinuation(object continuationObject)
		{
		}

		/// <summary>Waits for all of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution.</summary>
		/// <param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param>
		/// <exception cref="T:System.ObjectDisposedException">One or more of the <see cref="T:System.Threading.Tasks.Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.-or-The <paramref name="tasks" /> argument contains a null element.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="T:System.Threading.Tasks.Task" /> instances was canceled -or- an exception was thrown during the execution of at least one of the <see cref="T:System.Threading.Tasks.Task" /> instances. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.</exception>
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static void WaitAll(params Task[] tasks)
		{
		}

		/// <summary>Waits for all of the provided <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution within a specified number of milliseconds.</summary>
		/// <returns>true if all of the <see cref="T:System.Threading.Tasks.Task" /> instances completed execution within the allotted time; otherwise, false.</returns>
		/// <param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <exception cref="T:System.ObjectDisposedException">One or more of the <see cref="T:System.Threading.Tasks.Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="T:System.Threading.Tasks.Task" /> instances was canceled -or- an exception was thrown during the execution of at least one of the <see cref="T:System.Threading.Tasks.Task" /> instances. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static bool WaitAll(Task[] tasks, int millisecondsTimeout)
		{
			return false;
		}

		/// <summary>Waits for all of the provided cancellable <see cref="T:System.Threading.Tasks.Task" /> objects to complete execution within a specified number of milliseconds.</summary>
		/// <returns>true if all of the <see cref="T:System.Threading.Tasks.Task" /> instances completed execution within the allotted time; otherwise, false.</returns>
		/// <param name="tasks">An array of <see cref="T:System.Threading.Tasks.Task" /> instances on which to wait.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
		/// <param name="cancellationToken">A <see cref="P:System.Threading.Tasks.TaskFactory.CancellationToken" /> to observe while waiting for the tasks to complete.</param>
		/// <exception cref="T:System.ObjectDisposedException">One or more of the <see cref="T:System.Threading.Tasks.Task" /> objects in <paramref name="tasks" /> has been disposed.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument is null.</exception>
		/// <exception cref="T:System.AggregateException">At least one of the <see cref="T:System.Threading.Tasks.Task" /> instances was canceled -or- an exception was thrown during the execution of at least one of the <see cref="T:System.Threading.Tasks.Task" /> instances. If a task was canceled, the <see cref="T:System.AggregateException" /> contains an <see cref="T:System.OperationCanceledException" /> in its <see cref="P:System.AggregateException.InnerExceptions" /> collection.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> argument contains a null element.</exception>
		/// <exception cref="T:System.OperationCanceledException">The <paramref name="cancellationToken" /> was canceled.</exception>
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static bool WaitAll(Task[] tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return false;
		}

		private static void AddToList<T>(T item, ref LowLevelListWithIList<T> list, int initSize)
		{
		}

		private static bool WaitAllBlockingCore(LowLevelListWithIList<Task> tasks, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return false;
		}

		internal static void AddExceptionsForCompletedTask(ref LowLevelListWithIList<Exception> exceptions, Task t)
		{
		}

		/// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that's completed successfully with the specified result.</summary>
		/// <returns>The successfully completed task.</returns>
		/// <param name="result">The result to store into the completed task.</param>
		/// <typeparam name="TResult">The type of the result returned by the task.</typeparam>
		public static Task<TResult> FromResult<TResult>(TResult result)
		{
			return null;
		}

		public static Task FromException(Exception exception)
		{
			return null;
		}

		public static Task<TResult> FromException<TResult>(Exception exception)
		{
			return null;
		}

		internal static Task FromCancellation(CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task FromCanceled(CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception)
		{
			return null;
		}

		/// <summary>Queues the specified work to run on the ThreadPool and returns a task handle for that work.</summary>
		/// <returns>A task that represents the work queued to execute in the ThreadPool.</returns>
		/// <param name="action">The work to execute asynchronously</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="action" /> parameter was null.</exception>
		public static Task Run(Action action)
		{
			return null;
		}

		/// <summary>Queues the specified work to run on the ThreadPool and returns a Task(TResult) handle for that work.</summary>
		/// <returns>A Task(TResult) that represents the work queued to execute in the ThreadPool.</returns>
		/// <param name="function">The work to execute asynchronously</param>
		/// <typeparam name="TResult">The result type of the task.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		public static Task<TResult> Run<TResult>(Func<TResult> function)
		{
			return null;
		}

		/// <summary>Queues the specified work to run on the ThreadPool and returns a proxy for the  task returned by <paramref name="function" />.</summary>
		/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
		/// <param name="function">The work to execute asynchronously</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		public static Task Run(Func<Task> function)
		{
			return null;
		}

		/// <summary>Queues the specified work to run on the ThreadPool and returns a proxy for the  task returned by <paramref name="function" />.</summary>
		/// <returns>A task that represents a proxy for the task returned by <paramref name="function" />.</returns>
		/// <param name="function">The work to execute asynchronously</param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		public static Task Run(Func<Task> function, CancellationToken cancellationToken)
		{
			return null;
		}

		/// <summary>Queues the specified work to run on the ThreadPool and returns a proxy for the  Task(TResult) returned by <paramref name="function" />.</summary>
		/// <returns>A Task(TResult) that represents a proxy for the Task(TResult) returned by <paramref name="function" />.</returns>
		/// <param name="function">The work to execute asynchronously</param>
		/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		public static Task<TResult> Run<TResult>(Func<Task<TResult>> function)
		{
			return null;
		}

		/// <summary>Queues the specified work to run on the ThreadPool and returns a proxy for the  Task(TResult) returned by <paramref name="function" />.</summary>
		/// <returns>A Task(TResult) that represents a proxy for the Task(TResult) returned by <paramref name="function" />.</returns>
		/// <param name="function">The work to execute asynchronously</param>
		/// <param name="cancellationToken">A cancellation token that should be used to cancel the work</param>
		/// <typeparam name="TResult">The type of the result returned by the proxy task.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="function" /> parameter was null.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Threading.CancellationTokenSource" /> associated with <paramref name="cancellationToken" /> was disposed.</exception>
		public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken)
		{
			return null;
		}

		/// <summary>Creates a task that will complete after a time delay.</summary>
		/// <returns>A task that represents the time delay</returns>
		/// <param name="millisecondsDelay">The number of milliseconds to wait before completing the returned task</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsDelay" /> is less than -1.</exception>
		public static Task Delay(int millisecondsDelay)
		{
			return null;
		}

		/// <summary>Creates a task that will complete after a time delay.</summary>
		/// <returns>A task that represents the time delay</returns>
		/// <param name="millisecondsDelay">The number of milliseconds to wait before completing the returned task</param>
		/// <param name="cancellationToken">The cancellation token that will be checked prior to completing the returned task</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="millisecondsDelay" /> is less than -1.</exception>
		/// <exception cref="T:System.Threading.Tasks.TaskCanceledException">The task has been canceled.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The provided <paramref name="cancellationToken" /> has already been disposed.</exception>
		public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
		{
			return null;
		}

		/// <summary>Creates a task that will complete when all of the supplied tasks have completed.</summary>
		/// <returns>A task that represents the completion of all of the supplied tasks.</returns>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> collection contained a null task.</exception>
		public static Task WhenAll(IEnumerable<Task> tasks)
		{
			return null;
		}

		/// <summary>Creates a task that will complete when all of the supplied tasks have completed.</summary>
		/// <returns>A task that represents the completion of all of the supplied tasks.</returns>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task.</exception>
		public static Task WhenAll(params Task[] tasks)
		{
			return null;
		}

		private static Task InternalWhenAll(Task[] tasks)
		{
			return null;
		}

		/// <summary>Creates a task that will complete when all of the supplied tasks have completed.</summary>
		/// <returns>A task that represents the completion of all of the supplied tasks.</returns>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> collection contained a null task.</exception>
		public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks)
		{
			return null;
		}

		/// <summary>Creates a task that will complete when all of the supplied tasks have completed.</summary>
		/// <returns>A task that represents the completion of all of the supplied tasks.</returns>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <typeparam name="TResult">The type of the completed task.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task.</exception>
		public static Task<TResult[]> WhenAll<TResult>(params Task<TResult>[] tasks)
		{
			return null;
		}

		private static Task<TResult[]> InternalWhenAll<TResult>(Task<TResult>[] tasks)
		{
			return null;
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		public static Task<Task> WhenAny(params Task[] tasks)
		{
			return null;
		}

		/// <summary>Creates a task that will complete when any of the supplied tasks have completed.</summary>
		/// <returns>A task that represents the completion of one of the supplied tasks.  The return task's Result is the task that completed.</returns>
		/// <param name="tasks">The tasks to wait on for completion.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="tasks" /> argument was null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="tasks" /> array contained a null task, or was empty.</exception>
		public static Task<Task> WhenAny(IEnumerable<Task> tasks)
		{
			return null;
		}

		public static Task<TResult> CreateUnwrapPromise<TResult>(Task outerTask, bool lookForOce)
		{
			return null;
		}

		[FriendAccessAllowed]
		internal static bool AddToActiveTasks(Task task)
		{
			return false;
		}

		[FriendAccessAllowed]
		internal static void RemoveFromActiveTasks(int taskId)
		{
		}

		public void MarkAborted(ThreadAbortException e)
		{
		}

		private void ExecuteWithThreadLocal(ref Task currentTaskSlot)
		{
		}
	}
}
