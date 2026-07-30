using System.Collections;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading
{
	/// <summary>Defines a lock that supports single writers and multiple readers. </summary>
	/// <filterpriority>2</filterpriority>
	[ComVisible(true)]
	public sealed class ReaderWriterLock : CriticalFinalizerObject
	{
		private int seq_num;

		private int state;

		private int readers;

		private int writer_lock_owner;

		private LockQueue writer_queue;

		private Hashtable reader_locks;

		/// <summary>Gets a value indicating whether the current thread holds a reader lock.</summary>
		/// <returns>true if the current thread holds a reader lock; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		public bool IsReaderLockHeld
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the current thread holds the writer lock.</summary>
		/// <returns>true if the current thread holds the writer lock; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		public bool IsWriterLockHeld
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return false;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ReaderWriterLock" /> class.</summary>
		public ReaderWriterLock()
		{
		}

		~ReaderWriterLock()
		{
		}

		/// <summary>Acquires a reader lock, using an <see cref="T:System.Int32" /> value for the time-out.</summary>
		/// <param name="millisecondsTimeout">The time-out in milliseconds. </param>
		/// <exception cref="T:System.ApplicationException">
		///   <paramref name="millisecondsTimeout" /> expires before the lock request is granted. </exception>
		/// <filterpriority>2</filterpriority>
		public void AcquireReaderLock(int millisecondsTimeout)
		{
		}

		private void AcquireReaderLock(int millisecondsTimeout, int initialLockCount)
		{
		}

		/// <summary>Acquires the writer lock, using an <see cref="T:System.Int32" /> value for the time-out.</summary>
		/// <param name="millisecondsTimeout">The time-out in milliseconds. </param>
		/// <exception cref="T:System.ApplicationException">
		///   <paramref name="timeout" /> expires before the lock request is granted. </exception>
		/// <filterpriority>2</filterpriority>
		public void AcquireWriterLock(int millisecondsTimeout)
		{
		}

		private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount)
		{
		}

		/// <summary>Decrements the lock count.</summary>
		/// <exception cref="T:System.ApplicationException">The thread does not have any reader or writer locks. </exception>
		/// <filterpriority>2</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void ReleaseReaderLock()
		{
		}

		private void ReleaseReaderLock(int currentCount, int releaseCount)
		{
		}

		/// <summary>Decrements the lock count on the writer lock.</summary>
		/// <exception cref="T:System.ApplicationException">The thread does not have the writer lock. </exception>
		/// <filterpriority>2</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void ReleaseWriterLock()
		{
		}

		private void ReleaseWriterLock(int releaseCount)
		{
		}

		private bool HasWriterLock()
		{
			return false;
		}
	}
}
