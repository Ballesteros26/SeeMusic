using System.Collections.Generic;

namespace ForieroEngine.MIDIUnified.Interfaces
{
	public class MidiKnobs : IMidiKnobs, IMidiObjects
	{
		public string Id { get; private set; }

		public SortedDictionary<int, IMidiKnob> Knobs { get; }

		public void SetId(string id)
		{
		}
	}
}
