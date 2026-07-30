using System.Runtime.ConstrainedExecution;

namespace System.Threading
{
	/// <summary>Provides a mechanism that synchronizes access to objects.</summary>
	/// <filterpriority>2</filterpriority>
	public static class Monitor
	{
		/// <summary>Acquires an exclusive lock on the specified object.</summary>
		/// <param name="obj">The object on which to acquire the monitor lock. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception>
		/// <filterpriority>1</filterpriority>
		public static void Enter(object obj)
		{
		}

		/// <summary>Acquires an exclusive lock on the specified object, and atomically sets a value that indicates whether the lock was taken.</summary>
		/// <param name="obj">The object on which to wait. </param>
		/// <param name="lockTaken">The result of the attempt to acquire the lock, passed by reference. The input must be false. The output is true if the lock is acquired; otherwise, the output is false. The output is set even if an exception occurs during the attempt to acquire the lock. Note   If no exception occurs, the output of this method is always true.</param>
		/// <exception cref="T:System.ArgumentException">The input to <paramref name="lockTaken" /> is true.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception>
		public static void Enter(object obj, ref bool lockTaken)
		{
		}

		private static void ThrowLockTakenException()
		{
		}

		/// <summary>Releases an exclusive lock on the specified object.</summary>
		/// <param name="obj">The object on which to release the lock. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">The current thread does not own the lock for the specified object. </exception>
		/// <filterpriority>1</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void Exit(object obj)
		{
		}

		/// <summary>Attempts to acquire an exclusive lock on the specified object, and atomically sets a value that indicates whether the lock was taken.</summary>
		/// <param name="obj">The object on which to acquire the lock. </param>
		/// <param name="lockTaken">The result of the attempt to acquire the lock, passed by reference. The input must be false. The output is true if the lock is acquired; otherwise, the output is false. The output is set even if an exception occurs during the attempt to acquire the lock.</param>
		/// <exception cref="T:System.ArgumentException">The input to <paramref name="lockTaken" /> is true.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception>
		public static void TryEnter(object obj, ref bool lockTaken)
		{
		}

		private static int MillisecondsTimeoutFromTimeSpan(TimeSpan timeout)
		{
			return 0;
		}

		/// <summary>Releases the lock on an object and blocks the current thread until it reacquires the lock. If the specified time-out interval elapses, the thread enters the ready queue. This method also specifies whether the synchronization domain for the context (if in a synchronized context) is exited before the wait and reacquired afterward.</summary>
		/// <returns>true if the lock was reacquired before the specified time elapsed; false if the lock was reacquired after the specified time elapsed. The method does not return until the lock is reacquired.</returns>
		/// <param name="obj">The object on which to wait. </param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait before the thread enters the ready queue. </param>
		/// <param name="exitContext">true to exit and reacquire the synchronization domain for the context (if in a synchronized context) before the wait; otherwise, false. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">Wait is not invoked from within a synchronized block of code. </exception>
		/// <exception cref="T:System.Threading.ThreadInterruptedException">The thread that invokes Wait is later interrupted from the waiting state. This happens when another thread calls this thread's <see cref="M:System.Threading.Thread.Interrupt" /> method. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of the <paramref name="millisecondsTimeout" /> parameter is negative, and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
		/// <filterpriority>1</filterpriority>
		public static bool Wait(object obj, int millisecondsTimeout, bool exitContext)
		{
			return false;
		}

		/// <summary>Releases the lock on an object and blocks the current thread until it reacquires the lock. If the specified time-out interval elapses, the thread enters the ready queue.</summary>
		/// <returns>true if the lock was reacquired before the specified time elapsed; false if the lock was reacquired after the specified time elapsed. The method does not return until the lock is reacquired.</returns>
		/// <param name="obj">The object on which to wait. </param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait before the thread enters the ready queue. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">The calling thread does not own the lock for the specified object. </exception>
		/// <exception cref="T:System.Threading.ThreadInterruptedException">The thread that invokes Wait is later interrupted from the waiting state. This happens when another thread calls this thread's <see cref="M:System.Threading.Thread.Interrupt" /> method. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of the <paramref name="millisecondsTimeout" /> parameter is negative, and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static bool Wait(object obj, int millisecondsTimeout)
		{
			return false;
		}

		/// <summary>Releases the lock on an object and blocks the current thread until it reacquires the lock. If the specified time-out interval elapses, the thread enters the ready queue.</summary>
		/// <returns>true if the lock was reacquired before the specified time elapsed; false if the lock was reacquired after the specified time elapsed. The method does not return until the lock is reacquired.</returns>
		/// <param name="obj">The object on which to wait. </param>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> representing the amount of time to wait before the thread enters the ready queue. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">The calling thread does not own the lock for the specified object. </exception>
		/// <exception cref="T:System.Threading.ThreadInterruptedException">The thread that invokes Wait is later interrupted from the waiting state. This happens when another thread calls this thread's <see cref="M:System.Threading.Thread.Interrupt" /> method. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of the <paramref name="timeout" /> parameter in milliseconds is negative and does not represent <see cref="F:System.Threading.Timeout.Infinite" /> (–1 millisecond), or is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static bool Wait(object obj, TimeSpan timeout)
		{
			return false;
		}

		/// <summary>Notifies a thread in the waiting queue of a change in the locked object's state.</summary>
		/// <param name="obj">The object a thread is waiting for. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">The calling thread does not own the lock for the specified object. </exception>
		/// <filterpriority>1</filterpriority>
		public static void Pulse(object obj)
		{
		}

		/// <summary>Notifies all waiting threads of a change in the object's state.</summary>
		/// <param name="obj">The object that sends the pulse. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception>
		/// <exception cref="T:System.Threading.SynchronizationLockException">The calling thread does not own the lock for the specified object. </exception>
		/// <filterpriority>1</filterpriority>
		public static void PulseAll(object obj)
		{
		}

		private static bool Monitor_test_synchronised(object obj)
		{
			return false;
		}

		private static void Monitor_pulse(object obj)
		{
		}

		private static void ObjPulse(object obj)
		{
		}

		private static void Monitor_pulse_all(object obj)
		{
		}

		private static void ObjPulseAll(object obj)
		{
		}

		private static bool Monitor_wait(object obj, int ms)
		{
			return false;
		}

		private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj)
		{
			return false;
		}

		private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken)
		{
		}

		private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken)
		{
		}

		private static void ReliableEnter(object obj, ref bool lockTaken)
		{
		}
	}
}
