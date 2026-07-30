using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ForieroEngine.MIDIUnified;
using ForieroEngine.MIDIUnified.Interfaces;
using ForieroEngine.MIDIUnified.Midi;
using UnityEngine;

public class MidiSeqKaraokeScript : MonoBehaviour, IMidiSender, IMidiSeqControl, MidiSeqKaraoke.IMidiSeqKaraokeCallbacks, MidiSeqKaraoke.IMidiSeqKaraokeEvents
{
	public enum UpdateEnum
	{
		Update = 0,
		LateUpdate = 1,
		FixedUpdate = 2,
		Thread = 3
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__110 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MidiSeqKaraokeScript _003C_003E4__this;

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
		public _003CStart_003Ed__110(int _003C_003E1__state)
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

	public static MidiSeqKaraokeScript singleton;

	public string id;

	private MidiSeqKaraoke _midi;

	[Header("MIDI")]
	[ReadOnlyWhenPlaying]
	public TextAsset midiFileTextAsset;

	[Header("MUSIC")]
	public bool music;

	private bool _music;

	[RestrictInterface(typeof(IAudioSource))]
	[ReadOnlyWhenPlaying]
	public UnityEngine.Object musicInterface;

	[ReadOnlyWhenPlaying]
	public AudioClip musicClip;

	[ReadOnlyWhenPlaying]
	public string musicClipId;

	[Range(0f, 1f)]
	public float musicVolume;

	private float _musicVolume;

	[Header("VOCALS")]
	public bool vocals;

	private bool _vocals;

	[RestrictInterface(typeof(IAudioSource))]
	[ReadOnlyWhenPlaying]
	public UnityEngine.Object vocalsInterface;

	[ReadOnlyWhenPlaying]
	public AudioClip vocalsClip;

	[ReadOnlyWhenPlaying]
	public string vocalsClipId;

	[Range(0f, 1f)]
	public float vocalsVolume;

	private float _vocalsVolume;

	[Header("UDPATE")]
	public MidiSeqKaraoke.SynchronizationContext synchronizationContext;

	private MidiSeqKaraoke.SynchronizationContext _synchronizationContext;

	public UpdateEnum update;

	private UpdateEnum _update;

	[Header("MIDI OUTPUT")]
	public bool midiOut;

	private bool _midiOut;

	public bool midiThrough;

	private bool _midiThrough;

	[Header("CONTROL")]
	public bool playOnStart;

	public float delay;

	public float playingDelay;

	private float _playingDelay;

	public bool pickUpBar;

	private bool _pickUpBar;

	public bool pickUpBarOnRepeat;

	private bool _pickUpBarOnRepeat;

	[Range(0.1f, 10f)]
	public float speed;

	private float _speed;

	[Range(-12f, 12f)]
	public int semitone;

	private int _semitone;

	[Header("TIME")]
	public bool metronome;

	private bool _metronome;

	public float eventsOffset;

	private float _eventsOffset;

	public double markerTimeThreshold;

	private double _markerTimeThreshold;

	[Header("BARS")]
	public bool repeatBarSelection;

	private bool _repeatBarSelection;

	public int startBar;

	private int _startBar;

	public int endBar;

	private int _endBar;

	[Header("OTHERS")]
	public bool forceTrackAsChannel;

	private bool _forceTrackAsChannel;

	public int PPQN;

	private int _PPQN;

	private IAudioSource _musicInterface;

	private IAudioSource _vocalsInterface;

	public int lyricTrack;

	private int _lyricTrack;

	public float wordTimeOffset;

	private float _wordTimeOffset;

	public float wordTimeFinishedOffset;

	private float _wordTimeFinishedOffset;

	[Tooltip("Will force each sentence ending to be really a sentence. Sometimes there is no [NS] tag in midi file.")]
	public bool forceSentences;

	private bool _forceSentences;

	public bool forceSentenceNewLine;

	private bool _forceSentenceNewLine;

	public bool forceCommaNewLine;

	private bool _forceCommaNewLine;

	public float sentenceTimeOffset;

	private float _sentenceTimeOffset;

	public float versetTimeOffset;

	private float _versetTimeOffset;

	public string Id => null;

	public MidiSeqKaraoke Midi
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public MidiSeqStates State => default(MidiSeqStates);

	public double ticks => 0.0;

	public double time => 0.0;

	public string timeString => null;

	public double duration => 0.0;

	public string durationString => null;

	public int beat => 0;

	public int beatCount => 0;

	public int bar => 0;

	public int barCount => 0;

	public int timeSignatureNumerator => 0;

	public int timeSignatureDenominator => 0;

	public int PPQNMinValue => 0;

	public float tempo => 0f;

	public float tempoTicks => 0f;

	public int keyMajorMinor => 0;

	public int keySharpsFlats => 0;

	public List<MidiSeqKaraoke.Bar> bars => null;

	private bool initialized => false;

	public List<IList<MidiEvent>> tracks => null;

	public int[] eventPos => null;

	public bool[] endOfTrack => null;

	public bool[] muteTrack => null;

	public int wordPos => 0;

	public int wordOffsetPos => 0;

	public List<MidiSeqKaraoke.WordText> words => null;

	public int sentencePos => 0;

	public List<MidiSeqKaraoke.SentenceText> sentences => null;

	public int versePos => 0;

	public List<MidiSeqKaraoke.MidiText> verses => null;

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

	public event Action<MidiSeqKaraoke.WordText> OnWord
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

	public event Action<MidiSeqKaraoke.WordText> OnWordOffset
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

	public event Action<MidiSeqKaraoke.SentenceText> OnSentence
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

	public event Action<MidiSeqKaraoke.MidiText> OnVerse
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

	private void Awake()
	{
	}

	private void Init()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__110))]
	private IEnumerator Start()
	{
		return null;
	}

	private void OnDestroy()
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

	public void Pause()
	{
	}

	public void SetVocals(bool vocals)
	{
	}

	public void SetMusic(bool music)
	{
	}

	public void Stop()
	{
	}

	public void SetSpeed(float speed)
	{
	}

	public void SetSemitone(int semitone)
	{
	}

	public void Initialize(byte[] midiBytes, AudioClip vClip, AudioClip mClip)
	{
	}

	public void Initialize(byte[] midiBytes, string vClipId, string mClipId)
	{
	}

	public void Initialize(byte[] midiBytes)
	{
	}

	public double TicksToTime(double t)
	{
		return 0.0;
	}

	public double TimeToTicks(double t)
	{
		return 0.0;
	}

	private void ShortMessageEventHandler(int aCommand, int aData1, int aData2, int deviceId)
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnInitializedCallback()
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnWordCallback(MidiSeqKaraoke.WordText w)
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnWordFinishedCallback()
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnWordOffsetCallback(MidiSeqKaraoke.WordText w)
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnWordOffsetFinishedCallback()
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnSentenceCallback(MidiSeqKaraoke.SentenceText s)
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnVerseCallback(MidiSeqKaraoke.MidiText t)
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnFinishedCallback()
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnPlayCallback()
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnContinueCallback()
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnStopCallback()
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnPauseCallback()
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnRepeatCallback(int r)
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnPickUpBarCallback(int p)
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnPickupBarBeginCallback(int p)
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnPickupBarEndCallback()
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnMidiLoadedCallback()
	{
	}

	void MidiSeqKaraoke.IMidiSeqKaraokeCallbacks.OnTempoChangeCallback(float t)
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void FixedUpdate()
	{
	}
}
