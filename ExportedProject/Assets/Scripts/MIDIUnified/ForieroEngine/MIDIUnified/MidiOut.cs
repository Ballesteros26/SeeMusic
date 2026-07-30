using System;
using System.Runtime.CompilerServices;

namespace ForieroEngine.MIDIUnified
{
	public static class MidiOut
	{
		public struct NoteCache
		{
			public int Index;

			public bool On;
		}

		public class ChannelCache
		{
			public NoteCache[] notes;
		}

		public static class MidiStringParser
		{
			private static string[] items;

			private static CommandEnum command;

			private static int transposition;

			private static float masterVolume;

			public static void Parse(string s, float masterVolume = 1f, int transposition = 0)
			{
			}

			private static bool ParseChannel(string s, out int ch)
			{
				ch = default(int);
				return false;
			}

			private static void ParseStrings(string s, string defaultValue, out string[] result)
			{
				result = null;
			}

			private static void ParseTones(string s, out int[] result)
			{
				result = null;
			}

			private static void ParsePercussions(string s, out PercussionEnum[] result)
			{
				result = null;
			}

			private static void ParseFloats(string s, float defaultValue, out float[] result, int length)
			{
				result = null;
			}

			private static void ParsePercussion()
			{
			}

			private static void ParseNoteON()
			{
			}

			private static void ParseNoteOFF()
			{
			}

			private static void ParseInstrument()
			{
			}
		}

		public static int channelMask;

		public static int synthChannelMask;

		public static bool fireMidiOutEvents;

		public static int lastMidiChannelCommand;

		public static int lastMidiChannelData1;

		public static int lastMidiChannelData2;

		public static int lastMidiChannelInfinityCounter;

		public static bool applyChannelVolumes;

		public static float[] volumes;

		public static ChannelCache[] channelCache;

		public static bool muteMessages;

		public static bool ignoreProgramMessages;

		public static ProgramEnum[] programEnums;

		public static bool ignorePitchBend;

		public static event ShortMessageEventHandler ShortMessageEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static int SetInstrument(ProgramEnum anInstrument, ChannelEnum aChannel = ChannelEnum.C0)
		{
			return 0;
		}

		public static int SetInstrument(int anInstrument, int aChannel = 0, int deviceId = -1)
		{
			return 0;
		}

		public static void InitPercussion(bool all = false)
		{
		}

		public static double SchedulePercussion(PercussionEnum aPercussion, int aVolume = 80, double scheduleTime = 0.0, bool absoluteDspTime = false)
		{
			return 0.0;
		}

		public static int Percussion(PercussionEnum aPercussion, int aVolume = 80)
		{
			return 0;
		}

		public static void NoteDispatch(int aNoteIndex, float aDuration = 0f, float aDelay = 0f, int aVolume = 80, int aChannel = 0, int deviceId = -1, Action started = null, Action finished = null)
		{
		}

		public static void NoteDispatch(NoteEnum aNote, AccidentalEnum anAccidental, OctaveEnum anOctave, float aDuration = 0f, float aDelay = 0f, int aVolume = 80, ChannelEnum aChannel = ChannelEnum.C0, int deviceId = -1)
		{
		}

		public static int NoteOn(int aNoteIndex, int aVolume = 80, int aChannel = 0, int deviceId = -1, bool editor = false)
		{
			return 0;
		}

		public static int NoteOn(NoteEnum aNote, AccidentalEnum anAccidental, OctaveEnum anOctave, int aVolume = 80, ChannelEnum aChannel = ChannelEnum.C0, int deviceId = -1, bool editor = false)
		{
			return 0;
		}

		public static int NoteOff(int aNoteIndex, int aChannel = 0, int deviceId = -1, bool editor = false)
		{
			return 0;
		}

		public static int NoteOff(NoteEnum aNote, AccidentalEnum anAccidental, OctaveEnum anOctave, ChannelEnum aChannel = ChannelEnum.C0, int deviceId = -1, bool editor = false)
		{
			return 0;
		}

		public static int Pedal(int aPedal, int aValue, int aChannel = 0, int deviceId = -1)
		{
			return 0;
		}

		public static int Pedal(PedalEnum aPedal, int aValue, ChannelEnum aChannel = ChannelEnum.C0, int deviceId = -1)
		{
			return 0;
		}

		public static int SendControl(ControllerEnum aControl, int aValue, ChannelEnum aChannel = ChannelEnum.C0, int deviceId = -1)
		{
			return 0;
		}

		public static int SendControl(int aControl, int aValue, int aChannel = 0, int deviceId = -1)
		{
			return 0;
		}

		public static void ChannelSoundsOff(int aChannel, int deviceId = -1)
		{
		}

		public static void ChannelPedalsOff(int aChannel, int deviceId = -1)
		{
		}

		public static int AllPedalsOff(int deviceId = -1)
		{
			return 0;
		}

		public static int AllSoundOff(int deviceId = -1)
		{
			return 0;
		}

		public static int ResetAllControllers(int deviceId = -1)
		{
			return 0;
		}

		public static int SendShortMessage(int aCommand, int aChannel, int aData1, int aData2, int deviceId, bool editor = false)
		{
			return 0;
		}

		public static void IsInfiniteLoop(int aChannelCommand, int aData1, int aData2)
		{
		}

		public static int SendShortMessage(int aChannelCommand, int aData1, int aData2, int deviceId, bool editor = false)
		{
			return 0;
		}

		public static int SendData(byte[] aData, int deviceId = -1)
		{
			return 0;
		}

		public static void SendString(string s, float masterVolume = 1f, int transposition = 0)
		{
		}
	}
}
