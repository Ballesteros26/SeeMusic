using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Timers;
using ForieroEngine.MIDIUnified;
using ForieroEngine.MIDIUnified.Interfaces;
using ForieroEngine.MIDIUnified.Midi;
using UnityEngine;

public class MidiSeqKaraoke : IMidiSender, IDisposable, MidiSeqKaraoke.IMidiSeqKaraokeEvents, IMidiSeqControl
{
	public class AudioSourceWrapper
	{
		public bool Enabled { get; set; }

		public IAudioSource AudioInterface { get; set; }

		public bool IsValid => false;

		public AudioSourceState GetState()
		{
			return default(AudioSourceState);
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}

		public void Pause()
		{
		}

		public double GetTime()
		{
			return 0.0;
		}

		public void SetTime(double t)
		{
		}

		public void Mute()
		{
		}

		public void UnMute()
		{
		}

		public void SetVolume(float volume)
		{
		}

		public float GetVolume()
		{
			return 0f;
		}

		public void SetClip(AudioClip clip)
		{
		}

		public void SetClip(string clip)
		{
		}

		public void SetSemitone(int t)
		{
		}

		public void SetSpeed(float s)
		{
		}
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

		public float tempo;

		public int[] eventPos;

		public bool[] endOfTrack;
	}

	public enum SynchronizationContext
	{
		Midi = 0,
		Music = 1,
		Vocal = 2,
		Manual = 3
	}

	public interface IMidiSeqKaraokeEvents
	{
		event Action OnInitialized;

		event Action<WordText> OnWord;

		event Action OnWordFinished;

		event Action<WordText> OnWordOffset;

		event Action OnWordOffsetFinished;

		event Action<SentenceText> OnSentence;

		event Action<MidiText> OnVerse;

		event Action OnFinished;

		event Action OnPlay;

		event Action OnResume;

		event Action OnStop;

		event Action OnPause;

		event Action<int> OnRepeat;

		event Action<int> OnPickUpBar;

		event Action<int> OnPickupBarBegin;

		event Action OnPickupBarEnd;

		event Action OnMidiLoaded;

		event Action<float> OnTempoChange;
	}

	public interface IMidiSeqKaraokeCallbacks
	{
		void OnInitializedCallback();

		void OnWordCallback(WordText w);

		void OnWordFinishedCallback();

		void OnWordOffsetCallback(WordText w);

		void OnWordOffsetFinishedCallback();

		void OnSentenceCallback(SentenceText s);

		void OnVerseCallback(MidiText t);

		void OnFinishedCallback();

		void OnPlayCallback();

		void OnContinueCallback();

		void OnStopCallback();

		void OnPauseCallback();

		void OnRepeatCallback(int r);

		void OnPickUpBarCallback(int p);

		void OnPickupBarBeginCallback(int p);

		void OnPickupBarEndCallback();

		void OnMidiLoadedCallback();

		void OnTempoChangeCallback(float t);
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

	public List<Bar> bars;

	private Timer pickupBarTimer;

	public bool debug;

	public SynchronizationContext synchronizationContext;

	public float playingDelay;

	private float _playingDelay;

	private MidiSeqStates _state;

	public float eventsOffset;

	public readonly int PPQNMinValue;

	private int _timeSignatureDenominator;

	private int barTmp;

	private readonly float deltaTimeResolution;

	private double deltaTimeNumerator;

	private double deltaTimeRest;

	private int pickUpBarCounter;

	private bool onPickupBarBeginFired;

	private double fractionalTicks;

	private double lastTime;

	private double dspTime;

	private double lastDspTime;

	private double lastDeltaTime;

	private double lastDeltaTicks;

	private MidiCommandCode command;

	private MidiEvent midiEvent;

	private MetaEvent metaEvent;

	private bool cancelUpdate;

	private double deltaTime;

	private double periodResolution;

	private double deltaTicks;

	private int deltaTimeIterator;

	private int data1;

	public const int MicrosecondsPerMinute = 60000000;

	public const int MicrosecondsPerSecond = 1000000;

	public const int MicrosecondsPerMillisecond = 1000;

	private float lastSpeed;

	private int lastSemitone;

	private SynchronizationContext syncContext;

	private double _time;

	public AudioSourceWrapper MusicInterface { get; }

	public AudioSourceWrapper VocalsInterface { get; }

	public string Id { get; }

	public string Name { get; set; }

	public MidiSeqStates State
	{
		get
		{
			return default(MidiSeqStates);
		}
		private set
		{
		}
	}

	public bool midiOut { get; set; }

	public bool midiThrough { get; set; }

	public bool music
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public AudioClip musicClip { get; private set; }

	public string musicClipId { get; set; }

	public float musicVolume { get; set; }

	public bool vocals
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public AudioClip vocalsClip { get; private set; }

	public string vocalsClipId { get; set; }

	public float vocalsVolume { get; set; }

	public float speed { get; set; }

	public int semitone { get; private set; }

	public double ticks { get; private set; }

	public double time { get; set; }

	public string timeString => null;

	public double timelineStartTime { get; set; }

	public string timelineStartTimeString => null;

	public double duration { get; private set; }

	public string durationString => null;

	public double markerTimeThreshold { get; set; }

	public int beat { get; private set; }

	public int beatCount { get; private set; }

	public bool metronome { get; set; }

	public int bar { get; private set; }

	public int barCount { get; private set; }

	public bool pickUpBar { get; set; }

	public bool pickUpBarOnRepeat { get; set; }

	public bool forceTrackAsChannel { get; set; }

	public int timeSignatureNumerator { get; private set; }

	public int timeSignatureDenominator { get; private set; }

	public int PPQN { get; set; }

	public float tempo { get; private set; }

	public float tempoTicks => 0f;

	public int keyMajorMinor { get; private set; }

	public int keySharpsFlats { get; private set; }

	public List<IList<MidiEvent>> tracks { get; private set; }

	public int[] eventPos { get; private set; }

	public bool[] endOfTrack { get; private set; }

	public bool[] muteTrack { get; private set; }

	public bool repeatBarSelection { get; set; }

	public int startBar { get; set; }

	public int endBar { get; set; }

	public bool initialized { get; private set; }

	private MidiFile MidiFile { get; set; }

	private byte[] MidiBytes { get; set; }

	public bool midiFinished { get; private set; }

	public bool musicFinished { get; private set; }

	public bool vocalsFinished { get; private set; }

	public int lyricTrack { get; set; }

	public int wordPos { get; private set; }

	public int wordOffsetPos { get; private set; }

	public List<WordText> words { get; private set; }

	public float wordTimeOffset { get; set; }

	public float wordTimeFinishedOffset { get; set; }

	public bool forceSentences { get; set; }

	public bool forceSentenceNewLine { get; set; }

	public bool forceCommaNewLine { get; set; }

	public int sentencePos { get; set; }

	public List<SentenceText> sentences { get; private set; }

	public float senteceTimeOffset { get; set; }

	public int versePos { get; private set; }

	public List<MidiText> verses { get; private set; }

	public float versetTimeOffset { get; set; }

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

	public event Action OnInitialized
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

	public event Action OnResume
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

	private int GetBeatCount(double ticks)
	{
		return 0;
	}

	private int GetBeat(int beatCount)
	{
		return 0;
	}

	private void UpdateBars()
	{
	}

	public void SetBar(int aBarNr, bool play, bool pickUpBar = true)
	{
	}

	private void PickUpBar()
	{
	}

	public void Play()
	{
	}

	public void Play(bool aPickUpBar)
	{
	}

	public void Continue()
	{
	}

	private void CancelPickUpBarCounting()
	{
	}

	public void Pause()
	{
	}

	public bool SetVocals(bool v)
	{
		return false;
	}

	public bool SetMusic(bool m)
	{
		return false;
	}

	private void ResetSequencer()
	{
	}

	public void Stop()
	{
	}

	public float SetSpeed(float speed)
	{
		return 0f;
	}

	public int SetSemitone(int semitone)
	{
		return 0;
	}

	public MidiSeqKaraoke(string name = null)
	{
	}

	public MidiSeqKaraoke(string id, string name = null)
	{
	}

	public MidiSeqKaraoke(IAudioSource m, IAudioSource v)
	{
	}

	~MidiSeqKaraoke()
	{
	}

	public void Dispose()
	{
	}

	public double GetCumulativeTonesDuration()
	{
		return 0.0;
	}

	private bool CallEvents()
	{
		return false;
	}

	public double TimeToTicks(double t)
	{
		return 0.0;
	}

	public double TicksToTime(double t)
	{
		return 0.0;
	}

	private bool InitializeMidiFile()
	{
		return false;
	}

	public void SetMusicSource(IAudioSource s)
	{
	}

	public void SetVocalsSource(IAudioSource s)
	{
	}

	public void Initialize(TextAsset midiTextAsset)
	{
	}

	public void Initialize(byte[] midiBytes)
	{
	}

	public void Initialize(TextAsset midiTextAsset, AudioClip vClip, AudioClip mClip)
	{
	}

	public void Initialize(byte[] midiRawBytes, string vClipId, string mClipId)
	{
	}

	public void Initialize(byte[] midiRawBytes, AudioClip vClip, AudioClip mClip)
	{
	}

	private void InitializeCommon(byte[] midiRawBytes)
	{
	}

	private void SetSyncContext()
	{
	}

	private double DSPTime()
	{
		return 0.0;
	}

	public void Update(double manualTime = 0.0)
	{
	}

	private void UpdateTime()
	{
	}

	private int GetTrackEventPosFromAbsoluteTicks(int aTrackIndex, double aAbsoluteTicks)
	{
		return 0;
	}

	private int GetNextBarFromAbsoluteTicks(double aAbsoluteTicks)
	{
		return 0;
	}

	private int GetPrevBarFromAbsoluteTicks(double aAbsoluteTicks)
	{
		return 0;
	}

	private int GetCurrentBarFromAbsoluteTicks(double aAbsoluteTicks)
	{
		return 0;
	}
}
