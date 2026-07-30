using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Newtonsoft.Json.Utilities
{
	internal static class CollectionUtils
	{
		private static class EmptyArrayContainer<T>
		{
			public static readonly T[] Empty;
		}

		public static bool IsNullOrEmpty<T>(ICollection<T> collection) where T : notnull
		{
			return false;
		}

		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection) where T : notnull
		{
		}

		public static bool IsDictionaryType(Type type)
		{
			return false;
		}

		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType)
		{
			return null;
		}

		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType)
		{
			return null;
		}

		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate) where T : notnull
		{
			return 0;
		}

		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer) where T : notnull
		{
			return false;
		}

		public static int IndexOfReference<T>(this List<T> list, T item) where T : notnull
		{
			return 0;
		}

		public static void FastReverse<T>(this List<T> list) where T : notnull
		{
		}

		private static IList<int> GetDimensions(IList values, int dimensionsCount)
		{
			return null;
		}

		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices)
		{
		}

		private static object JaggedArrayGetValue(IList values, int[] indices)
		{
			return null;
		}

		public static Array ToMultidimensionalArray(IList values, Type type, int rank)
		{
			return null;
		}

		public static T[] ArrayEmpty<T>() where T : notnull
		{
			return null;
		}
	}
}
