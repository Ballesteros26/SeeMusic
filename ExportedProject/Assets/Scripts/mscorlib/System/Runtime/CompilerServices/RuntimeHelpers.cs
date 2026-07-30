using System.Runtime.ConstrainedExecution;

namespace System.Runtime.CompilerServices
{
	/// <summary>Provides a set of static methods and properties that provide support for compilers. This class cannot be inherited.</summary>
	public static class RuntimeHelpers
	{
		/// <summary>Represents a delegate to code that should be run in a try block..</summary>
		/// <param name="userData">Data to pass to the delegate.</param>
		public delegate void TryCode(object userData);

		/// <summary>Represents a method to run when an exception occurs.</summary>
		/// <param name="userData">Data to pass to the delegate.</param>
		/// <param name="exceptionThrown">true to express that an exception was thrown; otherwise, false.</param>
		public delegate void CleanupCode(object userData, bool exceptionThrown);

		/// <summary>Gets the offset, in bytes, to the data in the given string.</summary>
		/// <returns>The byte offset, from the start of the <see cref="T:System.String" /> object to the first character in the string.</returns>
		public static int OffsetToStringData => 0;

		private static void InitializeArray(Array array, IntPtr fldHandle)
		{
		}

		/// <summary>Provides a fast way to initialize an array from data that is stored in a module.</summary>
		/// <param name="array">The array to be initialized. </param>
		/// <param name="fldHandle">A field handle that specifies the location of the data used to initialize the array. </param>
		public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle)
		{
		}

		/// <summary>Serves as a hash function for a particular type, suitable for use in hashing algorithms and data structures such as a hash table.</summary>
		/// <returns>A hash code for the object identified by the <paramref name="o" /> parameter.</returns>
		/// <param name="o">An object to retrieve the hash code for. </param>
		public static int GetHashCode(object o)
		{
			return 0;
		}

		/// <summary>Boxes a value type.</summary>
		/// <returns>A boxed copy of <paramref name="obj" /> if it is a value class; otherwise, <paramref name="obj" /> itself.</returns>
		/// <param name="obj">The value type to be boxed. </param>
		public static object GetObjectValue(object obj)
		{
			return null;
		}

		private static bool SufficientExecutionStack()
		{
			return false;
		}

		public static bool TryEnsureSufficientExecutionStack()
		{
			return false;
		}

		/// <summary>Designates a body of code as a constrained execution region (CER).</summary>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void PrepareConstrainedRegions()
		{
		}

		public static bool IsReferenceOrContainsReferences<T>()
		{
			return false;
		}
	}
}
