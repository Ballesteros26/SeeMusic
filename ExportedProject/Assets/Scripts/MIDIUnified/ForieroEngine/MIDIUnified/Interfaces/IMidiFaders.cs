using System.Collections.Generic;

namespace ForieroEngine.MIDIUnified.Interfaces
{
	public interface IMidiFaders : IMidiObjects
	{
		SortedDictionary<int, IMidiFader> Faders { get; }
	}
}
