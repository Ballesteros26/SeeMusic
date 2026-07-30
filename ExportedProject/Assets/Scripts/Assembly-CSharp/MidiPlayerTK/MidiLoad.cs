using System;
using System.Collections.Generic;

namespace MidiPlayerTK
{
	public class MidiLoad
	{
		public class MidiEventComparer : IComparer<MPTKEvent>
		{
			public int Compare(MPTKEvent x, MPTKEvent y)
			{
				return 0;
			}
		}

		public DIHCMBAGGGN midifile;

		public bool EndMidiEvent;

		public string SequenceTrackName;

		public string ProgramName;

		public string TrackInstrumentName;

		public string TextEvent;

		public string Copyright;

		public double MPTK_PulseLenght;

		public List<MPTKEvent> MPTK_MidiEvents;

		public double MPTK_InitialTempo;

		public List<MPTKTempo> MPTK_TempoMap;

		public TimeSpan MPTK_Duration;

		public float MPTK_DurationMS;

		public long MPTK_TickStart;

		public long MPTK_TickEnd;

		public long MPTK_TickLast;

		public long MPTK_TickCurrent;

		public long MPTK_TickPlayer;

		public MPTKEvent MPTK_LastEventPlayed;

		public long MPTK_TickFirstNote;

		public long MPTK_TickLastNote;

		public double MPTK_PositionFirstNote;

		public double MPTK_PositionLastNote;

		public int MPTK_NumberBeatsMeasure;

		public int MPTK_NumberQuarterBeat;

		public int MPTK_TimeSigNumerator;

		public int MPTK_TimeSigDenominator;

		public int MPTK_KeySigSharpsFlats;

		public int MPTK_KeySigMajorMinor;

		public int MPTK_TicksInMetronomeClick;

		public int MPTK_No32ndNotesInQuarterNote;

		public int MPTK_MicrosecondsPerQuarterNote;

		public int MPTK_DeltaTicksPerQuarterNote;

		public int MPTK_TrackCount;

		public float MPTK_LoadTime;

		public bool MPTK_LogLoadEvents;

		public bool MPTK_KeepNoteOff;

		public bool KeepNoteOff;

		public bool MPTK_KeepEndTrack;

		public bool MPTK_EnableChangeTempo;

		public bool ReadyToStarted;

		public bool ReadyToPlay;

		private long Quantization;

		private double speed;

		public long TickSeek;

		public long TickFromTempoChange;

		private int next_event;

		private int start_msec;

		private int cur_msec;

		private int miditempo;

		private DateTime timeStartLoad;

		private int indexLoadingTrack;

		public double MPTK_CurrentTempo
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double Speed => 0.0;

		public void MPTK_Clear()
		{
		}

		private void InitMidiLoadAttributes()
		{
		}

		public bool MPTK_Load(int index, bool strict = false)
		{
			return false;
		}

		public bool MPTK_Load(byte[] datamidi, bool strict = false)
		{
			return false;
		}

		public bool MPTK_Load(string midiname, bool strict = false)
		{
			return false;
		}

		public List<MPTKEvent> MPTK_ReadMidiEvents(long fromTicks = 0L, long toTicks = long.MaxValue)
		{
			return null;
		}

		public double MPTK_ConvertTickToTime(long tick)
		{
			return 0.0;
		}

		public long MPTK_ConvertTimeToTick(double time)
		{
			return 0L;
		}

		public MPTKEvent MPTK_SearchEventFromTime(double time)
		{
			return null;
		}

		public long MPTK_SearchTickFromTime(double time)
		{
			return 0L;
		}

		public static int MPTK_BPM2MPQN(int bpm)
		{
			return 0;
		}

		public static int MPTK_MPQN2BPM(int microsecondsPerQuaterNote)
		{
			return 0;
		}

		public MPTKEvent.EnumLength NoteLength(MPTKEvent mptkEvent)
		{
			return default(MPTKEvent.EnumLength);
		}

		public void MPTK_DisplayMidiAttributes()
		{
		}

		public static string BuildOSPath(string filename)
		{
			return null;
		}

		private List<MPTKEvent> ConvertNAudioEventsToMPTKEvents()
		{
			return null;
		}

		public static List<MPTKEvent> MPTK_SortEvents(List<MPTKEvent> midiEvents, bool logPerf = false)
		{
			return null;
		}

		public static void Sort<T>(IList<T> list, int lowIndex, int highIndex, IComparer<T> comparer)
		{
		}

		private MPTKEvent ConvertNAudioEventToMPTKEvent(BPLHJJGKANA midiEvent)
		{
			return null;
		}

		private void AnalyseTrackMidiEvent()
		{
		}

		public void MPTK_ComputeDuration()
		{
		}

		public void ClearMetaText()
		{
		}

		public void ChangeSpeed(float speed)
		{
		}

		public void ChangeQuantization(int level = 4)
		{
		}

		public void StartMidi()
		{
		}

		private void fluid_player_set_midi_tempo(int MPQN)
		{
		}

		public void fluid_player_seek(long ticks)
		{
		}

		private void fluid_player_set_bpm(int bpm)
		{
		}

		private int fluid_player_get_bpm()
		{
			return 0;
		}

		public List<MPTKEvent> fluid_player_callback(int msec, int idSession)
		{
			return null;
		}

		private void AnalyzeKeySignature(FNMOGGKMJJK meta, MPTKEvent mptkEvent = null)
		{
		}

		private void AnalyzeTimeSignature(FNMOGGKMJJK meta, MPTKEvent mptkEvent = null)
		{
		}

		private string BuildInfoTrack(MPTKEvent e)
		{
			return null;
		}

		public void DebugTrack()
		{
		}

		public static int MPTK_SearchEventFromTick(List<MPTKEvent> midiEvents, long tickSearched)
		{
			return 0;
		}

		public bool MPTK_LoadFile(string filename, bool strict = false)
		{
			return false;
		}

		public bool MPTK_Load(MidiFileWriter2 mfw2)
		{
			return false;
		}
	}
}
