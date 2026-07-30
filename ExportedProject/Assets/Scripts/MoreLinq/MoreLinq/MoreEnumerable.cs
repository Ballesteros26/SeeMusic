using System;
using System.Collections.Generic;

namespace MoreLinq
{
	public static class MoreEnumerable
	{
		private static readonly Func<int, int, Exception> DefaultErrorSelector;

		private static readonly string[] OrdinalNumbers;

		private static readonly Func<int, int, Exception> OnFolderSourceSizeErrorSelector;

		private static Exception OnAssertCountFailure(int cmp, int count)
		{
			return null;
		}

		private static Exception OnFolderSourceSizeError(int cmp, int count)
		{
			return null;
		}

		public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
		}
	}
}
