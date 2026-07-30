using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Parse.Common.Internal
{
	public static class InternalExtensions
	{
		public delegate void PartialAccessor<T>(ref T arg);

		public static Task<T> Safe<T>(this Task<T> task)
		{
			return null;
		}

		public static Task Safe(this Task task)
		{
			return null;
		}

		public static TValue GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> self, TKey key, TValue defaultValue)
		{
			return default(TValue);
		}

		public static bool CollectionsEqual<T>(this IEnumerable<T> a, IEnumerable<T> b)
		{
			return false;
		}

		public static Task<TResult> OnSuccess<TIn, TResult>(this Task<TIn> task, Func<Task<TIn>, TResult> continuation)
		{
			return null;
		}

		public static Task OnSuccess<TIn>(this Task<TIn> task, Action<Task<TIn>> continuation)
		{
			return null;
		}

		public static Task<TResult> OnSuccess<TResult>(this Task task, Func<Task, TResult> continuation)
		{
			return null;
		}

		public static Task OnSuccess(this Task task, Action<Task> continuation)
		{
			return null;
		}

		public static Task WhileAsync(Func<Task<bool>> predicate, Func<Task> body)
		{
			return null;
		}
	}
}
