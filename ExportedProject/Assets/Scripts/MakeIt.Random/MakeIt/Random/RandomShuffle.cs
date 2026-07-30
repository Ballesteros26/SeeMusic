using System.Collections.Generic;

namespace MakeIt.Random
{
	public static class RandomShuffle
	{
		public static IList<T> Shuffle<T>(this IRandom random, IList<T> list, bool forceMoveAll = false)
		{
			return null;
		}

		public static IList<T> ShuffleInto<T>(this IRandom random, IEnumerable<T> source, IList<T> target, bool forceMoveAll = false)
		{
			return null;
		}

		public static IList<T> Shuffle<T>(this IList<T> list, IRandom random, bool forceMoveAll = false)
		{
			return null;
		}

		public static IList<T> ShuffleInto<T>(this IEnumerable<T> source, IList<T> target, IRandom random, bool forceMoveAll = false)
		{
			return null;
		}

		private static T[] Knuth_ShuffleArray<T>(T[] array, IRandom random)
		{
			return null;
		}

		private static IList<T> Knuth_ShuffleList<T>(IList<T> list, IRandom random)
		{
			return null;
		}

		private static IList<T> Knuth_ShuffleListInto<T>(IList<T> source, IList<T> target, IRandom random)
		{
			return null;
		}

		private static IList<T> Knuth_ShuffleListAppendedInto<T>(IList<T> source, IList<T> target, IRandom random)
		{
			return null;
		}

		private static IList<T> Knuth_ShuffleEnumerableInto<T>(IEnumerable<T> source, IList<T> target, IRandom random)
		{
			return null;
		}

		private static IList<T> Knuth_ShuffleEnumerableAppendedInto<T>(IEnumerable<T> source, IList<T> target, IRandom random)
		{
			return null;
		}

		private static IList<T> Knuth_ShuffleEnumerableAppendedInto<T>(IEnumerator<T> enumerator, IList<T> target, IRandom random)
		{
			return null;
		}

		private static T[] Sattolo_ShuffleArray<T>(T[] array, IRandom random)
		{
			return null;
		}

		private static IList<T> Sattolo_ShuffleList<T>(IList<T> list, IRandom random)
		{
			return null;
		}

		private static IList<T> Sattolo_ShuffleListInto<T>(IList<T> source, IList<T> target, IRandom random)
		{
			return null;
		}

		private static IList<T> Sattolo_ShuffleListAppendedInto<T>(IList<T> source, IList<T> target, IRandom random)
		{
			return null;
		}

		private static IList<T> Sattolo_ShuffleEnumerableInto<T>(IEnumerable<T> source, IList<T> target, IRandom random)
		{
			return null;
		}

		private static IList<T> Sattolo_ShuffleEnumerableAppendedInto<T>(IEnumerable<T> source, IList<T> target, IRandom random)
		{
			return null;
		}

		private static IList<T> Sattolo_ShuffleEnumerableAppendedInto<T>(IEnumerator<T> enumerator, IList<T> target, IRandom random)
		{
			return null;
		}
	}
}
