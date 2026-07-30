using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Serialization;

namespace RenderHeads.Media.AVProVideo
{
	[ExecuteInEditMode]
	[AddComponentMenu("AVPro Video/Media Player", -100)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class MediaPlayer : MonoBehaviour, ISerializationCallbackReceiver
	{
		public delegate void ProcessExtractedFrame(Texture2D extractedFrame);

		[Serializable]
		public class PlatformOptions
		{
			public HttpHeaderData httpHeaders;

			public KeyAuthData keyAuth;

			public virtual bool IsModified()
			{
				return false;
			}

			public virtual string GetKeyServerAuthToken()
			{
				return null;
			}

			public virtual byte[] GetOverrideDecryptionKey()
			{
				return null;
			}

			public virtual bool StartWithHighestBandwidth()
			{
				return false;
			}
		}

		[Serializable]
		public class OptionsWindows : PlatformOptions, ISerializationCallbackReceiver
		{
			public Windows.VideoApi videoApi;

			public bool useHardwareDecoding;

			public bool useTextureMips;

			public bool use10BitTextures;

			public bool hintAlphaChannel;

			public bool useLowLatency;

			public bool useCustomMovParser;

			public bool useHapNotchLC;

			public bool useStereoDetection;

			public bool useTextTrackSupport;

			public bool useFacebookAudio360Support;

			public bool useAudioDelay;

			public BufferedFrameSelectionMode bufferedFrameSelection;

			public bool pauseOnPrerollComplete;

			public string forceAudioOutputDeviceName;

			public List<string> preferredFilters;

			public Windows.AudioOutput audioOutput;

			public Audio360ChannelMode audio360ChannelMode;

			public bool startWithHighestBitrate;

			public bool useLowLiveLatency;

			[Range(1f, 16f)]
			public int parallelFrameCount;

			[Range(1f, 16f)]
			public int prerollFrameCount;

			[HideInInspector]
			[SerializeField]
			private bool useUnityAudio;

			[SerializeField]
			[HideInInspector]
			private bool enableAudio360;

			public override bool IsModified()
			{
				return false;
			}

			public override bool StartWithHighestBandwidth()
			{
				return false;
			}

			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}
		}

		[Serializable]
		public class OptionsWindowsUWP : PlatformOptions
		{
			public bool useHardwareDecoding;

			public bool useTextureMips;

			public bool use10BitTextures;

			public bool hintOutput10Bit;

			public bool useLowLatency;

			public WindowsUWP.VideoApi videoApi;

			public WindowsUWP.AudioOutput audioOutput;

			public Audio360ChannelMode audio360ChannelMode;

			public bool startWithHighestBitrate;

			public bool useLowLiveLatency;

			public override bool IsModified()
			{
				return false;
			}

			public override bool StartWithHighestBandwidth()
			{
				return false;
			}
		}

		[Serializable]
		public class OptionsApple : PlatformOptions
		{
			public enum TextureFormat
			{
				BGRA = 0,
				YCbCr420 = 1
			}

			public enum AudioMode
			{
				SystemDirect = 0,
				Unity = 1,
				SystemDirectWithCapture = 2
			}

			[Flags]
			public enum Flags
			{
				None = 0,
				GenerateMipMaps = 1,
				AllowExternalPlayback = 0x100,
				PlayWithoutBuffering = 0x200,
				UseSinglePlayerItem = 0x400,
				ResumeMediaPlaybackAfterAudioSessionRouteChange = 0x10000
			}

			public enum Resolution
			{
				NoPreference = 0,
				_480p = 1,
				_720p = 2,
				_1080p = 3,
				_1440p = 4,
				_2160p = 5,
				Custom = 6
			}

			public enum BitRateUnits
			{
				bps = 0,
				Kbps = 1,
				Mbps = 2
			}

			[Flags]
			public enum ChangeFlags
			{
				None = 0,
				PreferredPeakBitRate = 2,
				PreferredForwardBufferDuration = 4,
				PlayWithoutBuffering = 8,
				PreferredMaximumResolution = 0x10,
				AudioMode = 0x20,
				ResumeMediaPlaybackAfterAudioSessionRouteChange = 0x40,
				All = -1
			}

			private readonly TextureFormat DefaultTextureFormat;

			private readonly Flags DefaultFlags;

			public TextureFormat textureFormat;

			private AudioMode _previousAudioMode;

			[SerializeField]
			private AudioMode _audioMode;

			[SerializeField]
			private Flags _flags;

			public float maximumPlaybackRate;

			private ChangeFlags _changed;

			[SerializeField]
			private float _preferredPeakBitRate;

			[SerializeField]
			private BitRateUnits _preferredPeakBitRateUnits;

			[SerializeField]
			private double _preferredForwardBufferDuration;

			[SerializeField]
			private Resolution _preferredMaximumResolution;

			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			public AudioMode previousAudioMode => default(AudioMode);

			public AudioMode audioMode
			{
				get
				{
					return default(AudioMode);
				}
				set
				{
				}
			}

			public Flags flags
			{
				get
				{
					return default(Flags);
				}
				set
				{
				}
			}

			public float preferredPeakBitRate
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public BitRateUnits preferredPeakBitRateUnits
			{
				get
				{
					return default(BitRateUnits);
				}
				set
				{
				}
			}

			public double preferredForwardBufferDuration
			{
				get
				{
					return 0.0;
				}
				set
				{
				}
			}

			public Resolution preferredMaximumResolution
			{
				get
				{
					return default(Resolution);
				}
				set
				{
				}
			}

			public Vector2Int customPreferredMaximumResolution
			{
				get
				{
					return default(Vector2Int);
				}
				set
				{
				}
			}

			private static double BitRateInBitsPerSecond(float value, BitRateUnits units)
			{
				return 0.0;
			}

			public double GetPreferredPeakBitRateInBitsPerSecond()
			{
				return 0.0;
			}

			public OptionsApple(TextureFormat defaultTextureFormat, Flags defaultFlags)
			{
			}

			public override bool IsModified()
			{
				return false;
			}

			public bool HasChanged(ChangeFlags flags = ChangeFlags.All)
			{
				return false;
			}

			public void ClearChanges()
			{
			}
		}

		[Serializable]
		public class OptionsAndroid : PlatformOptions, ISerializationCallbackReceiver
		{
			public enum Resolution
			{
				NoPreference = 0,
				_480p = 1,
				_720p = 2,
				_1080p = 3,
				_2160p = 4,
				Custom = 5
			}

			public enum BitRateUnits
			{
				bps = 0,
				Kbps = 1,
				Mbps = 2
			}

			[Flags]
			public enum ChangeFlags
			{
				None = 0,
				PreferredPeakBitRate = 2,
				PreferredMaximumResolution = 4,
				PreferredCustomResolution = 8,
				All = -1
			}

			private ChangeFlags _changed;

			[SerializeField]
			private Resolution _preferredMaximumResolution;

			[SerializeField]
			private Vector2Int _customPreferredMaximumResolution;

			[SerializeField]
			private float _preferredPeakBitRate;

			[SerializeField]
			private BitRateUnits _preferredPeakBitRateUnits;

			public Android.VideoApi videoApi;

			public bool useFastOesPath;

			public bool showPosterFrame;

			public Android.AudioOutput audioOutput;

			public Audio360ChannelMode audio360ChannelMode;

			public int audio360LatencyMS;

			public bool preferSoftwareDecoder;

			public bool forceRtpTCP;

			public bool forceEnableMediaCodecAsyncQueueing;

			public Android.TextureFiltering blitTextureFiltering;

			[Tooltip("Byte offset into the file where the media file is located.  This is useful when hiding or packing media files within another file.")]
			[SerializeField]
			public int fileOffset;

			public bool startWithHighestBitrate;

			public int minBufferMs;

			public int maxBufferMs;

			public int bufferForPlaybackMs;

			public int bufferForPlaybackAfterRebufferMs;

			[HideInInspector]
			[SerializeField]
			private bool enableAudio360;

			public Resolution preferredMaximumResolution
			{
				get
				{
					return default(Resolution);
				}
				set
				{
				}
			}

			public Vector2Int customPreferredMaximumResolution
			{
				get
				{
					return default(Vector2Int);
				}
				set
				{
				}
			}

			public float preferredPeakBitRate
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public BitRateUnits preferredPeakBitRateUnits
			{
				get
				{
					return default(BitRateUnits);
				}
				set
				{
				}
			}

			public override bool IsModified()
			{
				return false;
			}

			private static double BitRateInBitsPerSecond(float value, BitRateUnits units)
			{
				return 0.0;
			}

			public double GetPreferredPeakBitRateInBitsPerSecond()
			{
				return 0.0;
			}

			public override bool StartWithHighestBandwidth()
			{
				return false;
			}

			public bool HasChanged(ChangeFlags flags = ChangeFlags.All, bool bClearFlags = false)
			{
				return false;
			}

			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			void ISerializationCallbackReceiver.OnAfterDeserialize()
			{
			}
		}

		[Serializable]
		public class OptionsWebGL : PlatformOptions
		{
			public WebGL.ExternalLibrary externalLibrary;

			public bool useTextureMips;

			public override bool IsModified()
			{
				return false;
			}

			public override string GetKeyServerAuthToken()
			{
				return null;
			}

			public override byte[] GetOverrideDecryptionKey()
			{
				return null;
			}
		}

		private enum FileLocation
		{
			AbsolutePathOrURL = 0,
			RelativeToProjectFolder = 1,
			RelativeToStreamingAssetsFolder = 2,
			RelativeToDataFolder = 3,
			RelativeToPersistentDataFolder = 4
		}

		[CompilerGenerated]
		private sealed class _003CFinalRenderCapture_003Ed__210 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MediaPlayer _003C_003E4__this;

			private YieldInstruction _003Cwait_003E5__2;

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
			public _003CFinalRenderCapture_003Ed__210(int _003C_003E1__state)
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
		private sealed class _003CExtractFrameCoroutine_003Ed__251 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Texture2D target;

			public MediaPlayer _003C_003E4__this;

			public double timeSeconds;

			public int timeThresholdMs;

			public bool accurateSeek;

			public ProcessExtractedFrame callback;

			private Texture2D _003Cresult_003E5__2;

			private int _003CcurrFc_003E5__3;

			private int _003Citerations_003E5__4;

			private int _003CmaxIterations_003E5__5;

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
			public _003CExtractFrameCoroutine_003Ed__251(int _003C_003E1__state)
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
		private sealed class _003CLoadSubtitlesCoroutine_003Ed__291 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string url;

			public MediaPlayer _003C_003E4__this;

			public MediaPath mediaPath;

			private UnityWebRequest _003Cwww_003E5__2;

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
			public _003CLoadSubtitlesCoroutine_003Ed__291(int _003C_003E1__state)
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
		private MediaSource _mediaSource;

		[SerializeField]
		private MediaReference _mediaReference;

		[SerializeField]
		private MediaPath _mediaPath;

		[SerializeField]
		private MediaHints _fallbackMediaHints;

		[FormerlySerializedAs("m_AutoOpen")]
		[SerializeField]
		private bool _autoOpen;

		[SerializeField]
		[FormerlySerializedAs("m_AutoStart")]
		private bool _autoPlayOnStart;

		[FormerlySerializedAs("m_Loop")]
		[SerializeField]
		private bool _loop;

		[Range(0f, 1f)]
		[SerializeField]
		[FormerlySerializedAs("m_Volume")]
		private float _audioVolume;

		[SerializeField]
		[FormerlySerializedAs("m_Balance")]
		[Range(-1f, 1f)]
		private float _audioBalance;

		[SerializeField]
		[FormerlySerializedAs("m_Muted")]
		private bool _audioMuted;

		private AudioSource _audioSource;

		[SerializeField]
		[FormerlySerializedAs("m_PlaybackRate")]
		[Range(-4f, 4f)]
		private float _playbackRate;

		[SerializeField]
		[FormerlySerializedAs("m_Resample")]
		private bool _useResampler;

		[SerializeField]
		[FormerlySerializedAs("m_ResampleMode")]
		private Resampler.ResampleMode _resampleMode;

		[SerializeField]
		[Range(3f, 10f)]
		[FormerlySerializedAs("m_ResampleBufferSize")]
		private int _resampleBufferSize;

		private Resampler _resampler;

		[SerializeField]
		[FormerlySerializedAs("m_videoMapping")]
		private VideoMapping _videoMapping;

		[SerializeField]
		[FormerlySerializedAs("m_FilterMode")]
		private FilterMode _textureFilterMode;

		[FormerlySerializedAs("m_WrapMode")]
		[SerializeField]
		private TextureWrapMode _textureWrapMode;

		[FormerlySerializedAs("m_AnisoLevel")]
		[Range(0f, 16f)]
		[SerializeField]
		private int _textureAnisoLevel;

		[FormerlySerializedAs("m_LoadSubtitles")]
		[SerializeField]
		private bool _sideloadSubtitles;

		[SerializeField]
		private MediaPath _subtitlePath;

		[FormerlySerializedAs("m_AudioHeadTransform")]
		[SerializeField]
		private Transform _audioHeadTransform;

		[SerializeField]
		[FormerlySerializedAs("m_AudioFocusEnabled")]
		private bool _audioFocusEnabled;

		[FormerlySerializedAs("m_AudioFocusTransform")]
		[SerializeField]
		private Transform _audioFocusTransform;

		[SerializeField]
		[Range(40f, 120f)]
		[FormerlySerializedAs("m_AudioFocusWidthDegrees")]
		private float _audioFocusWidthDegrees;

		[SerializeField]
		[Range(-24f, 0f)]
		[FormerlySerializedAs("m_AudioFocusOffLevelDB")]
		private float _audioFocusOffLevelDB;

		[SerializeField]
		private HttpHeaderData _httpHeaders;

		[SerializeField]
		private KeyAuthData _keyAuth;

		[SerializeField]
		[FormerlySerializedAs("m_events")]
		private MediaPlayerEvent _events;

		[SerializeField]
		[FormerlySerializedAs("m_eventMask")]
		private int _eventMask;

		[SerializeField]
		private bool _pauseMediaOnAppPause;

		[SerializeField]
		private bool _playMediaOnAppUnpause;

		[FormerlySerializedAs("m_Persistent")]
		[SerializeField]
		private bool _persistent;

		[FormerlySerializedAs("m_forceFileFormat")]
		[SerializeField]
		private FileFormat _forceFileFormat;

		private BaseMediaPlayer _baseMediaPlayer;

		private IMediaControl _controlInterface;

		private ITextureProducer _textureInterface;

		private IMediaInfo _infoInterface;

		private IMediaPlayer _playerInterface;

		private IMediaSubtitles _subtitlesInterface;

		private IMediaCache _cacheInterface;

		private IBufferedDisplay _bufferedDisplayInterface;

		private IVideoTracks _videoTracksInterface;

		private IAudioTracks _audioTracksInterface;

		private ITextTracks _textTracksInterface;

		private IDisposable _disposeInterface;

		private bool _isMediaOpened;

		private bool _autoPlayOnStartTriggered;

		private bool _wasPlayingOnPause;

		private Coroutine _renderingCoroutine;

		private static bool s_GlobalStartup;

		private static bool s_TrialVersion;

		private MediaPath _queueSubtitlePath;

		private Coroutine _loadSubtitlesRoutine;

		private static Camera _dummyCamera;

		private bool _eventFired_MetaDataReady;

		private bool _eventFired_ReadyToPlay;

		private bool _eventFired_Started;

		private bool _eventFired_FirstFrameReady;

		private bool _eventFired_FinishedPlaying;

		private bool _eventState_PlaybackBuffering;

		private bool _eventState_PlaybackSeeking;

		private bool _eventState_PlaybackStalled;

		private int _eventState_PreviousWidth;

		private int _eventState_PreviousHeight;

		private int _previousSubtitleIndex;

		private bool _finishedFrameOpenCheck;

		private bool _eventState_Paused;

		[SerializeField]
		private OptionsWindows _optionsWindows;

		[SerializeField]
		private OptionsApple _optionsMacOSX;

		[SerializeField]
		private OptionsApple _optionsIOS;

		[SerializeField]
		private OptionsApple _optionsTVOS;

		[SerializeField]
		private OptionsAndroid _optionsAndroid;

		[SerializeField]
		private OptionsWindowsUWP _optionsWindowsUWP;

		[SerializeField]
		private OptionsWebGL _optionsWebGL;

		[SerializeField]
		[HideInInspector]
		private string m_VideoPath;

		[SerializeField]
		[HideInInspector]
		private FileLocation m_VideoLocation;

		public MediaSource MediaSource
		{
			get
			{
				return default(MediaSource);
			}
			internal set
			{
			}
		}

		public MediaReference MediaReference
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public MediaPath MediaPath
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public MediaHints FallbackMediaHints
		{
			get
			{
				return default(MediaHints);
			}
			set
			{
			}
		}

		public bool AutoOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AutoStart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual float AudioVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AudioBalance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual bool AudioMuted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AudioSource AudioSource
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public float PlaybackRate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool UseResampler
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Resampler.ResampleMode ResampleMode
		{
			get
			{
				return default(Resampler.ResampleMode);
			}
			set
			{
			}
		}

		public int ResampleBufferSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Resampler FrameResampler => null;

		public VideoMapping VideoLayoutMapping
		{
			get
			{
				return default(VideoMapping);
			}
			set
			{
			}
		}

		public FilterMode TextureFilterMode
		{
			get
			{
				return default(FilterMode);
			}
			set
			{
			}
		}

		public TextureWrapMode TextureWrapMode
		{
			get
			{
				return default(TextureWrapMode);
			}
			set
			{
			}
		}

		public int TextureAnisoLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool SideloadSubtitles
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MediaPath SubtitlePath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform AudioHeadTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool AudioFocusEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Transform AudioFocusTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float AudioFocusWidthDegrees
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AudioFocusOffLevelDB
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public HttpHeaderData HttpHeaders
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public KeyAuthData KeyAuth
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MediaPlayerEvent Events => null;

		public int EventMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool PauseMediaOnAppPause
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool PlayMediaOnAppUnpause
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Persistent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public FileFormat ForceFileFormat
		{
			get
			{
				return default(FileFormat);
			}
			set
			{
			}
		}

		public virtual IMediaInfo Info => null;

		public virtual IMediaControl Control => null;

		public virtual IMediaPlayer Player => null;

		public virtual ITextureProducer TextureProducer => null;

		public virtual IMediaSubtitles Subtitles => null;

		public virtual IVideoTracks VideoTracks => null;

		public virtual IAudioTracks AudioTracks => null;

		public virtual ITextTracks TextTracks => null;

		public virtual IMediaCache Cache => null;

		public virtual IBufferedDisplay BufferedDisplay => null;

		public bool MediaOpened => false;

		public OptionsWindows PlatformOptionsWindows => null;

		public OptionsApple PlatformOptionsMacOSX => null;

		public OptionsApple PlatformOptionsIOS => null;

		public OptionsApple PlatformOptionsTVOS => null;

		public OptionsAndroid PlatformOptionsAndroid => null;

		public OptionsWindowsUWP PlatformOptionsWindowsUWP => null;

		public OptionsWebGL PlatformOptionsWebGL => null;

		private void Awake()
		{
		}

		protected void Initialise()
		{
		}

		private void Start()
		{
		}

		public bool OpenMedia(MediaPath path, bool autoPlay = true)
		{
			return false;
		}

		public bool OpenMedia(MediaPathType pathType, string path, bool autoPlay = true)
		{
			return false;
		}

		public bool OpenMedia(MediaReference mediaReference, bool autoPlay = true)
		{
			return false;
		}

		public bool OpenMedia(bool autoPlay = true)
		{
			return false;
		}

		private bool InternalOpenMedia()
		{
			return false;
		}

		private void SetLoadOptions()
		{
		}

		private void SetPlaybackOptions()
		{
		}

		public void CloseMedia()
		{
		}

		public void RewindPrerollPause()
		{
		}

		public virtual void Play()
		{
		}

		public virtual void Pause()
		{
		}

		public void Stop()
		{
		}

		public void Rewind(bool pause)
		{
		}

		public void SeekToLiveTime(double offset = 0.0)
		{
		}

		protected virtual void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateResampler()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public void ForceDispose()
		{
		}

		private static void AllPlayersDispose()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void StartRenderCoroutine()
		{
		}

		private void StopRenderCoroutine()
		{
		}

		[IteratorStateMachine(typeof(_003CFinalRenderCapture_003Ed__210))]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		public static Platform GetPlatform()
		{
			return default(Platform);
		}

		public PlatformOptions GetCurrentPlatformOptions()
		{
			return null;
		}

		private string GetPlatformVideoApiString()
		{
			return null;
		}

		private long GetPlatformFileOffset()
		{
			return 0L;
		}

		private string GetPlatformHttpHeadersAsString()
		{
			return null;
		}

		private string GetResolvedFilePath(string filePath, MediaPathType fileLocation)
		{
			return null;
		}

		private static BaseMediaPlayer CreateMediaPlayer(OptionsWindows options)
		{
			return null;
		}

		private static BaseMediaPlayer CreateMediaPlayerNull()
		{
			return null;
		}

		public virtual BaseMediaPlayer CreateMediaPlayer()
		{
			return null;
		}

		private void UpdateAudioFocus()
		{
		}

		private void UpdateAudioHeadTransform()
		{
		}

		private void UpdateErrors()
		{
		}

		public bool IsUsingAndroidOESPath()
		{
			return false;
		}

		[ContextMenu("Save Frame To PNG")]
		public void SaveFrameToPng()
		{
		}

		[ContextMenu("Save Frame To EXR")]
		public void SaveFrameToExr()
		{
		}

		private void OnApplicationFocus(bool focusStatus)
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private void ResetEvents()
		{
		}

		private void CheckAndClearStartedAndFinishedEvents()
		{
		}

		private void HandleOneShotEvents()
		{
		}

		private void HandleRecurringEvents()
		{
		}

		private void UpdateEvents()
		{
		}

		protected bool IsHandleEvent(MediaPlayerEvent.EventType eventType)
		{
			return false;
		}

		private bool FireEventIfPossible(MediaPlayerEvent.EventType eventType, bool hasFired)
		{
			return false;
		}

		private bool CanFireEvent(MediaPlayerEvent.EventType et, bool hasFired)
		{
			return false;
		}

		private bool ForceWaitForNewFrame(int lastFrameCount, float timeoutMs)
		{
			return false;
		}

		private static Camera GetDummyCamera()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CExtractFrameCoroutine_003Ed__251))]
		private IEnumerator ExtractFrameCoroutine(Texture2D target, ProcessExtractedFrame callback, double timeSeconds = -1.0, bool accurateSeek = true, int timeoutMs = 1000, int timeThresholdMs = 100)
		{
			return null;
		}

		public void ExtractFrameAsync(Texture2D target, ProcessExtractedFrame callback, double timeSeconds = -1.0, bool accurateSeek = true, int timeoutMs = 1000, int timeThresholdMs = 100)
		{
		}

		public Texture2D ExtractFrame(Texture2D target, double timeSeconds = -1.0, bool accurateSeek = true, int timeoutMs = 1000, int timeThresholdMs = 100)
		{
			return null;
		}

		private Texture ExtractFrame(double timeSeconds = -1.0, bool accurateSeek = true, int timeoutMs = 1000, int timeThresholdMs = 100)
		{
			return null;
		}

		public bool OpenMediaFromBuffer(byte[] buffer, bool autoPlay = true)
		{
			return false;
		}

		public bool StartOpenChunkedMediaFromBuffer(ulong length, bool autoPlay = true)
		{
			return false;
		}

		public bool AddChunkToVideoBuffer(byte[] chunk, ulong offset, ulong chunkSize)
		{
			return false;
		}

		public bool EndOpenChunkedVideoFromBuffer()
		{
			return false;
		}

		private bool OpenMediaFromBufferInternal(byte[] buffer)
		{
			return false;
		}

		private bool StartOpenMediaFromBufferInternal(ulong length)
		{
			return false;
		}

		private bool AddChunkToBufferInternal(byte[] chunk, ulong offset, ulong chunkSize)
		{
			return false;
		}

		private bool EndOpenMediaFromBufferInternal()
		{
			return false;
		}

		public bool EnableSubtitles(MediaPath mediaPath)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CLoadSubtitlesCoroutine_003Ed__291))]
		private IEnumerator LoadSubtitlesCoroutine(string url, MediaPath mediaPath)
		{
			return null;
		}

		public void DisableSubtitles()
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}
	}
}
