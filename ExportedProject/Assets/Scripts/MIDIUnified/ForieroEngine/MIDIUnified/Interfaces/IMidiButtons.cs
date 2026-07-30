using System.Collections.Generic;

namespace ForieroEngine.MIDIUnified.Interfaces
{
	public interface IMidiButtons : IMidiObjects
	{
		SortedDictionary<int, IMidiButton> Buttons { get; }
	}
}
