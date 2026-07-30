using System.Collections.Generic;

namespace ForieroEngine.MIDIUnified.Interfaces
{
	public static class MidiControllers
	{
		public static IMidiController Selected;

		private static readonly List<IMidiController> Controllers;

		public static void Register(this IMidiController i, bool ignoreNullOrEmptyId = true)
		{
		}

		public static IMidiController GetById(string id)
		{
			return null;
		}

		public static void Unregister(this IMidiController i)
		{
		}
	}
}
