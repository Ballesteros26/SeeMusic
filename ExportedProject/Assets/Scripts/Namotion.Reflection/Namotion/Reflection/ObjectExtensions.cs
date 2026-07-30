namespace Namotion.Reflection
{
	public static class ObjectExtensions
	{
		public static bool HasProperty(this object? obj, string propertyName)
		{
			return false;
		}

		public static T? TryGetPropertyValue<T>(this object? obj, string propertyName, T? defaultValue = default(T?))
		{
			return default(T);
		}
	}
}
