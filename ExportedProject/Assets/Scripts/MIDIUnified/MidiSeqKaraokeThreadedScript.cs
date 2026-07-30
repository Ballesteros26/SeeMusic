using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using ForieroEngine.Collections.NonBlocking;
using ForieroEngine.MIDIUnified;
using ForieroEngine.MIDIUnified.Midi;
using UnityEngine;

public class MidiSeqKaraokeThreadedScript : MonoBehaviour, IMidiSender
{
	private enum StateAudioSource
	{
		None = 0,
		Playing = 1,
		Paused = 2,
		Finished = 3
	}

	public enum MidiState
	{
		None = 0,
		Loading = 1,
		PickUpBar = 2,
		Playing = 3,
		Pausing = 4,
		Finished = 5
	}

	public enum SynchronizationContext
	{
		Midi = 0,
		Music = 1,
		Vocal = 2
	}

	public enum AudioInput
	{
		Unity = 0,
		BASS24 = 1
	}

	private class ThreadedSequencer
	{
		private class SequencerThread
		{
			private class Events
			{
				public MidiCommandCode command;

				public int data1;

				public MidiEvent midiEvent;

				public MetaEvent metaEvent;
			}

			private class Lyrics
			{
				public int lyricTrack;

				public int wordPos;

				public int wordOffsetPos;

				public List<WordText> words;

				public float wordTimeOffset;

				public float wordTimeFinishedOffset;

				[Tooltip("Will force each sentence ending to be really a sentence. Sometimes there is no [NS] tag in midi file.")]
				public bool forceSentences;

				public bool forceSentenceNewLine;

				public bool forceCommaNewLine;

				public int sentencePos;

				public List<SentenceText> sentences;

				public float senteceTimeOffset;

				public int versePos;

				public List<MidiText> verses;

				public float versetTimeOffset;

				public void ResetForPlaying()
				{
				}

				public void ResetForLoading()
				{
				}
			}

			private class Midi
			{
				public MidiFile midiFile;

				public bool forceTrackAsChannel;

				public List<Bar> bars;

				public int keyMajorMinor;

				public int keySharpsFlats;

				public int timeSignatureNumerator;

				public int timeSignatureDenominator;

				public int PPQN;

				public double tempo;

				public double speed;

				public int semitone;

				public int beat;

				public int beatCount;

				public int bar;

				public int barTmp;

				public int barCount;

				public bool pickupBar;

				public bool pickUpBarOnRepeat;

				public bool repeatBarSelection;

				public int startBar;

				public int endBar;

				public List<IList<MidiEvent>> tracks;

				public int[] eventPos;

				public bool[] endOfTrack;

				public bool[] muteTrack;

				public int GetTrackEventPosFromAbsoluteTicks(int aTrackIndex, double aAbsoluteTicks)
				{
					return 0;
				}

				public void ResetForPlaying()
				{
				}

				public void ResetForLoading()
				{
				}
			}

			private class PickupBar
			{
				public int timeSignatureNumerator;

				public double beatTime;

				public double lastDspTime;

				public double time;

				public int counter;

				public void Start(double beatTime, int timeSignatureNumerator)
				{
				}
			}

			private class Time
			{
				public double time;

				public double ticks;

				public double totalTime;

				public readonly double deltaTimeResolution;

				public double deltaTime;

				public double periodResolution;

				public double deltaTicks;

				public int deltaTimeIterator;

				public double fractionalTicks;

				public double lastTime;

				public double dspTime;

				public double lastDspTime;

				public double lastDeltaTime;

				public double lastDeltaTicks;

				public double deltaTimeNumerator;

				public double deltaTimeRest;

				public void ResetForPlaying()
				{
				}

				public void ResetForLoading()
				{
				}
			}

			private bool _initialized;

			public bool loading;

			private NonBlockingQueue<ThreadSignal> signals;

			public Action<bool> onFinished;

			private readonly Thread thread;

			private bool terminating;

			public bool threaded;

			private Events events;

			public byte[] bytes;

			private Lyrics lyrics;

			private Midi midi;

			private PickupBar pickupBar;

			private MidiState _state;

			public SynchronizationContext synchronizationContext;

			public bool midiOut;

			public bool synth;

			private bool cancelUpdate;

			private bool midiFinished;

			private bool musicFinished;

			private bool vocalsFinished;

			private Time time;

			public bool initialized => false;

			public double speed
			{
				get
				{
					return 0.0;
				}
				set
				{
				}
			}

			public int semitone
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool forceTrackAsChannel
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public MidiState state
			{
				get
				{
					return default(MidiState);
				}
				set
				{
				}
			}

			private void Play(bool pickUp)
			{
			}

			private void Play()
			{
			}

			private void PlayWithPickupBar()
			{
			}

			private void Stop()
			{
			}

			private void Pause()
			{
			}

			private void Reset()
			{
			}

			private void StartPickupBar()
			{
			}

			private void ThreadRunner()
			{
			}

			public void Run()
			{
			}

			public void SendSignal(ThreadSignal aSignal)
			{
			}

			public void Terminate()
			{
			}

			private bool CallEvents()
			{
				return false;
			}

			private bool Init()
			{
				return false;
			}

			private void UpdateBars()
			{
			}

			public void SetBar(int aBarNr, bool play, bool pickUpBar = true)
			{
			}

			private void UpdatePickuBar()
			{
			}

			public double TimeToTicks(double aTime)
			{
				return 0.0;
			}

			public double TicksToTime(double ticks)
			{
				return 0.0;
			}

			public double TempoTicks()
			{
				return 0.0;
			}

			private void UpdateTime()
			{
			}

			private void OnInitialized(bool b)
			{
			}

			private void OnMidiLoaded()
			{
			}

			private void OnFinished()
			{
			}

			private void OnPlay()
			{
			}

			private void OnContinue()
			{
			}

			private void OnStop()
			{
			}

			private void OnPause()
			{
			}

			private void OnWord(WordText w)
			{
			}

			private void OnWordFinished()
			{
			}

			private void OnWordOffset(WordText w)
			{
			}

			private void OnWordOffsetFinished()
			{
			}

			private void OnSentence(SentenceText s)
			{
			}

			private void OnVerse(MidiText t)
			{
			}

			private void OnRepeat(int b)
			{
			}

			private void OnPickUpBar(int b)
			{
			}

			private void OnPickupBarBegin(int b)
			{
			}

			private void OnPickupBarEnd()
			{
			}

			private void OnTempoChange(double t)
			{
			}

			private void SetMusicTime(double t)
			{
			}

			private void SetVocalsTime(double t)
			{
			}

			private void PlayMusic()
			{
			}

			private void PlayVocals()
			{
			}

			private void PauseMusic()
			{
			}

			private void PauseVocals()
			{
			}

			private void Call(Action f)
			{
			}

			private void Update()
			{
			}
		}

		public enum ThreadSignal
		{
			None = 0,
			Init = 1,
			Play = 2,
			PlayWithPickupBar = 3,
			Stop = 4,
			Pause = 5,
			Reset = 6
		}

		private SequencerThread thread;

		public const int MicrosecondsPerMinute = 60000000;

		public const int MicrosecondsPerSecond = 1000000;

		public const int MicrosecondsPerMillisecond = 1000;

		public const int PPQNMinValue = 24;

		public MidiState state => default(MidiState);

		public bool midiOut
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool synth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public double speed
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public int semitone
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool threaded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void Run()
		{
		}

		public void Initialize(byte[] midiBytes, Action<bool> onFinished)
		{
		}

		public void Play(bool aPickupBar)
		{
		}

		public void Stop()
		{
		}

		public void Pause()
		{
		}

		public void Continue()
		{
		}

		public void Reset()
		{
		}

		public void Terminate()
		{
		}

		private void PickUpBar()
		{
		}
	}

	public class MidiText
	{
		public string text;

		public long absoluteStartTime;

		public long absoluteEndTime;

		public int deltaTime;

		public bool finishFired;

		public bool finishOffsetFired;

		public List<string> commands;
	}

	public class WordText : MidiText
	{
		public bool newSentence;

		public bool newVerse;
	}

	public class SentenceText : MidiText
	{
		public bool newVerse;
	}

	public class Bar
	{
		public double time;

		public double ticks;

		public double timeDuration;

		public double ticksDuration;

		public int timeSignatureNumerator;

		public int timeSignatureDenominator;

		public int majorMinor;

		public int sharpsFlats;

		public double tempo;

		public int[] eventPos;

		public bool[] endOfTrack;
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MidiSeqKaraokeThreadedScript _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
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
		public _003CStart_003Ed__82(int _003C_003E1__state)
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

	public static MidiSeqKaraokeThreadedScript singleton;

	public string id;

	public bool threaded;

	public bool playOnStart;

	public float delay;

	public AudioInput audioInput;

	public SynchronizationContext synchronizationContext;

	public TextAsset midiFileTextAsset;

	public bool midiOut;

	public bool synth;

	public bool music;

	public AudioSource audioMusic;

	public AudioClip musicClip;

	public float musicVolume;

	public bool vocals;

	public AudioSource audioVocals;

	public AudioClip vocalsClip;

	public float vocalsVolume;

	[Range(0.1f, 10f)]
	public float speed;

	[Range(-12f, 12f)]
	public int semitone;

	public double ticks;

	public double time;

	public double totalTime;

	public int beat;

	public int beatCount;

	public bool metronome;

	public int bar;

	public int barCount;

	public bool pickUpBar;

	public bool pickUpBarOnRepeat;

	public bool forceTrackAsChannel;

	public int timeSignatureNumerator;

	public int timeSignatureDenominator;

	public int PPQN;

	public float tempo;

	public int keyMajorMinor;

	public int keySharpsFlats;

	public bool repeatBarSelection;

	public int startBar;

	public int endBar;

	private float lastSpeed;

	private int lastSemitone;

	private bool lastThreaded;

	private SynchronizationContext syncContext;

	private ThreadedSequencer seq;

	public string Id => null;

	public MidiState state => default(MidiState);

	public float tempoTicks => 0f;

	public event ShortMessageEventHandler ShortMessageEvent
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

	public event Action OnMidiLoaded
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

	public event Action<bool> OnInitialized
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

	public event Action OnPlay
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

	public event Action OnContinue
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

	public event Action OnStop
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

	public event Action OnPause
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

	public event Action OnFinished
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

	public event Action<int> OnRepeat
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

	public event Action<int> OnPickUpBar
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

	public event Action<int> OnPickupBarBegin
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

	public event Action OnPickupBarEnd
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

	public event Action<WordText> OnWord
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

	public event Action OnWordFinished
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

	public event Action<WordText> OnWordOffset
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

	public event Action OnWordOffsetFinished
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

	public event Action<SentenceText> OnSentence
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

	public event Action<MidiText> OnVerse
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

	public event Action<float> OnTempoChange
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

	private bool CheckMusic()
	{
		return false;
	}

	private StateAudioSource GetMusicState()
	{
		return default(StateAudioSource);
	}

	private void PlayMusic()
	{
	}

	private void StopMusic()
	{
	}

	private void PauseMusic()
	{
	}

	private double GetMusicTime()
	{
		return 0.0;
	}

	private void SetMusicTime(double time)
	{
	}

	private void MuteMusic()
	{
	}

	private void UnMuteMusic()
	{
	}

	public void SetMusicVolume(float volume)
	{
	}

	public float GetMusicVolume()
	{
		return 0f;
	}

	private void SetMusicClip(AudioClip clip)
	{
	}

	private void SetMusicSemitone(int semitone)
	{
	}

	private void SetMusicSpeed(float speed)
	{
	}

	private bool CheckVocals()
	{
		return false;
	}

	private StateAudioSource GetVocalsState()
	{
		return default(StateAudioSource);
	}

	private void PlayVocals()
	{
	}

	private void StopVocals()
	{
	}

	private void PauseVocals()
	{
	}

	private double GetVocalsTime()
	{
		return 0.0;
	}

	private void SetVocalsTime(double time)
	{
	}

	private void MuteVocals()
	{
	}

	private void UnMuteVocals()
	{
	}

	public void SetVocalsVolume(float volume)
	{
	}

	public float GetVocalVolume()
	{
		return 0f;
	}

	private void SetVocalsClip(AudioClip clip)
	{
	}

	private void SetVocalsSemitone(int semitone)
	{
	}

	private void SetVocalsSpeed(float speed)
	{
	}

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__82))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void Play(bool aPickUpBar)
	{
	}

	public void Continue()
	{
	}

	public void Stop()
	{
	}

	public void Pause()
	{
	}

	private void Reset()
	{
	}

	public void SetVocals(bool v)
	{
	}

	public void SetMusic(bool m)
	{
	}

	public void SetSpeed(float speed)
	{
	}

	public void SetSemitone(int semitone)
	{
	}

	public void Initialize(TextAsset aMidiFile, AudioClip aVocalClip, AudioClip aMusicClip, Action<bool> onFinished)
	{
	}

	public void Initialize(byte[] bytes, AudioClip vocalsClip, AudioClip musicClip, Action<bool> onFinished)
	{
	}

	private void SetSyncContext()
	{
	}
}
