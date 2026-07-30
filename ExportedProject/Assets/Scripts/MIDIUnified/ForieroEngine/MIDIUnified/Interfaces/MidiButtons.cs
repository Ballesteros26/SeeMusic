using System.Collections.Generic;

namespace ForieroEngine.MIDIUnified.Interfaces
{
	public class MidiButtons : IMidiButtons, IMidiObjects
	{
		public string Id { get; private set; }

		public SortedDictionary<int, IMidiButton> Buttons { get; }

		public void SetId(string id)
		{
		}
	}
}
