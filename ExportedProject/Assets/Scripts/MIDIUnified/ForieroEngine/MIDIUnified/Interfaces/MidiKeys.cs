using System.Collections.Generic;

namespace ForieroEngine.MIDIUnified.Interfaces
{
	public class MidiKeys : IMidiKeys, IMidiObjects
	{
		public string Id { get; private set; }

		public SortedDictionary<int, IMidiKey> Keys { get; }

		public void SetId(string id)
		{
		}
	}
}
