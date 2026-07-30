using System.Collections.Generic;

namespace ForieroEngine.MIDIUnified.Interfaces
{
	public class MidiFaders : IMidiFaders, IMidiObjects
	{
		public string Id { get; private set; }

		public SortedDictionary<int, IMidiFader> Faders { get; }

		public void SetId(string id)
		{
		}
	}
}
