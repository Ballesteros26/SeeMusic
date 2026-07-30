using System.Collections.Generic;
using System.IO;

namespace ForieroEngine.MIDIUnified.Midi
{
	public class MidiFile
	{
		private MidiEventCollection events;

		private ushort fileFormat;

		private ushort deltaTicksPerQuarterNote;

		private bool strictChecking;

		public int FileFormat => 0;

		public MidiEventCollection Events => null;

		public int Tracks => 0;

		public int DeltaTicksPerQuarterNote => 0;

		public MidiFile(Stream stream)
		{
		}

		public MidiFile(Stream stream, bool strictChecking)
		{
		}

		private void FindNoteOn(NoteEvent offEvent, List<NoteOnEvent> outstandingNoteOns)
		{
		}

		private static uint SwapUInt32(uint i)
		{
			return 0u;
		}

		private static ushort SwapUInt16(ushort i)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static void Export(string filename, MidiEventCollection events)
		{
		}
	}
}
