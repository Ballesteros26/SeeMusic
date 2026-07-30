using System;
using System.Collections.Generic;
using UnityEngine;

namespace MidiPlayerTK
{
	[HelpURL("https://paxstellar.fr/midi-list-player-v2/")]
	public class MidiListPlayer : MonoBehaviour
	{
		[Serializable]
		public class MPTK_MidiPlayItem
		{
			public string MidiName;

			public bool UIAction;

			public bool Selected;

			public int Index;

			public float StartFrom;

			public float EndFrom;

			public long LastTick;

			public float RealDurationMs;

			public double TickLengthMs;

			public override string ToString()
			{
				return null;
			}
		}

		public enum enStatusPlayer
		{
			Starting = 0,
			Playing = 1,
			Ending = 2,
			Stopped = 3
		}

		[Serializable]
		public class MidiListPlayerStatus
		{
			public MidiFilePlayer MPTK_MidiFilePlayer;

			public enStatusPlayer StatusPlayer;

			public float EndAt;

			public float Volume;

			public float PctVolume;

			public void UpdateVolume()
			{
			}
		}

		[HideInInspector]
		public bool showDefault;

		[SerializeField]
		[HideInInspector]
		private float volume;

		[HideInInspector]
		public int indexlabFormatMidiTime;

		public List<MPTK_MidiPlayItem> MPTK_PlayList;

		[HideInInspector]
		public EventStartMidiClass OnEventStartPlayMidi;

		[HideInInspector]
		public EventEndMidiClass OnEventEndPlayMidi;

		public MidiListPlayerStatus MPTK_MidiFilePlayer_1;

		public MidiListPlayerStatus MPTK_MidiFilePlayer_2;

		public float MPTK_OverlayTimeMS;

		[SerializeField]
		[HideInInspector]
		private bool playOnStart;

		[SerializeField]
		[HideInInspector]
		private bool loop;

		[HideInInspector]
		[SerializeField]
		private int playIndex;

		public float MPTK_Volume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int MPTK_PlayIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private MidiListPlayerStatus GetFirstAvailable => null;

		public MidiListPlayerStatus MPTK_GetPlaying => null;

		public MidiListPlayerStatus MPTK_GetStarting => null;

		public MidiListPlayerStatus MPTK_GetEnding => null;

		public MidiListPlayerStatus MPTK_GetPausing => null;

		public bool MPTK_PlayOnStart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool MPTK_Loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public double MPTK_Position
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public long MPTK_TickLast => 0L;

		public long MPTK_TickCurrent
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public TimeSpan MPTK_Duration => default(TimeSpan);

		public bool MPTK_IsPaused => false;

		public bool MPTK_IsPlaying => false;

		private void SetVolume(float value)
		{
		}

		private void Awake()
		{
		}

		public void EventStartPlayMidi(string midiname)
		{
		}

		public void EventEndPlayMidi(string midiname, EventEndMidiEnum reason)
		{
		}

		private void Start()
		{
		}

		public void Update()
		{
		}

		public void MPTK_NewList()
		{
		}

		public void MPTK_AddMidi(string name, float start = 0f, float end = 0f)
		{
		}

		public void MPTK_ChangeMidi(string name, int indexList)
		{
		}

		public void MPTK_RemoveMidi(string name)
		{
		}

		public void MPTK_RemoveMidiAt(int index)
		{
		}

		public MPTK_MidiPlayItem MPTK_GetAt(int index)
		{
			return null;
		}

		public void MPTK_ReIndexMidi()
		{
		}

		public void MPTK_Play()
		{
		}

		public void MPTK_Stop()
		{
		}

		public void MPTK_RePlay()
		{
		}

		public void MPTK_Pause()
		{
		}

		public void MPTK_UnPause()
		{
		}

		public void MPTK_Next()
		{
		}

		public void MPTK_Previous()
		{
		}
	}
}
