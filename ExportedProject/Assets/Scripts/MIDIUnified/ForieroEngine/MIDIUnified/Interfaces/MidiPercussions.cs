using System.Collections.Generic;

namespace ForieroEngine.MIDIUnified.Interfaces
{
	public class MidiPercussions : IMidiPercussions, IMidiObjects
	{
		public string Id { get; private set; }

		public SortedDictionary<int, IMidiPercussion> Perscussions { get; }

		public void SetId(string id)
		{
		}
	}
}
