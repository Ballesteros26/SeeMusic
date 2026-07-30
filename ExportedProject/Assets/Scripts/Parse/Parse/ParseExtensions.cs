using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Parse
{
	public static class ParseExtensions
	{
		public static Task SaveAllAsync<T>(this IEnumerable<T> objects) where T : ParseObject
		{
			return null;
		}

		public static Task SaveAllAsync<T>(this IEnumerable<T> objects, CancellationToken cancellationToken) where T : ParseObject
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllAsync<T>(this IEnumerable<T> objects) where T : ParseObject
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllAsync<T>(this IEnumerable<T> objects, CancellationToken cancellationToken) where T : ParseObject
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllIfNeededAsync<T>(this IEnumerable<T> objects) where T : ParseObject
		{
			return null;
		}

		public static Task<IEnumerable<T>> FetchAllIfNeededAsync<T>(this IEnumerable<T> objects, CancellationToken cancellationToken) where T : ParseObject
		{
			return null;
		}

		public static ParseQuery<T> Or<T>(this ParseQuery<T> source, params ParseQuery<T>[] queries) where T : ParseObject
		{
			return null;
		}

		public static Task<T> FetchAsync<T>(this T obj) where T : ParseObject
		{
			return null;
		}

		public static Task<T> FetchAsync<T>(this T obj, CancellationToken cancellationToken) where T : ParseObject
		{
			return null;
		}

		public static Task<T> FetchIfNeededAsync<T>(this T obj) where T : ParseObject
		{
			return null;
		}

		public static Task<T> FetchIfNeededAsync<T>(this T obj, CancellationToken cancellationToken) where T : ParseObject
		{
			return null;
		}
	}
}
