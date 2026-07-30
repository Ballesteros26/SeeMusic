using System.Collections.Generic;

namespace ForieroEngine.MIDIUnified.Plugins
{
	public static class TimeProviders
	{
		private static readonly List<ITimeProvider> _providers;

		public static ITimeProvider iTimeProvider { get; private set; }

		public static void Register(this ITimeProvider i, bool ignoreNullOrEmptyId = true)
		{
		}

		public static ITimeProvider GetById(string id)
		{
			return null;
		}

		public static void Unregister(this ITimeProvider i)
		{
		}

		public static void Init(string id)
		{
		}
	}
}
