using System.Collections.Generic;

namespace ForieroEngine.MIDIUnified.Interfaces
{
	public interface IMidiKnobs : IMidiObjects
	{
		SortedDictionary<int, IMidiKnob> Knobs { get; }
	}
}
