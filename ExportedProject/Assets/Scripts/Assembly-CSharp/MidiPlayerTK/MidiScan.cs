using System.Collections.Generic;

namespace MidiPlayerTK
{
	public class MidiScan
	{
		public static int CountMidiEvents;

		public static List<string> GeneralInfoMPTKEvent(string pathfilename, bool withNoteOn, bool withNoteOff, bool withControlChange, bool withPatchChange, bool withAfterTouch, bool withMeta, bool withOthers)
		{
			return null;
		}

		public static List<List<BPLHJJGKANA>> GetEventFromRawMIDI(string pathfilename, bool withNoteOn, bool withNoteOff, bool withPitchWheelChange, bool withControlChange, bool withPatchChange, bool withAfterTouch, bool withMeta, bool withOthers)
		{
			return null;
		}

		public static List<string> RawScanLegend()
		{
			return null;
		}

		public static string ConvertnAudioEventToString(BPLHJJGKANA nAudioMidievent, int track)
		{
			return null;
		}

		private static string BuildInfoTrack(MPTKEvent e)
		{
			return null;
		}

		private static string BuildInfoTrack(BPLHJJGKANA e, int track)
		{
			return null;
		}
	}
}
