namespace Namotion.Reflection
{
	internal static class ArrayExt
	{
		private static class EmptyHolder<T>
		{
			internal static readonly T[] _empty;
		}

		public static T[] Empty<T>() where T : notnull
		{
			return null;
		}
	}
}
