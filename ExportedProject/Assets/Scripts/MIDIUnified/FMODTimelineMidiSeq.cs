using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FMODTimelineMidiSeq : MonoBehaviour, IMidiSeqControl, MidiSeqKaraoke.IMidiSeqKaraokeCallbacks, MidiSeqKaraoke.IMidiSeqKaraokeEvents
{
	[Serializable]
	public class MidiTimelineItem
	{
		public string marker;

		public double startTime;

		public string triggerParameter;

		public TextAsset midiFile;

		public FMODMidiSeq midiSeq;

		[Range(-0.2f, 0.2f)]
		public double timeOffset;

		public string StartTimeString => null;
	}

	public TextAsset timelineJson;

	[Range(-0.2f, 0.2f)]
	public double timeOffset;

	private int _timeMS;

	[NonSerialized]
	public FMODTimelineMarkers markers;

	public MidiTimelineItem[] items;

	public double Time => 0.0;

	public string TimeString => null;

	public MidiSeqStates State { get; private set; }

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

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void InitMidiSequencers()
	{
	}

	public void Play()
	{
	}

	public void Continue()
	{
	}

	public void Pause()
	{
	}

	public void Stop()
	{
	}

	public void OnInitializedCallback()
	{
	}

	public void OnWordCallback(MidiSeqKaraoke.WordText w)
	{
	}

	public void OnWordFinishedCallback()
	{
	}

	public void OnWordOffsetCallback(MidiSeqKaraoke.WordText w)
	{
	}

	public void OnWordOffsetFinishedCallback()
	{
	}

	public void OnSentenceCallback(MidiSeqKaraoke.SentenceText s)
	{
	}

	public void OnVerseCallback(MidiSeqKaraoke.MidiText t)
	{
	}

	public void OnFinishedCallback()
	{
	}

	public void OnPlayCallback()
	{
	}

	public void OnContinueCallback()
	{
	}

	public void OnStopCallback()
	{
	}

	public void OnPauseCallback()
	{
	}

	public void OnRepeatCallback(int r)
	{
	}

	public void OnPickUpBarCallback(int p)
	{
	}

	public void OnPickupBarBeginCallback(int p)
	{
	}

	public void OnPickupBarEndCallback()
	{
	}

	public void OnMidiLoadedCallback()
	{
	}

	public void OnTempoChangeCallback(float t)
	{
	}
}
