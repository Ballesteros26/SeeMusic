using System.Collections.Generic;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class ListExtensions
	{
		public static bool IsEmpty<T>(this List<T> list)
		{
			return false;
		}

		public static T Head<T>(this List<T> list)
		{
			return default(T);
		}

		public static List<T> Tail<T>(this List<T> list)
		{
			return null;
		}
	}
}
