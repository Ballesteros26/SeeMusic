using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MidiPlayerTK
{
	[RequireComponent(typeof(AudioSource))]
	[RequireComponent(typeof(AudioReverbFilter))]
	[HelpURL("https://paxstellar.fr/midi-file-player-detailed-view-2/")]
	[RequireComponent(typeof(AudioChorusFilter))]
	public class MidiFilePlayer : MidiSynth
	{
		public enum ModeStopPlay
		{
			StopNoWaiting = 0,
			StopWhenAllVoicesReleased = 1,
			StopWhenAllVoicesEnded = 2
		}

		[CompilerGenerated]
		private sealed class _003CTheadPlayIfReady_003Ed__119 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public MidiFilePlayer _003C_003E4__this;

			float IEnumerator<float>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0f;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CTheadPlayIfReady_003Ed__119(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CThreadLegacyPlay_003Ed__131 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public MidiFilePlayer _003C_003E4__this;

			public bool alreadyLoaded;

			public byte[] midiBytesToPlay;

			public float fromPosition;

			private double _003CdeltaTime_003E5__2;

			private bool _003Cfirst_003E5__3;

			private string _003CcurrentMidiName_003E5__4;

			float IEnumerator<float>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0f;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CThreadLegacyPlay_003Ed__131(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CThreadCorePlay_003Ed__132 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public MidiFilePlayer _003C_003E4__this;

			public bool alreadyLoaded;

			public byte[] midiBytesToPlay;

			public float fromPosition;

			public float toPosition;

			float IEnumerator<float>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0f;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CThreadCorePlay_003Ed__132(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CThreadInternalMidiPlaying_003Ed__134 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public MidiFilePlayer _003C_003E4__this;

			public float fromPosition;

			public string currentMidiName;

			float IEnumerator<float>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0f;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CThreadInternalMidiPlaying_003Ed__134(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CTheadPlayWithDelay_003Ed__145 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public float delayToStopMillisecond;

			public MidiFilePlayer _003C_003E4__this;

			public float delayToStartMillisecond;

			float IEnumerator<float>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0f;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CTheadPlayWithDelay_003Ed__145(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CThreadMFWPlay_003Ed__147 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public MidiFilePlayer _003C_003E4__this;

			public MidiFileWriter2 mfw2;

			public bool timePosition;

			public long fromTick;

			public long toTick;

			public float fromPosition;

			public float toPosition;

			float IEnumerator<float>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0f;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CThreadMFWPlay_003Ed__147(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		[HideInInspector]
		protected string midiNameToPlay;

		[Header("Attributes below applies on MIDI Player")]
		public bool MPTK_StartPlayAtFirstNote;

		public string[] ModeStopPlayLabel;

		public ModeStopPlay MPTK_ModeStopVoice;

		[SerializeField]
		[HideInInspector]
		private int midiIndexToPlay;

		[HideInInspector]
		[SerializeField]
		private float speed;

		public string durationEditorModeOnly;

		public string playTimeEditorModeOnly;

		[HideInInspector]
		public LoadingStatusMidiEnum MPTK_StatusLastMidiLoaded;

		[HideInInspector]
		public EventNotesMidiClass OnEventNotesMidi;

		[HideInInspector]
		public EventStartMidiClass OnEventStartPlayMidi;

		[HideInInspector]
		public EventEndMidiClass OnEventEndPlayMidi;

		[HideInInspector]
		[SerializeField]
		private int quantization;

		[SerializeField]
		private bool playOnStart;

		[SerializeField]
		private bool replayMidi;

		[SerializeField]
		private bool stopMidi;

		[SerializeField]
		private bool midiIsPlaying;

		[SerializeField]
		private bool loop;

		[SerializeField]
		private bool keepNoteOff;

		[SerializeField]
		private bool keepEndTrack;

		[SerializeField]
		private bool needDelayToStart;

		[SerializeField]
		private bool needDelayToStop;

		private float timeRampUpSecond;

		private float delayRampUpSecond;

		private float timeRampDnSecond;

		private float delayRampDnSecond;

		[SerializeField]
		[HideInInspector]
		public bool nextMidi;

		[HideInInspector]
		[SerializeField]
		public bool prevMidi;

		[Range(0f, 100f)]
		private float delayMilliSeconde;

		private double lastMidiTimePlayAS;

		protected double timeAtStartMidi;

		[HideInInspector]
		protected bool distancePause;

		private bool pauseWhenFocusLost;

		[HideInInspector]
		public bool MPTK_PauseOnFocusLoss;

		public virtual string MPTK_MidiName
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

		[HideInInspector]
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

		public double MPTK_Tempo
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public string MPTK_SequenceTrackName => null;

		public string MPTK_ProgramName => null;

		public string MPTK_TrackInstrumentName => null;

		public string MPTK_TextEvent => null;

		public string MPTK_Copyright => null;

		public float MPTK_Speed
		{
			get
			{
				return 0f;
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

		public bool MPTK_IsPaused => false;

		public bool MPTK_IsPlaying => false;

		public MidiLoad MPTK_MidiLoaded => null;

		public TimeSpan MPTK_Duration => default(TimeSpan);

		public float MPTK_DurationMS => 0f;

		public long MPTK_TickLast => 0L;

		public long MPTK_TickFirstNote => 0L;

		public long MPTK_TickLastNote => 0L;

		public double MPTK_PositionFirstNote => 0.0;

		public double MPTK_PositionLastNote => 0.0;

		public int MPTK_TrackCount => 0;

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

		public MPTKEvent MPTK_LastEventPlayed => null;

		public double MPTK_PulseLenght => 0.0;

		public TimeSpan MPTK_PlayTime => default(TimeSpan);

		public double MPTK_RealTime => 0.0;

		public bool MPTK_KeepNoteOff
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool MPTK_KeepEndTrack
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int MPTK_Quantization
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<MPTKEvent> MPTK_MidiEvents => null;

		public int MPTK_DeltaTicksPerQuarterNote => 0;

		private new void Awake()
		{
		}

		protected void AwakeMidiFilePlayer()
		{
		}

		private new void Start()
		{
		}

		protected void StartMidiFilePlayer()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[IteratorStateMachine(typeof(_003CTheadPlayIfReady_003Ed__119))]
		protected IEnumerator<float> TheadPlayIfReady()
		{
			return null;
		}

		public virtual void MPTK_Play(bool alreadyLoaded = false)
		{
		}

		public void MPTK_Stop()
		{
		}

		public void MPTK_RePlay()
		{
		}

		public void MPTK_Pause(float timeToPauseMS = -1f)
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

		public MPTKEvent.EnumLength MPTK_NoteLength(MPTKEvent note)
		{
			return default(MPTKEvent.EnumLength);
		}

		public MidiLoad MPTK_Load()
		{
			return null;
		}

		public List<MPTKEvent> MPTK_ReadMidiEvents(long fromTicks = 0L, long toTicks = long.MaxValue)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CThreadLegacyPlay_003Ed__131))]
		public IEnumerator<float> ThreadLegacyPlay(byte[] midiBytesToPlay = null, float fromPosition = 0f, float toPosition = 0f, bool alreadyLoaded = false)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CThreadCorePlay_003Ed__132))]
		public IEnumerator<float> ThreadCorePlay(byte[] midiBytesToPlay = null, float fromPosition = 0f, float toPosition = 0f, bool alreadyLoaded = false)
		{
			return null;
		}

		protected void StartPlaying()
		{
		}

		[IteratorStateMachine(typeof(_003CThreadInternalMidiPlaying_003Ed__134))]
		protected IEnumerator<float> ThreadInternalMidiPlaying(string currentMidiName, float fromPosition = 0f, float toPosition = 0f)
		{
			return null;
		}

		public bool MPTK_SearchMidiToPlay(string name)
		{
			return false;
		}

		public bool MPTK_PreLoad(string uri)
		{
			return false;
		}

		public void MPTK_SortEvents()
		{
		}

		public void MPTK_PlayNextOrPrevious(int offset)
		{
		}

		public void MPTK_SwitchMidiWithDelay(int index, string name, float volume, float delayToStopMillisecond, float delayToStartMillisecond)
		{
		}

		public virtual void MPTK_Play(float delayRampUp, float startDelay = 0f)
		{
		}

		public void MPTK_Play(byte[] data)
		{
		}

		public void MPTK_Play(MidiFileWriter2 mfw2, float delayRampUp = 0f, float fromPosition = 0f, float toPosition = 0f, long fromTick = 0L, long toTick = 0L, bool timePosition = true)
		{
		}

		public virtual void MPTK_Stop(float delayRampDown, float stopDelay = 0f)
		{
		}

		public void StopAndPlayMidi(int index, string name)
		{
		}

		[IteratorStateMachine(typeof(_003CTheadPlayWithDelay_003Ed__145))]
		protected IEnumerator<float> TheadPlayWithDelay(float delayToStopMillisecond, float delayToStartMillisecond)
		{
			return null;
		}

		public void PlayAndPauseMidi(int index, string name, int pauseMillisecond = -1)
		{
		}

		[IteratorStateMachine(typeof(_003CThreadMFWPlay_003Ed__147))]
		protected IEnumerator<float> ThreadMFWPlay(MidiFileWriter2 mfw2, float fromPosition = 0f, float toPosition = 0f, long fromTick = 0L, long toTick = 0L, bool timePosition = true)
		{
			return null;
		}
	}
}
