using System.Collections.Generic;

namespace MidiPlayerTK
{
	public class HelperNoteLabel
	{
		public int Midi;

		public string Label;

		public bool Sharp;

		public bool IsNoteC;

		public string Drum;

		private static List<HelperNoteLabel> ListNote;

		private static List<HelperNoteLabel> ListEcart;

		public static float _ratioHalfTone;

		public static bool IsSharp(int midiValue)
		{
			return false;
		}

		public static int NoteNumber(int midiValue)
		{
			return 0;
		}

		public static int OctaveNumber(int midiValue)
		{
			return 0;
		}

		public static string LabelC4FromMidi(int midiValue)
		{
			return null;
		}

		public static string LabelFromMidi(int midiValue)
		{
			return null;
		}

		public static string LabelFromEcart(int valueNote)
		{
			return null;
		}

		public static string LabelPercussion(int midiValue)
		{
			return null;
		}

		public static void Init()
		{
		}
	}
}
