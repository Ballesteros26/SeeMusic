using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace NJsonSchema
{
	internal static class ObservableCollectionExtensions
	{
		public static int Count<T>(this ObservableCollection<T> collection, Func<T, bool> predicate)
		{
			return 0;
		}

		public static T First<T>(this ObservableCollection<T> collection, Func<T, bool> predicate)
		{
			return default(T);
		}

		public static T FirstOrDefault<T>(this ObservableCollection<T> collection, Func<T, bool> predicate) where T : class
		{
			return null;
		}

		public static T FirstOrDefault<T>(this ObservableCollection<T> collection) where T : class
		{
			return null;
		}

		public static bool Any<T>(this ObservableCollection<T> collection, Func<T, bool> predicate)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ThrowNoMatchingElement()
		{
		}
	}
}
