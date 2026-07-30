using System;

namespace Parse.Internal
{
	public class AppInformation
	{
		public static string Build => null;

		public static string Version => null;

		public static string Identifier => null;

		public static string Name => null;

		public static string CompanyName => null;

		internal static Version ParseVersion => null;

		public static string BasePath => null;

		public static event Action ProcessExit
		{
			add
			{
			}
			remove
			{
			}
		}

		public static string GetRelativeStorageFallbackPath(bool isFallback, string identifier)
		{
			return null;
		}
	}
}
