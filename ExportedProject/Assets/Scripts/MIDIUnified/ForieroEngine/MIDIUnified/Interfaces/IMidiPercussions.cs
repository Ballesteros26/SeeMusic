using System.Collections.Generic;

namespace ForieroEngine.MIDIUnified.Interfaces
{
	public interface IMidiPercussions : IMidiObjects
	{
		SortedDictionary<int, IMidiPercussion> Perscussions { get; }
	}
}
