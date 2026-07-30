using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public class WindowsMediaPlayer : BaseMediaPlayer
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		private struct Native
		{
			internal enum TimeRangeTypes
			{
				Seekable = 0,
				Buffered = 1
			}

			public enum RenderThreadEvent
			{
				BeginRender = 0,
				UpdateAllTextures = 1,
				FreeTextures = 2,
				WaitForNewFrame = 3
			}

			[PreserveSig]
			public static extern bool IsChangedTracks(IntPtr instance, TrackType trackType);

			[PreserveSig]
			public static extern int GetTrackCount(IntPtr instance, TrackType trackType);

			[PreserveSig]
			public static extern bool GetTrackInfo(IntPtr instance, TrackType trackType, int index, ref int uid, ref bool isActive, StringBuilder name, int maxNameLength, StringBuilder language, int maxLanguageLength);

			[PreserveSig]
			public static extern bool SetActiveTrack(IntPtr instance, TrackType trackType, int trackUid);

			[PreserveSig]
			public static extern bool IsChangedTextCue(IntPtr instance);

			[PreserveSig]
			public static extern IntPtr GetCurrentTextCue(IntPtr instance);

			[PreserveSig]
			public static extern int GetTimeRanges(IntPtr playerInstance, [Out] TimeRange[] ranges, int rangeCount, TimeRangeTypes timeRangeType);

			[PreserveSig]
			public static extern bool Init(bool linearColorSpace);

			[PreserveSig]
			public static extern void Deinit();

			[PreserveSig]
			public static extern IntPtr GetPluginVersion();

			[PreserveSig]
			public static extern bool IsTrialVersion();

			[PreserveSig]
			public static extern IntPtr BeginOpenSource(IntPtr instance, Windows.VideoApi videoApi, Windows.AudioOutput audioOutput, bool useHardwareDecoding, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters, int audio360ChannelMode);

			[PreserveSig]
			public static extern IntPtr EndOpenSource(IntPtr instance, string path);

			[PreserveSig]
			public static extern IntPtr OpenSourceFromBuffer(IntPtr instance, byte[] buffer, ulong bufferLength, Windows.VideoApi videoApi, Windows.AudioOutput audioOutput, bool useHardwareDecoding, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters);

			[PreserveSig]
			public static extern IntPtr StartOpenSourceFromBuffer(IntPtr instance, Windows.VideoApi videoApi, ulong bufferLength);

			[PreserveSig]
			public static extern bool AddChunkToSourceBuffer(IntPtr instance, byte[] buffer, ulong offset, ulong chunkLength);

			[PreserveSig]
			public static extern IntPtr EndOpenSourceFromBuffer(IntPtr instance, Windows.AudioOutput audioOutput, bool useHardwareDecoding, bool generateTextureMips, bool hintAlphaChannel, bool useLowLatency, bool use10BitTextures, string forceAudioOutputDeviceName, int unitySampleRate, IntPtr[] preferredFilter, uint numFilters);

			[PreserveSig]
			public static extern void CloseSource(IntPtr instance);

			[PreserveSig]
			public static extern IntPtr GetPlayerDescription(IntPtr instance);

			[PreserveSig]
			public static extern void SetCustomMovParserEnabled(IntPtr instance, bool enabled);

			[PreserveSig]
			public static extern void SetHapNotchLCEnabled(IntPtr instance, bool enabled);

			[PreserveSig]
			public static extern void SetFrameBufferingEnabled(IntPtr instance, bool enabled, bool pauseOnPrerollComplete);

			[PreserveSig]
			public static extern void SetStereoDetectEnabled(IntPtr instance, bool enabled);

			[PreserveSig]
			public static extern void SetTextTrackSupportEnabled(IntPtr instance, bool enabled);

			[PreserveSig]
			public static extern void SetAudioDelayEnabled(IntPtr instance, bool enabled, bool isAutomatic, double timeSeconds);

			[PreserveSig]
			public static extern void SetFacebookAudio360SupportEnabled(IntPtr instance, bool enabled);

			[PreserveSig]
			public static extern void SetDecoderHints(IntPtr instance, int parallelFrameCount, int prerollFrameCount);

			[PreserveSig]
			public static extern bool GetDecoderPerformance(IntPtr instance, ref int activeDecodeThreadCount, ref int decodedFrameCount, ref int droppedFrameCount);

			[PreserveSig]
			public static extern int GetLastErrorCode(IntPtr instance);

			[PreserveSig]
			public static extern long GetLastExtendedErrorCode(IntPtr instance);

			[PreserveSig]
			public static extern void Play(IntPtr instance);

			[PreserveSig]
			public static extern void Pause(IntPtr instance);

			[PreserveSig]
			public static extern void SetMuted(IntPtr instance, bool muted);

			[PreserveSig]
			public static extern void SetVolume(IntPtr instance, float volume);

			[PreserveSig]
			public static extern void SetBalance(IntPtr instance, float volume);

			[PreserveSig]
			public static extern void SetLooping(IntPtr instance, bool looping);

			[PreserveSig]
			public static extern bool HasVideo(IntPtr instance);

			[PreserveSig]
			public static extern bool HasAudio(IntPtr instance);

			[PreserveSig]
			public static extern int GetWidth(IntPtr instance);

			[PreserveSig]
			public static extern int GetHeight(IntPtr instance);

			[PreserveSig]
			public static extern float GetFrameRate(IntPtr instance);

			[PreserveSig]
			public static extern StereoPacking GetStereoPacking(IntPtr instance);

			[PreserveSig]
			public static extern double GetDuration(IntPtr instance);

			[PreserveSig]
			public static extern bool IsPlaybackStalled(IntPtr instance);

			[PreserveSig]
			public static extern bool HasMetaData(IntPtr instance);

			[PreserveSig]
			public static extern bool CanPlay(IntPtr instance);

			[PreserveSig]
			public static extern bool IsSeeking(IntPtr instance);

			[PreserveSig]
			public static extern bool IsPlaying(IntPtr instance);

			[PreserveSig]
			public static extern bool IsFinished(IntPtr instance);

			[PreserveSig]
			public static extern bool IsBuffering(IntPtr instance);

			[PreserveSig]
			public static extern double GetCurrentTime(IntPtr instance);

			[PreserveSig]
			public static extern void SetCurrentTime(IntPtr instance, double time, bool fast);

			[PreserveSig]
			public static extern float GetPlaybackRate(IntPtr instance);

			[PreserveSig]
			public static extern void SetPlaybackRate(IntPtr instance, float rate);

			[PreserveSig]
			public static extern void StartExtractFrame(IntPtr instance);

			[PreserveSig]
			public static extern void WaitForExtract(IntPtr instance);

			[PreserveSig]
			public static extern void Update(IntPtr instance);

			[PreserveSig]
			public static extern void EndUpdate(IntPtr instance);

			[PreserveSig]
			public static extern IntPtr GetTexturePointer(IntPtr instance);

			[PreserveSig]
			public static extern int GetTextureFormat(IntPtr instance);

			[PreserveSig]
			public static extern bool IsTextureTopDown(IntPtr instance);

			[PreserveSig]
			public static extern bool IsTextureSampleLinear(IntPtr instance);

			[PreserveSig]
			public static extern int GetTextureFrameCount(IntPtr instance);

			[PreserveSig]
			public static extern long GetTextureTimeStamp(IntPtr instance);

			[PreserveSig]
			public static extern float GetTexturePixelAspectRatio(IntPtr instance);

			[PreserveSig]
			public static extern IntPtr GetRenderEventFunc();

			[PreserveSig]
			public static extern int GrabAudio(IntPtr instance, float[] buffer, int sampleCount, int channelCount);

			[PreserveSig]
			public static extern int GetAudioBufferedSampleCount(IntPtr instance);

			[PreserveSig]
			public static extern int GetAudioChannelCount(IntPtr instance);

			[PreserveSig]
			public static extern int GetAudioChannelMask(IntPtr instance);

			[PreserveSig]
			public static extern int SetAudioChannelMode(IntPtr instance, int audio360ChannelMode);

			[PreserveSig]
			public static extern void SetHeadOrientation(IntPtr instance, float x, float y, float z, float w);

			[PreserveSig]
			public static extern void SetAudioFocusEnabled(IntPtr instance, bool enabled);

			[PreserveSig]
			public static extern void SetAudioFocusProps(IntPtr instance, float offFocusLevel, float widthDegrees);

			[PreserveSig]
			public static extern void SetAudioFocusRotation(IntPtr instance, float x, float y, float z, float w);

			[PreserveSig]
			public static extern bool GetBufferedFramesState(IntPtr playerInstance, ref BufferedFramesState state);

			[PreserveSig]
			public static extern bool LockTextureFrame(IntPtr instance, BufferedFrameSelectionMode mode, long time, ref TextureFrame textureFrame, bool ignorePreroll);

			[PreserveSig]
			public static extern void UnlockTextureFrame(IntPtr instance, ref TextureFrame textureFrame);

			[PreserveSig]
			public static extern void ReleaseTextureFrame(IntPtr instance, ref TextureFrame textureFrame);

			[PreserveSig]
			public static extern void FlushFrameBuffering(IntPtr instance);
		}

		private Windows.AudioOutput _audioOutput;

		private string _audioDeviceOutputName;

		private List<string> _preferredFilters;

		private Audio360ChannelMode _audio360ChannelMode;

		private bool _useCustomMovParser;

		private bool _useStereoDetection;

		private bool _useHapNotchLC;

		private bool _useTextTrackSupport;

		private bool _useFacebookAudio360Support;

		private bool _useAudioDelay;

		private int _decoderParallelFrameCount;

		private int _decodePrerollFrameCount;

		private bool _isPlaying;

		private bool _isPaused;

		private bool _audioMuted;

		private float _volume;

		private float _balance;

		private bool _isLooping;

		private bool _canPlay;

		private bool _hasMetaData;

		private int _width;

		private int _height;

		private float _frameRate;

		private bool _hasAudio;

		private bool _hasVideo;

		private bool _isTextureTopDown;

		private IntPtr _nativeTexture;

		private Texture2D _texture;

		private RenderTexture _resolvedTexture;

		private IntPtr _instance;

		private Windows.VideoApi _videoApi;

		private bool _useHardwareDecoding;

		private bool _useTextureMips;

		private bool _use10BitTextures;

		private bool _hintAlphaChannel;

		private bool _useLowLatency;

		private bool _supportsLinearColorSpace;

		private TextureFrame _textureFrame;

		private static bool _isInitialised;

		private static string _version;

		private static IntPtr _nativeFunction_UnityRenderEvent;

		private static int _lastUpdateAllTexturesFrame;

		private BufferedFrameSelectionMode _frameSelectionMode;

		private bool _pauseOnPrerollComplete;

		private IBufferedDisplay _masterDisplay;

		private IBufferedDisplay[] _slaveDisplays;

		private double _displayClockTime;

		private double _timeAccumulation;

		private bool _needsInitialFrame;

		public static bool InitialisePlatform()
		{
			return false;
		}

		public static void DeinitPlatform()
		{
		}

		public override int GetAudioChannelCount()
		{
			return 0;
		}

		public override AudioChannelMaskFlags GetAudioChannelMask()
		{
			return default(AudioChannelMaskFlags);
		}

		public WindowsMediaPlayer(MediaPlayer.OptionsWindows options)
		{
		}

		public WindowsMediaPlayer(MediaPlayer.OptionsWindowsUWP options)
		{
		}

		public void SetOptions(Windows.VideoApi videoApi, Windows.AudioOutput audioOutput, bool useHardwareDecoding, bool useTextureMips, bool use10BitTextures, bool hintAlphaChannel, bool useLowLatency, string audioDeviceOutputName, List<string> preferredFilters, bool useCustomMovParser, int parallelFrameCount, int prerollFrameCount, bool useHapNotchLC, bool useStereoDetection, bool useTextTrackSupport, bool useFacebookAudio360Support, BufferedFrameSelectionMode bufferedFrameSelection, bool pauseOnPrerollComplete, bool useAudioDelay)
		{
		}

		public override string GetVersion()
		{
			return null;
		}

		public override string GetExpectedVersion()
		{
			return null;
		}

		private bool UseNativeMips()
		{
			return false;
		}

		public override bool OpenMedia(string path, long offset, string httpHeader, MediaHints mediaHints, int forceFileFormat = 0, bool startWithHighestBitrate = false)
		{
			return false;
		}

		public override bool OpenMediaFromBuffer(byte[] buffer)
		{
			return false;
		}

		public override bool StartOpenMediaFromBuffer(ulong length)
		{
			return false;
		}

		public override bool AddChunkToMediaBuffer(byte[] chunk, ulong offset, ulong length)
		{
			return false;
		}

		public override bool EndOpenMediaFromBuffer()
		{
			return false;
		}

		private void DisplayLoadFailureSuggestion(string path)
		{
		}

		public override void CloseMedia()
		{
		}

		public override void SetLooping(bool looping)
		{
		}

		public override bool IsLooping()
		{
			return false;
		}

		public override bool HasMetaData()
		{
			return false;
		}

		public override bool HasAudio()
		{
			return false;
		}

		public override bool HasVideo()
		{
			return false;
		}

		public override bool CanPlay()
		{
			return false;
		}

		public override void Play()
		{
		}

		public override void Pause()
		{
		}

		public override void Stop()
		{
		}

		public override bool IsSeeking()
		{
			return false;
		}

		public override bool IsPlaying()
		{
			return false;
		}

		public override bool IsPaused()
		{
			return false;
		}

		public override bool IsFinished()
		{
			return false;
		}

		public override bool IsBuffering()
		{
			return false;
		}

		public override double GetDuration()
		{
			return 0.0;
		}

		public override int GetVideoWidth()
		{
			return 0;
		}

		public override int GetVideoHeight()
		{
			return 0;
		}

		public override float GetVideoFrameRate()
		{
			return 0f;
		}

		public override Texture GetTexture(int index)
		{
			return null;
		}

		public override int GetTextureFrameCount()
		{
			return 0;
		}

		public override long GetTextureTimeStamp()
		{
			return 0L;
		}

		public override float GetTexturePixelAspectRatio()
		{
			return 0f;
		}

		public override bool RequiresVerticalFlip()
		{
			return false;
		}

		internal override StereoPacking InternalGetTextureStereoPacking()
		{
			return default(StereoPacking);
		}

		public override void Seek(double time)
		{
		}

		public override void SeekFast(double time)
		{
		}

		public override double GetCurrentTime()
		{
			return 0.0;
		}

		public override void SetPlaybackRate(float rate)
		{
		}

		public override float GetPlaybackRate()
		{
			return 0f;
		}

		public override void MuteAudio(bool bMuted)
		{
		}

		public override bool IsMuted()
		{
			return false;
		}

		public override void SetVolume(float volume)
		{
		}

		public override float GetVolume()
		{
			return 0f;
		}

		public override void SetBalance(float balance)
		{
		}

		public override float GetBalance()
		{
			return 0f;
		}

		public override bool IsPlaybackStalled()
		{
			return false;
		}

		public override bool WaitForNextFrame(Camera dummyCamera, int previousFrameCount)
		{
			return false;
		}

		public override void SetAudioChannelMode(Audio360ChannelMode channelMode)
		{
		}

		public override void SetAudioHeadRotation(Quaternion q)
		{
		}

		public override void ResetAudioHeadRotation()
		{
		}

		public override void SetAudioFocusEnabled(bool enabled)
		{
		}

		public override void SetAudioFocusProperties(float offFocusLevel, float widthDegrees)
		{
		}

		public override void SetAudioFocusRotation(Quaternion q)
		{
		}

		public override void ResetAudioFocus()
		{
		}

		public override void Update()
		{
		}

		private void ReleaseTexture()
		{
		}

		private void UpdateTexture(IntPtr newPtr)
		{
		}

		public override void EndUpdate()
		{
		}

		public override long GetLastExtendedErrorCode()
		{
			return 0L;
		}

		private void OnTextureSizeChanged()
		{
		}

		public override void BeginRender()
		{
		}

		public override void Render()
		{
		}

		public override void Dispose()
		{
		}

		public override int GrabAudio(float[] buffer, int sampleCount, int channelCount)
		{
			return 0;
		}

		public override int GetAudioBufferedSampleCount()
		{
			return 0;
		}

		public override bool PlayerSupportsLinearColorSpace()
		{
			return false;
		}

		public override bool GetDecoderPerformance(ref int activeDecodeThreadCount, ref int decodedFrameCount, ref int droppedFrameCount)
		{
			return false;
		}

		private static void IssueRenderThreadEvent(Native.RenderThreadEvent renderEvent)
		{
		}

		private static string GetPluginVersion()
		{
			return null;
		}

		internal override bool InternalSetActiveTrack(TrackType trackType, int trackUid)
		{
			return false;
		}

		internal override bool InternalIsChangedTextCue()
		{
			return false;
		}

		internal override string InternalGetCurrentTextCue()
		{
			return null;
		}

		internal override bool InternalIsChangedTracks(TrackType trackType)
		{
			return false;
		}

		internal override int InternalGetTrackCount(TrackType trackType)
		{
			return 0;
		}

		internal override TrackBase InternalGetTrackInfo(TrackType trackType, int trackIndex, ref bool isActiveTrack)
		{
			return null;
		}

		private void UpdateTimeRanges()
		{
		}

		private void UpdateTimeRange(ref TimeRange[] range, Native.TimeRangeTypes timeRangeType)
		{
		}

		private void FlushFrameBuffering(bool releaseTexture)
		{
		}

		internal override long InternalUpdateBufferedDisplay()
		{
			return 0L;
		}

		private void LogBufferState()
		{
		}

		private bool SetBufferedDisplayTime(BufferedFrameSelectionMode mode, long timeOfDesiredFrameToDisplay, bool ignorePreroll)
		{
			return false;
		}

		public override BufferedFramesState GetBufferedFramesState()
		{
			return default(BufferedFramesState);
		}

		public override void SetBufferedDisplayMode(BufferedFrameSelectionMode mode, IBufferedDisplay master = null)
		{
		}

		public override void SetBufferedDisplayOptions(bool pauseOnPrerollComplete)
		{
		}

		public override void SetSlaves(IBufferedDisplay[] slaves)
		{
		}

		private bool IsPrerollComplete()
		{
			return false;
		}
	}
}
