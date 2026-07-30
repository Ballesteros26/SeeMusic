using System.Collections.Generic;

namespace ForieroEngine.MIDIUnified
{
	public static class MidiSenders
	{
		private static readonly List<IMidiSender> Senders;

		public static void Register(this IMidiSender i, bool ignoreNullOrEmptyId = true)
		{
		}

		public static IMidiSender GetById(string id)
		{
			return null;
		}

		public static void Unregister(this IMidiSender i)
		{
		}
	}
}
