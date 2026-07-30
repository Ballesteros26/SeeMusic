using System.Collections.Generic;

namespace MidiPlayerTK
{
	public class MidiFileWriter2
	{
		public int MPTK_DeltaTicksPerQuarterNote;

		public int MPTK_NumberBeatsMeasure;

		private int _bpm;

		public List<MPTKTempo> MPTK_TempoMap;

		public int MPTK_MidiFileType;

		public string MPTK_MidiName;

		public List<MPTKEvent> MPTK_MidiEvents;

		public long MPTK_TickLast;

		public Dictionary<long, MPTKStat> MPTK_TrackStat;

		public int Bpm => 0;

		public int MPTK_MicrosecondsPerQuaterNote => 0;

		public double MPTK_Tempo => 0.0;

		public float MPTK_PulseLenght => 0f;

		public int MPTK_TrackCount => 0;

		public MPTKEvent MPTK_LastEvent => null;

		public int MPTK_CountEvent => 0;

		public static int MPTK_GetMicrosecondsPerQuaterNote(int bpm)
		{
			return 0;
		}

		public static int MPTK_BPM2MPQN(int bpm)
		{
			return 0;
		}

		public static int MPTK_MPQN2BPM(int microsecondsPerQuaterNote)
		{
			return 0;
		}

		public long MPTK_ConvertTickToMilli(long tick)
		{
			return 0L;
		}

		public long MPTK_ConvertMilliToTick(float time)
		{
			return 0L;
		}

		public MidiFileWriter2(int deltaTicksPerQuarterNote = 240, int midiFileType = 1, int bpm = 120)
		{
		}

		public void MPTK_Clear()
		{
		}

		public void MPTK_CreateTempoMap()
		{
		}

		public bool MPTK_ImportFromEventsList(List<MPTKEvent> midiEventsToInsert, int deltaTicksPerQuarterNote, long position = -1L, string name = null, bool logDebug = false)
		{
			return false;
		}

		public bool MPTK_LoadFromMPTK()
		{
			return false;
		}

		public bool MPTK_LoadFromFile(string filename)
		{
			return false;
		}

		public bool MPTK_LoadFromMidiDB(int indexMidiDb)
		{
			return false;
		}

		public Dictionary<long, MPTKStat> MPTK_CreateTracksStat()
		{
			return null;
		}

		private void UpdateStatTrack(MPTKEvent midiEvent)
		{
		}

		public void MPTK_CreateTrack(int count)
		{
		}

		public void MPTK_EndTrack(int trackNumber)
		{
		}

		public void MPTK_AddRawEvent(MPTKEvent mptkEvent)
		{
		}

		public void MPTK_AddNoteMilli(int track, float timeToPlay, int channel, int note, int velocity, float duration)
		{
		}

		public void MPTK_AddNote(int track, long tick, int channel, int note, int velocity, int length)
		{
		}

		public void MPTK_AddSilenceMilli(int track, float timeToPlay, int channel, float duration)
		{
		}

		public void MPTK_AddSilence(int track, long tick, int channel, int length)
		{
		}

		public void MPTK_AddOffMilli(int track, float timeToPlay, int channel, int note)
		{
		}

		public void MPTK_AddOff(int track, long tick, int channel, int note)
		{
		}

		private void CalculateLastTick(MPTKEvent midiEvent)
		{
		}

		public void MPTK_AddChordFromRange(int track, long tick, int channel, MPTKRangeLib range, MPTKChordBuilder chord)
		{
		}

		public void MPTK_AddChordFromLib(int track, long tick, int channel, MPTKChordName chordName, MPTKChordBuilder chord)
		{
		}

		public void MPTK_AddChangePresetMilli(int track, float timeToPlay, int channel, int preset)
		{
		}

		public void MPTK_AddChangePreset(int track, long tick, int channel, int preset)
		{
		}

		public void MPTK_AddChannelAfterTouchMilli(int track, float timeToPlay, int channel, int afterTouchPressure)
		{
		}

		public void MPTK_AddChannelAfterTouch(int track, long tick, int channel, int afterTouchPressure)
		{
		}

		public void MPTK_AddControlChangeMilli(int track, float timeToPlay, int channel, MPTKController controller, int controllerValue)
		{
		}

		public void MPTK_AddControlChange(int track, long tick, int channel, MPTKController controller, int controllerValue)
		{
		}

		public void MPTK_AddPitchWheelChangeMilli(int track, float timeToPlay, int channel, float pitchWheel)
		{
		}

		public void MPTK_AddPitchWheelChange(int track, long tick, int channel, float pitchWheel)
		{
		}

		public void MPTK_AddBPMChange(int track, long tick, int bpm)
		{
		}

		public void MPTK_AddTempoChange(int track, long tick, int microsecondsPerQuarterNote)
		{
		}

		private void AddToTempoMap(int track, long tick, int microsecondsPerQuarterNote)
		{
		}

		public void MPTK_AddTimeSignature(int track, long tick, int numerator = 4, int denominator = 4, int ticksInMetronomeClick = 24, int no32ndNotesInQuarterNote = 32)
		{
		}

		public void MPTK_AddTextMilli(int track, float timeToPlay, MPTKMeta typeMeta, string text)
		{
		}

		public void MPTK_AddText(int track, long tick, MPTKMeta typeMeta, string text)
		{
		}

		public void MPTK_DeleteChannel(int channel)
		{
		}

		public void MPTK_DeleteTrack(int track)
		{
		}

		public void MPTK_StableSortEvents(bool logPerf = false)
		{
		}

		public bool MPTK_WriteToFile(string filename)
		{
			return false;
		}

		public bool MPTK_WriteToMidiDB(string filename)
		{
			return false;
		}

		public DIHCMBAGGGN MPTK_BuildNAudioMidi()
		{
			return null;
		}

		public bool MPTK_Debug()
		{
			return false;
		}

		public bool MPTK_DebugRaw()
		{
			return false;
		}

		private static bool Test(string source, string target)
		{
			return false;
		}
	}
}
