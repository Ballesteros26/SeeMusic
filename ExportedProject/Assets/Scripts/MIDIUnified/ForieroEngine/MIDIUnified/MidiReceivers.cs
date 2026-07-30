using System.Collections.Generic;

namespace ForieroEngine.MIDIUnified
{
	public static class MidiReceivers
	{
		private static readonly List<IMidiReceiver> Receivers;

		public static void Register(this IMidiReceiver i, bool ignoreNullOrEmptyId = true)
		{
		}

		public static IMidiReceiver GetById(string id)
		{
			return null;
		}

		public static void Unregister(this IMidiReceiver i)
		{
		}
	}
}
