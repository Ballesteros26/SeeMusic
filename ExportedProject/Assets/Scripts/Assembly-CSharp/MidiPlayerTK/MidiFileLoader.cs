using System;
using System.Collections.Generic;
using UnityEngine;

namespace MidiPlayerTK
{
	[HelpURL("https://paxstellar.fr/prefab-midifileloader/")]
	public class MidiFileLoader : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		private string midiNameToPlay;

		[SerializeField]
		[HideInInspector]
		private int midiIndexToPlay;

		public bool MPTK_LogLoadEvents;

		public bool MPTK_KeepNoteOff;

		public bool MPTK_KeepEndTrack;

		public double MPTK_InitialTempo;

		public TimeSpan MPTK_Duration;

		public long MPTK_TickLast;

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

		private MidiLoad midiLoaded;

		public string MPTK_MidiName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int MPTK_MidiIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float MPTK_DurationMS => 0f;

		public List<MPTKEvent> MPTK_MidiEvents => null;

		public MidiLoad MPTK_MidiLoaded => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public bool MPTK_Load(byte[] midiBytesToLoad = null)
		{
			return false;
		}

		private void SetAttributes()
		{
		}

		public List<MPTKEvent> MPTK_ReadMidiEvents(long fromTicks = 0L, long toTicks = long.MaxValue)
		{
			return null;
		}

		private void NoMidiLoaded(string action)
		{
		}

		public void MPTK_Next()
		{
		}

		public void MPTK_Previous()
		{
		}

		public MPTKEvent.EnumLength MPTK_NoteLength(MPTKEvent note)
		{
			return default(MPTKEvent.EnumLength);
		}

		public bool MPTK_Load(string filePath)
		{
			return false;
		}

		public bool MPTK_SearchMidiToPlay(string name)
		{
			return false;
		}
	}
}
