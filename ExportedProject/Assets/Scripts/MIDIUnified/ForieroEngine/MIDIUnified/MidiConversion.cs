using UnityEngine;

namespace ForieroEngine.MIDIUnified
{
	public static class MidiConversion
	{
		public static TheorySystemEnum theorySystem;

		public static int MidiIndex(NoteEnum note, AccidentalEnum accidental, OctaveEnum octave)
		{
			return 0;
		}

		public static int MidiIndex(this MidiEvents.NoteDef n)
		{
			return 0;
		}

		public static int MidiIndex(this OctaveEnum octave)
		{
			return 0;
		}

		public static byte NoteToMidiIndex(string aMidiString)
		{
			return 0;
		}

		public static int GetByteVolume(float aVolume)
		{
			return 0;
		}

		public static int ToByteVolume(this float volume)
		{
			return 0;
		}

		public static int GetMidiVolume(float aVolume)
		{
			return 0;
		}

		public static int GetByteVolume(float aVolume, int aStreamVolume)
		{
			return 0;
		}

		public static byte OctaveMidiIndex(byte anOctaveIndex)
		{
			return 0;
		}

		public static int AccidentalShift(string anAccidental)
		{
			return 0;
		}

		public static byte BaseMidiIndex(char aNoteName)
		{
			return 0;
		}

		public static int ToBaseMidiIndex(this int aMidiIndex)
		{
			return 0;
		}

		public static int BaseMidiIndex(int aMidiIdx)
		{
			return 0;
		}

		public static bool IsBlackKey(int aMidiIdx)
		{
			return false;
		}

		public static bool IsWhiteKey(int aMidiIdx)
		{
			return false;
		}

		public static int ToIntervalBaseIndex(this string anIntervalName)
		{
			return 0;
		}

		public static IntervalEnum ToIntervalBaseEnum(this string anIntervalName)
		{
			return default(IntervalEnum);
		}

		public static ToneEnum ToToneEnum(this int aMidiIdx)
		{
			return default(ToneEnum);
		}

		public static ToneEnum GetBaseToneFromMidiIndex(int aMidiIdx)
		{
			return default(ToneEnum);
		}

		public static Color ToColor(this NoteEnum aNote)
		{
			return default(Color);
		}

		public static ToneEnum ToToneEnum(this NoteEnum aNote)
		{
			return default(ToneEnum);
		}

		public static Color ToColor(this ToneEnum aTone)
		{
			return default(Color);
		}

		public static string ToToneEnglishName(this int midiIndex, char separator = '/')
		{
			return null;
		}

		public static string GetToneNameFromMidiIndex(int aMidiIdx, char separator = '/', TheorySystemEnum aTheorySystem = TheorySystemEnum.ToneNames, KeySignatureEnum aKeySignature = KeySignatureEnum.CMaj_AMin)
		{
			return null;
		}

		public static string GetToneEnglishNameFromMidiIndex(int aMidiIdx, char separator = '/')
		{
			return null;
		}

		public static string GetToneSolfageNameFromMidiIndex(int aMidiIdx, KeySignatureEnum aKeySignature = KeySignatureEnum.CMaj_AMin, char separator = '/')
		{
			return null;
		}

		public static Color GetToneColorFromMidiIndex(int aMidiIdx)
		{
			return default(Color);
		}

		public static Color HexToRGB(int r, int g, int b)
		{
			return default(Color);
		}

		public static int MidiStringToMidiIndex(string s)
		{
			return 0;
		}

		public static double ToFreq(this int midiIndex)
		{
			return 0.0;
		}
	}
}
