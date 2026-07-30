using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>The exception that is thrown when recursive entry into a lock is not compatible with the recursion policy for the lock.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	public class LockRecursionException : Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.LockRecursionException" /> class with a system-supplied message that describes the error.</summary>
		/// <filterpriority>2</filterpriority>
		public LockRecursionException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.LockRecursionException" /> class with a specified message that describes the error.</summary>
		/// <param name="message">The message that describes the exception. The caller of this constructor must make sure that this string has been localized for the current system culture. </param>
		/// <filterpriority>2</filterpriority>
		public LockRecursionException(string message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.LockRecursionException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data.</param>
		/// <param name="context">The contextual information about the source or destination.</param>
		protected LockRecursionException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
