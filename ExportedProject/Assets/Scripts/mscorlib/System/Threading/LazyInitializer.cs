namespace System.Threading
{
	/// <summary>Provides lazy initialization routines.</summary>
	public static class LazyInitializer
	{
		/// <summary>Initializes a target reference type with the type's default constructor if it hasn't already been initialized.</summary>
		/// <returns>The initialized reference of type <paramref name="T" />.</returns>
		/// <param name="target">A reference of type <paramref name="T" /> to initialize if it has not already been initialized.</param>
		/// <typeparam name="T">The type of the reference to be initialized.</typeparam>
		/// <exception cref="T:System.MemberAccessException">Permissions to access the constructor of type <paramref name="T" /> were missing.</exception>
		/// <exception cref="T:System.MissingMemberException">Type <paramref name="T" /> does not have a default constructor.</exception>
		public static T EnsureInitialized<T>(ref T target) where T : class
		{
			return null;
		}

		private static T EnsureInitializedCore<T>(ref T target) where T : class
		{
			return null;
		}

		/// <summary>Initializes a target reference type by using a specified function if it hasn't already been initialized.</summary>
		/// <returns>The initialized value of type <paramref name="T" />.</returns>
		/// <param name="target">The reference of type <paramref name="T" /> to initialize if it hasn't already been initialized.</param>
		/// <param name="valueFactory">The function that is called to initialize the reference.</param>
		/// <typeparam name="T">The reference type of the reference to be initialized.</typeparam>
		/// <exception cref="T:System.MissingMemberException">Type <paramref name="T" /> does not have a default constructor.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="valueFactory" /> returned null (Nothing in Visual Basic).</exception>
		public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) where T : class
		{
			return null;
		}

		private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) where T : class
		{
			return null;
		}

		public static T EnsureInitialized<T>(ref T target, ref object syncLock, Func<T> valueFactory) where T : class
		{
			return null;
		}

		private static T EnsureInitializedCore<T>(ref T target, ref object syncLock, Func<T> valueFactory) where T : class
		{
			return null;
		}

		private static object EnsureLockInitialized(ref object syncLock)
		{
			return null;
		}
	}
}
