using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace MidiPlayerTK
{
	public class MidiSynth : MonoBehaviour
	{
		public class SynthCommand
		{
			public enum enCmd
			{
				StartEvent = 0,
				StopEvent = 1,
				ClearAllVoices = 2,
				NoteOffAll = 3
			}

			public enCmd Command;

			public int IdSession;

			public MPTKEvent MidiEvent;
		}

		public delegate void OnAudioFrameStartHandler(double synthTime);

		public enum ModeSpatializer
		{
			Channel = 0,
			Track = 1
		}

		[CompilerGenerated]
		private sealed class _003CThreadLeanStartAudio_003Ed__187 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public AudioSource audioSource;

			public MidiSynth _003C_003E4__this;

			private float _003Cincrement_003E5__2;

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
			public _003CThreadLeanStartAudio_003Ed__187(int _003C_003E1__state)
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
		private sealed class _003CThreadClearAllSound_003Ed__194 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public MidiSynth _003C_003E4__this;

			public int _idSession;

			public bool destroyAudioSource;

			private int _003Ci_003E5__2;

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
			public _003CThreadClearAllSound_003Ed__194(int _003C_003E1__state)
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
		private sealed class _003CMPTK_WaitAllNotesOff_003Ed__195 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MidiSynth _003C_003E4__this;

			public int _idSession;

			private int _003Ccount_003E5__2;

			private DateTime _003Cstart_003E5__3;

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
			public _003CMPTK_WaitAllNotesOff_003Ed__195(int _003C_003E1__state)
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
		private sealed class _003CThreadWaitAllStop_003Ed__196 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public MidiSynth _003C_003E4__this;

			public int _idSession;

			private int _003Ccount_003E5__2;

			private DateTime _003Cstart_003E5__3;

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
			public _003CThreadWaitAllStop_003Ed__196(int _003C_003E1__state)
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
		private sealed class _003CThreadDestroyAllVoice_003Ed__197 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public MidiSynth _003C_003E4__this;

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
			public _003CThreadDestroyAllVoice_003Ed__197(int _003C_003E1__state)
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

		[NonSerialized]
		[HideInInspector]
		public AudioSource CoreAudioSource;

		[NonSerialized]
		[HideInInspector]
		public AudioReverbFilter ReverbFilter;

		[NonSerialized]
		[HideInInspector]
		public AudioChorusFilter ChorusFilter;

		protected double timeMidiFromStartPlay;

		[Range(1f, 30f)]
		[HideInInspector]
		public int waitThreadMidi;

		[HideInInspector]
		[Range(1f, 100f)]
		public int DevicePerformance;

		protected double lastTimeMidi;

		public Stopwatch watchPerfMidi;

		[HideInInspector]
		[Range(0f, 100f)]
		public float MaxDspLoad;

		private static int lastIdSynth;

		[NonSerialized]
		public int IdSynth;

		[NonSerialized]
		public int IdSession;

		[NonSerialized]
		[HideInInspector]
		public int FLUID_BUFSIZE;

		[NonSerialized]
		[HideInInspector]
		public int FLUID_MAX_BUFSIZE;

		public int AudioBufferLenght;

		public int AudioNumBuffers;

		public string AudioEngine;

		[NonSerialized]
		[HideInInspector]
		public float OutputRate;

		[NonSerialized]
		[HideInInspector]
		public int DspBufferSize;

		[Tooltip("Extended channel information as volume, forced instrument, can be resetted when a MIDI is starting playing")]
		public bool MPTK_ResetChannel;

		public bool playOnlyFirstWave;

		public bool playNoteOff;

		[HideInInspector]
		public bool MPTK_EnablePresetDrum;

		[HideInInspector]
		public bool MPTK_ReleaseSameNote;

		[HideInInspector]
		public bool MPTK_KillByExclusiveClass;

		[Range(0.1f, 10f)]
		[Tooltip("Modify the default value of the release time")]
		public float MPTK_ReleaseTimeMod;

		[Range(0.0001f, 0.5f)]
		[Tooltip("Sample is stopped when amplitude is below this value")]
		public float MPTK_CutOffVolume;

		[Range(0.001f, 1f)]
		[Tooltip("Lean startup of the volume of the synth is useful to avoid weird sound at the beginning of the application. Set to 1 for an immediate full volume at startup.")]
		public float MPTK_LeanSynthStarting;

		[Tooltip("Enable bufferring Voice to enhance performance.")]
		public bool MPTK_AutoBuffer;

		[Range(0f, 1000f)]
		[Tooltip("Auto Clean Voice Greater Than")]
		public int MPTK_AutoCleanVoiceLimit;

		[Range(1000f, 100000f)]
		[Tooltip("Auto Clean Voice Older Than (millisecond)")]
		public float MPTK_AutoCleanVoiceTime;

		[HideInInspector]
		public bool MPTK_ApplyRealTimeModulator;

		[HideInInspector]
		public bool MPTK_ApplyModLfo;

		[HideInInspector]
		public bool MPTK_ApplyVibLfo;

		[Header("DSP Statistics")]
		public float StatDspLoadPCT;

		public float StatDspLoadMIN;

		public float StatDspLoadMAX;

		public float StatDspLoadAVG;

		public int StatDspBufferSize;

		public int StatDspChannelCount;

		public MovingAverage StatDspLoadMA;

		[Header("MIDI Sequencer Statistics")]
		public double StatDeltaThreadMidiMS;

		public double StatDeltaThreadMidiMAX;

		public double StatDeltaThreadMidiMIN;

		public float StatDeltaThreadMidiAVG;

		public MovingAverage StatDeltaThreadMidiMA;

		public float StatReadMidiMS;

		public float StatEnqueueMidiMS;

		public float StatProcessMidiMS;

		public float StatProcessMidiMAX;

		[Header("MIDI Synth Statistics")]
		public double StatDeltaAudioFilterReadMS;

		public float StatAudioFilterReadMS;

		public double StatAudioFilterReadMAX;

		public double StatAudioFilterReadMIN;

		public float StatAudioFilterReadAVG;

		public MovingAverage StatAudioFilterReadMA;

		public float StatSampleWriteMS;

		public float StatSampleWriteAVG;

		public MovingAverage StatSampleWriteMA;

		public float StatProcessListMS;

		public float StatProcessListAVG;

		public MovingAverage StatProcessListMA;

		protected double lastTimePlayCore;

		private Stopwatch watchOnAudioFilterRead;

		protected Stopwatch watchMidi;

		protected Stopwatch pauseMidi;

		private Thread midiThread;

		private bool needClearingFreeVoices;

		[SerializeField]
		[HideInInspector]
		public bool keepPlayingNonLooped;

		[HideInInspector]
		public bool MPTK_CorePlayer;

		[HideInInspector]
		public bool MPTK_AudioSettingFromUnity;

		[HideInInspector]
		public bool MPTK_EnableFreeSynthRate;

		[HideInInspector]
		[SerializeField]
		private int indexSynthRate;

		private int[] tabDspBufferSize;

		[HideInInspector]
		[SerializeField]
		private int indexBuffSize;

		[HideInInspector]
		public bool MPTK_DirectSendToPlayer;

		[HideInInspector]
		public bool MPTK_EnableChangeTempo;

		[SerializeField]
		[HideInInspector]
		private float maxDistance;

		public static List<MidiFilePlayer> SpatialSynths;

		private int spatialSynthIndex;

		[HideInInspector]
		public bool MPTK_EnablePanChange;

		[HideInInspector]
		[SerializeField]
		private float volumeGlobal;

		[HideInInspector]
		protected float volumeStartStop;

		[HideInInspector]
		public bool MPTK_LogEvents;

		[HideInInspector]
		public bool MPTK_LogWave;

		[Header("Voice Statistics")]
		public int MPTK_StatVoiceCountPlaying;

		public int MPTK_StatVoiceCountActive;

		public int MPTK_StatVoiceCountFree;

		public float MPTK_StatVoiceRatioReused;

		public int MPTK_StatVoicePlayed;

		public MidiLoad midiLoaded;

		protected bool sequencerPause;

		protected double SynthElapsedMilli;

		protected float timeToPauseMilliSeconde;

		[SerializeField]
		[HideInInspector]
		protected bool playPause;

		[HideInInspector]
		public float distanceToListener;

		[HideInInspector]
		[SerializeField]
		public int transpose;

		[SerializeField]
		[HideInInspector]
		public int transExcludedChannel;

		public mptk_channel[] MptkChannels;

		public fluid_channel[] Channels;

		private List<fluid_voice> ActiveVoices;

		private List<fluid_voice> FreeVoices;

		protected Queue<SynthCommand> QueueSynthCommand;

		protected Queue<List<MPTKEvent>> QueueMidiEvents;

		[HideInInspector]
		public fluid_interp InterpolationMethod;

		[HideInInspector]
		public float gain;

		[Header("Enable Debug Log")]
		public bool VerboseSynth;

		public bool VerboseOverload;

		public bool VerboseVoice;

		public bool VerboseKillByExclusive;

		public bool VerboseGenerator;

		public bool VerboseCalcGen;

		public bool VerboseController;

		public bool VerboseEnvVolume;

		public bool VerboseEnvModulation;

		public bool VerboseFilter;

		public bool VerboseVolume;

		public fluid_synth_status state;

		[Header("Attributes below applies only with AudioSource mode (Core Audio unchecked)")]
		public VoiceAudioSource AudiosourceTemplate;

		[Tooltip("Apply only with AudioSource mode (no Core Audio)")]
		public bool AdsrSimplified;

		[Tooltip("Apply only with AudioSource mode (no Core Audio)")]
		public bool MPTK_WeakDevice;

		[Range(0f, 5000000f)]
		[Tooltip("Apply only with AudioSource mode (no Core Audio)")]
		public uint MPTK_ReleaseTimeMin;

		[Range(0f, 100f)]
		[Tooltip("Smooth Volume Change")]
		public int DampVolume;

		[HideInInspector]
		public EventSynthClass OnEventSynthAwake;

		[HideInInspector]
		public EventSynthClass OnEventSynthStarted;

		private float[] left_buf;

		private float[] right_buf;

		private static HiMod default_vel2att_mod;

		private static HiMod default_vel2filter_mod;

		private static HiMod default_at2viblfo_mod;

		private static HiMod default_mod2viblfo_mod;

		private static HiMod default_att_mod;

		private static HiMod default_pan_mod;

		private static HiMod default_expr_mod;

		private static HiMod default_reverb_mod;

		private static HiMod default_chorus_mod;

		private static HiMod default_pitch_bend_mod;

		private int countvoiceReused;

		[HideInInspector]
		public bool showMidiInfo;

		[HideInInspector]
		public bool showSynthParameter;

		[HideInInspector]
		public bool showSpatialization;

		[HideInInspector]
		public bool showUnitySynthParameter;

		[HideInInspector]
		public bool showUnityPerformanceParameter;

		[HideInInspector]
		public bool showSoundFontEffect;

		[HideInInspector]
		public bool showUnitySynthEffect;

		[HideInInspector]
		public bool showMidiParameter;

		[HideInInspector]
		public bool showSynthEvents;

		[HideInInspector]
		public bool showEvents;

		[HideInInspector]
		public bool showDefault;

		[HideInInspector]
		public bool spatialize;

		public int[] histoDspSize;

		private int histoCurrent;

		public Action<MPTKEvent> OnMidiEvent;

		[Range(-2000f, 3000f)]
		[HideInInspector]
		public float MPTK_SFFilterFreqOffset;

		[HideInInspector]
		[SerializeField]
		private float filterQModOffset;

		[HideInInspector]
		[SerializeField]
		private bool applySFReverb;

		[HideInInspector]
		[SerializeField]
		private bool applySFChorus;

		[HideInInspector]
		[SerializeField]
		private bool applySFFilter;

		[HideInInspector]
		[Range(-1f, 1f)]
		public float MPTK_SFReverbAmplify;

		[HideInInspector]
		[Range(-1f, 1f)]
		public float MPTK_SFChorusAmplify;

		private fluid_revmodel reverb;

		private float[] fx_reverb;

		private fluid_chorus chorus;

		private float[] fx_chorus;

		[HideInInspector]
		[SerializeField]
		private float sfReverbRoomSize;

		[SerializeField]
		[HideInInspector]
		private float sfReverbDamp;

		[SerializeField]
		[HideInInspector]
		private float sfReverbWidth;

		[SerializeField]
		[HideInInspector]
		private float sfReverbLevel;

		private const int FLUID_CHORUS_DEFAULT_N = 3;

		[SerializeField]
		[HideInInspector]
		private float sfChorusLevel;

		[SerializeField]
		[HideInInspector]
		private float sfChorusSpeed;

		[SerializeField]
		[HideInInspector]
		private float sfChorusDepth;

		[HideInInspector]
		[SerializeField]
		private float sfChorusWidth;

		private const fluid_chorus.fluid_chorus_mod FLUID_CHORUS_DEFAULT_TYPE = fluid_chorus.fluid_chorus_mod.FLUID_CHORUS_MOD_SINE;

		[HideInInspector]
		[SerializeField]
		private bool applyReverb;

		[HideInInspector]
		[SerializeField]
		private float reverbRoom;

		[SerializeField]
		[HideInInspector]
		private float reverbRoomHF;

		[SerializeField]
		[HideInInspector]
		private float reverbRoomLF;

		[HideInInspector]
		[SerializeField]
		private float reverbReflectionLevel;

		[HideInInspector]
		[SerializeField]
		private float reverbReflectionDelay;

		[HideInInspector]
		[SerializeField]
		private float reverbDryLevel;

		[HideInInspector]
		[SerializeField]
		private float reverbDecayTime;

		[HideInInspector]
		[SerializeField]
		private float reverbDecayHFRatio;

		[HideInInspector]
		[SerializeField]
		private float reverbLevel;

		[SerializeField]
		[HideInInspector]
		private float reverbDelay;

		[SerializeField]
		[HideInInspector]
		private float reverbHfReference;

		[SerializeField]
		[HideInInspector]
		private float reverbLfReference;

		[HideInInspector]
		[SerializeField]
		private float reverbDiffusion;

		[HideInInspector]
		[SerializeField]
		private float reverbDensity;

		[SerializeField]
		[HideInInspector]
		private bool applyChorus;

		[HideInInspector]
		[SerializeField]
		private float chorusDryMix;

		[SerializeField]
		[HideInInspector]
		private float chorusWetMix1;

		[SerializeField]
		[HideInInspector]
		private float chorusWetMix2;

		[SerializeField]
		[HideInInspector]
		private float chorusWetMix3;

		[HideInInspector]
		[SerializeField]
		private float chorusDelay;

		[HideInInspector]
		[SerializeField]
		private float chorusRate;

		[HideInInspector]
		[SerializeField]
		private float chorusDepth;

		protected bool isSpatialSynthMaster;

		[HideInInspector]
		public ModeSpatializer MPTK_ModeSpatializer;

		[HideInInspector]
		public int MPTK_MaxSpatialSynth;

		[HideInInspector]
		public bool MPTK_SpatialSynthEnabled;

		protected string instrumentPlayed;

		protected string trackName;

		public bool MPTK_KeepPlayingNonLooped
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int MPTK_SynthRate
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int MPTK_IndexSynthRate
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int MPTK_IndexSynthBuffSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_MaxDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public bool MPTK_PauseOnDistance
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
		public bool MPTK_Spatialize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int MPTK_SpatialSynthIndex => 0;

		[HideInInspector]
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

		[HideInInspector]
		public int MPTK_Transpose
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[HideInInspector]
		public int MPTK_TransExcludedChannel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_SFFilterQModOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_SFReverbRoomSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_SFReverbDamp
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_SFReverbWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_SFReverbLevel
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_SFChorusLevel
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_SFChorusSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_SFChorusDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_SFChorusWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public bool MPTK_ApplyUnityReverb
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
		public float MPTK_ReverbDryLevel
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ReverbRoom
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ReverbRoomHF
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ReverbRoomLF
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ReverbDecayTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ReverbDecayHFRatio
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ReverbReflectionLevel
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ReverbReflectionDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ReverbLevel
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ReverbDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ReverbHFReference
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ReverbLFReference
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ReverbDiffusion
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ReverbDensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public bool MPTK_ApplyUnityChorus
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
		public float MPTK_ChorusDryMix
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ChorusWetMix1
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ChorusWetMix2
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ChorusWetMix3
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ChorusDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ChorusRate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[HideInInspector]
		public float MPTK_ChorusDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool MPTK_IsSpatialSynthMaster => false;

		public string MPTK_InstrumentPlayed => null;

		public string MPTK_TrackName => null;

		public bool MPTK_ApplySFFilter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool MPTK_ApplySFReverb
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool MPTK_ApplySFChorus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event OnAudioFrameStartHandler OnAudioFrameStart
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

		private static void ResetAudio(AudioConfiguration ac)
		{
		}

		protected void SetSpatialization()
		{
		}

		public void Awake()
		{
		}

		public void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CThreadLeanStartAudio_003Ed__187))]
		public IEnumerator<float> ThreadLeanStartAudio(AudioSource audioSource)
		{
			return null;
		}

		private void OnAudioConfigurationChanged(bool deviceWasChanged)
		{
		}

		private void GetInfoAudio()
		{
		}

		public void MPTK_InitSynth(int channelCount = 16, bool resetActiveVoices = false)
		{
		}

		public void MPTK_StartSequencerMidi()
		{
		}

		public void MPTK_StopSynth()
		{
		}

		public void MPTK_ClearAllSound(bool destroyAudioSource = false, int _idSession = -1)
		{
		}

		[IteratorStateMachine(typeof(_003CThreadClearAllSound_003Ed__194))]
		public IEnumerator<float> ThreadClearAllSound(bool destroyAudioSource = false, int _idSession = -1)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CMPTK_WaitAllNotesOff_003Ed__195))]
		public IEnumerator MPTK_WaitAllNotesOff(int _idSession = -1)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CThreadWaitAllStop_003Ed__196))]
		public IEnumerator<float> ThreadWaitAllStop(int _idSession = -1)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CThreadDestroyAllVoice_003Ed__197))]
		protected IEnumerator<float> ThreadDestroyAllVoice()
		{
			return null;
		}

		private void OnApplicationQuit()
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		protected void ResetMidi()
		{
		}

		protected void ResetMPTKChannels()
		{
		}

		public void MPTK_ResetStat()
		{
		}

		private void fluid_mod_set_source1(HiMod mod, int src, int flags)
		{
		}

		private void fluid_mod_set_source2(HiMod mod, int src, int flags)
		{
		}

		private void fluid_mod_set_dest(HiMod mod, int dest)
		{
		}

		private void fluid_mod_set_amount(HiMod mod, float amount)
		{
		}

		public string MPTK_ChannelInfo(int channel)
		{
			return null;
		}

		public void MPTK_ChannelEnableSet(int channel, bool enable)
		{
		}

		public bool MPTK_ChannelEnableGet(int channel)
		{
			return false;
		}

		public int MPTK_ChannelNoteCount(int channel)
		{
			return 0;
		}

		public void MPTK_ChannelVolumeSet(int channel, float volume)
		{
		}

		public float MPTK_ChannelVolumeGet(int channel)
		{
			return 0f;
		}

		public int MPTK_ChannelPresetGetIndex(int channel)
		{
			return 0;
		}

		public int MPTK_ChannelBankGetIndex(int channel)
		{
			return 0;
		}

		public string MPTK_ChannelPresetGetName(int channel)
		{
			return null;
		}

		public int MPTK_ChannelControllerGet(int channel, int controller)
		{
			return 0;
		}

		public int MPTK_ChannelCount()
		{
			return 0;
		}

		private bool CheckParamChannel(int channel)
		{
			return false;
		}

		public int MPTK_ChannelForcedPresetGet(int channel)
		{
			return 0;
		}

		public bool MPTK_ChannelForcedPresetSet(int channel, int preset, int bank = -1)
		{
			return false;
		}

		public bool MPTK_ChannelPresetChange(int channel, int preset, int bank = -1)
		{
			return false;
		}

		public fluid_voice fluid_synth_alloc_voice(HiSample hiSample, int chan, int _idSession, int key, int vel)
		{
			return null;
		}

		public void fluid_synth_kill_by_exclusive_class(fluid_voice new_voice)
		{
		}

		public HiPreset fluid_synth_find_preset(int banknum, int prognum)
		{
			return null;
		}

		private HiPreset CheckBankAndPresetExist(int banknum, int prognum, ImSoundFont sfont)
		{
			return null;
		}

		public void synth_noteon(MPTKEvent note)
		{
		}

		private void fluid_synth_release_voice_on_same_note(int chan, int key)
		{
		}

		public void fluid_synth_noteoff(int pchan, int pkey)
		{
		}

		public void fluid_synth_soundoff(int pchan)
		{
		}

		public void fluid_synth_damp_voices(int pchan)
		{
		}

		public void fluid_synth_cc(int chan, MPTKController num, int val)
		{
		}

		public void fluid_synth_modulate_voices(int chan, int is_cc, int ctrl)
		{
		}

		public void fluid_synth_modulate_voices_all(int chan)
		{
		}

		public void fluid_synth_program_change(int pchan, int preset)
		{
		}

		private void fluid_synth_pitch_bend(int chan, int val)
		{
		}

		protected void PlayEvents(List<MPTKEvent> midievents, bool playNoteOff = true)
		{
		}

		protected void StopEvent(MPTKEvent midievent)
		{
		}

		public void MPTK_StopDirectEvent(MPTKEvent midievent)
		{
		}

		public void MPTK_PlayDirectEvent(MPTKEvent midiEvent, bool playNoteOff = true)
		{
		}

		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		private void WriteAllSamples(long ticks, float[] reverb_buf, float[] chorus_buf)
		{
		}

		private void ProcessQueueCommand()
		{
		}

		public void MoveVoiceToFree(fluid_voice v)
		{
		}

		public void DebugVoice()
		{
		}

		private void MoveVoiceToFree()
		{
		}

		private void AutoCleanVoice(long ticks)
		{
		}

		private void ThreadMidiPlayer()
		{
		}

		private void PlayMidi()
		{
		}

		public void MPTK_SFFilterSetDefault()
		{
		}

		[HideInInspector]
		public void MPTK_SFReverbSetDefault()
		{
		}

		public void MPTK_SFChorusSetDefault()
		{
		}

		public void MPTK_ReverbSetDefault()
		{
		}

		public void MPTK_ChorusSetDefault()
		{
		}

		private void InitEffect()
		{
		}

		private void SetParamSfReverb()
		{
		}

		public void SetParamSfChorus()
		{
		}

		private void PrepareBufferEffect(out float[] reverb_buf, out float[] chorus_buf)
		{
			reverb_buf = null;
			chorus_buf = null;
		}

		private void ProcessEffect(float[] reverb_buf, float[] chorus_buf)
		{
		}

		private void PlaySpatialEvent(MPTKEvent midievent)
		{
		}

		protected void SpatialSendEvents(List<MPTKEvent> midievents)
		{
		}

		private void BuildSpatialSynth()
		{
		}

		private void OnDestroy()
		{
		}

		private void RemoveSpatialSynth()
		{
		}

		private void StartFrame()
		{
		}

		private void StartMidiEvent(MPTKEvent midi)
		{
		}
	}
}
