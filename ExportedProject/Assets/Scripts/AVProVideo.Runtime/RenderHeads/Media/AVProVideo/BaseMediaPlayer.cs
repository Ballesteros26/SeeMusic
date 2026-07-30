using System;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public abstract class BaseMediaPlayer : IMediaPlayer, IMediaControl, IMediaInfo, IMediaCache, ITextureProducer, IMediaSubtitles, IVideoTracks, IAudioTracks, ITextTracks, IBufferedDisplay, IDisposable
	{
		protected string _playerDescription;

		protected ErrorCode _lastError;

		protected FilterMode _defaultTextureFilterMode;

		protected TextureWrapMode _defaultTextureWrapMode;

		protected int _defaultTextureAnisoLevel;

		protected MediaHints _mediaHints;

		protected TimeRanges _seekableTimes;

		protected TimeRanges _bufferedTimes;

		private float _displayRateTimer;

		private int _displayRateLastFrameCount;

		private float _displayRate;

		private float _stallDetectionTimer;

		private int _stallDetectionFrame;

		private int _stallDetectionGuard;

		protected List<Subtitle> _subtitles;

		protected Subtitle _currentSubtitle;

		private int _unityFrameCountBufferedDisplayGuard;

		protected PlaybackQualityStats _playbackQualityStats;

		protected TextCue _currentTextCue;

		protected VideoTracks _videoTracks;

		protected AudioTracks _audioTracks;

		protected TextTracks _textTracks;

		protected TrackCollection[] _trackCollections;

		public BaseMediaPlayer()
		{
		}

		public abstract string GetVersion();

		public abstract string GetExpectedVersion();

		public abstract bool OpenMedia(string path, long offset, string customHttpHeaders, MediaHints mediaHints, int forceFileFormat = 0, bool startWithHighestBitrate = false);

		public virtual bool OpenMediaFromBuffer(byte[] buffer)
		{
			return false;
		}

		public virtual bool StartOpenMediaFromBuffer(ulong length)
		{
			return false;
		}

		public virtual bool AddChunkToMediaBuffer(byte[] chunk, ulong offset, ulong length)
		{
			return false;
		}

		public virtual bool EndOpenMediaFromBuffer()
		{
			return false;
		}

		public virtual void CloseMedia()
		{
		}

		public abstract void SetLooping(bool looping);

		public abstract bool IsLooping();

		public abstract bool HasMetaData();

		public abstract bool CanPlay();

		public abstract void Play();

		public abstract void Pause();

		public abstract void Stop();

		public virtual void Rewind()
		{
		}

		public abstract void Seek(double time);

		public abstract void SeekFast(double time);

		public virtual void SeekWithTolerance(double time, double timeDeltaBefore, double timeDeltaAfter)
		{
		}

		public abstract double GetCurrentTime();

		public virtual DateTime GetProgramDateTime()
		{
			return default(DateTime);
		}

		public abstract float GetPlaybackRate();

		public abstract void SetPlaybackRate(float rate);

		public abstract double GetDuration();

		public abstract int GetVideoWidth();

		public abstract int GetVideoHeight();

		public abstract float GetVideoFrameRate();

		public virtual float GetVideoDisplayRate()
		{
			return 0f;
		}

		public abstract bool HasAudio();

		public abstract bool HasVideo();

		public bool IsVideoStereo()
		{
			return false;
		}

		public abstract bool IsSeeking();

		public abstract bool IsPlaying();

		public abstract bool IsPaused();

		public abstract bool IsFinished();

		public abstract bool IsBuffering();

		public virtual bool WaitForNextFrame(Camera dummyCamera, int previousFrameCount)
		{
			return false;
		}

		public virtual int GetTextureCount()
		{
			return 0;
		}

		public abstract Texture GetTexture(int index = 0);

		public abstract int GetTextureFrameCount();

		public virtual bool SupportsTextureFrameCount()
		{
			return false;
		}

		public virtual long GetTextureTimeStamp()
		{
			return 0L;
		}

		public abstract bool RequiresVerticalFlip();

		public virtual float GetTexturePixelAspectRatio()
		{
			return 0f;
		}

		public virtual Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		public virtual float[] GetAffineTransform()
		{
			return null;
		}

		public virtual float[] GetTextureTransform()
		{
			return null;
		}

		public virtual Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		public StereoPacking GetTextureStereoPacking()
		{
			return default(StereoPacking);
		}

		internal abstract StereoPacking InternalGetTextureStereoPacking();

		public virtual TransparencyMode GetTextureTransparency()
		{
			return default(TransparencyMode);
		}

		public AlphaPacking GetTextureAlphaPacking()
		{
			return default(AlphaPacking);
		}

		public abstract void MuteAudio(bool bMuted);

		public abstract bool IsMuted();

		public abstract void SetVolume(float volume);

		public virtual void SetBalance(float balance)
		{
		}

		public abstract float GetVolume();

		public virtual float GetBalance()
		{
			return 0f;
		}

		public virtual int GetAudioChannelCount()
		{
			return 0;
		}

		public virtual AudioChannelMaskFlags GetAudioChannelMask()
		{
			return default(AudioChannelMaskFlags);
		}

		public virtual int GrabAudio(float[] audioData, int audioDataFloatCount, int channelCount)
		{
			return 0;
		}

		public virtual int GetAudioBufferedSampleCount()
		{
			return 0;
		}

		public virtual void AudioConfigurationChanged(bool deviceChanged)
		{
		}

		public virtual void SetAudioHeadRotation(Quaternion q)
		{
		}

		public virtual void ResetAudioHeadRotation()
		{
		}

		public virtual void SetAudioChannelMode(Audio360ChannelMode channelMode)
		{
		}

		public virtual void SetAudioFocusEnabled(bool enabled)
		{
		}

		public virtual void SetAudioFocusProperties(float offFocusLevel, float widthDegrees)
		{
		}

		public virtual void SetAudioFocusRotation(Quaternion q)
		{
		}

		public virtual void ResetAudioFocus()
		{
		}

		public virtual long GetEstimatedTotalBandwidthUsed()
		{
			return 0L;
		}

		public virtual void SetPlayWithoutBuffering(bool playWithoutBuffering)
		{
		}

		public virtual bool IsMediaCachingSupported()
		{
			return false;
		}

		public virtual void AddMediaToCache(string url, string headers, MediaCachingOptions options)
		{
		}

		public virtual void CancelDownloadOfMediaToCache(string url)
		{
		}

		public virtual void PauseDownloadOfMediaToCache(string url)
		{
		}

		public virtual void ResumeDownloadOfMediaToCache(string url)
		{
		}

		public virtual void RemoveMediaFromCache(string url)
		{
		}

		public virtual CachedMediaStatus GetCachedMediaStatus(string url, ref float progress)
		{
			return default(CachedMediaStatus);
		}

		public virtual bool IsExternalPlaybackSupported()
		{
			return false;
		}

		public virtual bool IsExternalPlaybackActive()
		{
			return false;
		}

		public virtual void SetAllowsExternalPlayback(bool enable)
		{
		}

		public virtual void SetExternalPlaybackVideoGravity(ExternalPlaybackVideoGravity gravity)
		{
		}

		public virtual void SetKeyServerAuthToken(string token)
		{
		}

		public virtual void SetOverrideDecryptionKey(byte[] key)
		{
		}

		public abstract void Update();

		public virtual void BeginRender()
		{
		}

		public abstract void Render();

		public abstract void Dispose();

		public virtual bool GetDecoderPerformance(ref int activeDecodeThreadCount, ref int decodedFrameCount, ref int droppedFrameCount)
		{
			return false;
		}

		public virtual void EndUpdate()
		{
		}

		public virtual IntPtr GetNativePlayerHandle()
		{
			return (IntPtr)0;
		}

		public ErrorCode GetLastError()
		{
			return default(ErrorCode);
		}

		public virtual long GetLastExtendedErrorCode()
		{
			return 0L;
		}

		public string GetPlayerDescription()
		{
			return null;
		}

		public virtual bool PlayerSupportsLinearColorSpace()
		{
			return false;
		}

		public TimeRanges GetSeekableTimes()
		{
			return null;
		}

		public TimeRanges GetBufferedTimes()
		{
			return null;
		}

		public void GetTextureProperties(out FilterMode filterMode, out TextureWrapMode wrapMode, out int anisoLevel)
		{
			filterMode = default(FilterMode);
			wrapMode = default(TextureWrapMode);
			anisoLevel = default(int);
		}

		public void SetTextureProperties(FilterMode filterMode = FilterMode.Bilinear, TextureWrapMode wrapMode = TextureWrapMode.Clamp, int anisoLevel = 0)
		{
		}

		protected virtual void ApplyTextureProperties(Texture texture)
		{
		}

		protected void UpdateDisplayFrameRate()
		{
		}

		protected bool IsExpectingNewVideoFrame()
		{
			return false;
		}

		public virtual bool IsPlaybackStalled()
		{
			return false;
		}

		public bool LoadSubtitlesSRT(string data)
		{
			return false;
		}

		public virtual void UpdateSubtitles()
		{
		}

		public virtual int GetSubtitleIndex()
		{
			return 0;
		}

		public virtual string GetSubtitleText()
		{
			return null;
		}

		public virtual void OnEnable()
		{
		}

		public int GetCurrentTimeFrames(float overrideFrameRate = 0f)
		{
			return 0;
		}

		public int GetDurationFrames(float overrideFrameRate = 0f)
		{
			return 0;
		}

		public int GetMaxFrameNumber(float overrideFrameRate = 0f)
		{
			return 0;
		}

		public void SeekToFrameRelative(int frameOffset, float overrideFrameRate = 0f)
		{
		}

		public void SeekToFrame(int frame, float overrideFrameRate = 0f)
		{
		}

		public long UpdateBufferedDisplay()
		{
			return 0L;
		}

		internal virtual long InternalUpdateBufferedDisplay()
		{
			return 0L;
		}

		public virtual BufferedFramesState GetBufferedFramesState()
		{
			return default(BufferedFramesState);
		}

		public virtual void SetSlaves(IBufferedDisplay[] slaves)
		{
		}

		public virtual void SetBufferedDisplayMode(BufferedFrameSelectionMode mode, IBufferedDisplay master = null)
		{
		}

		public virtual void SetBufferedDisplayOptions(bool pauseOnPrerollComplete)
		{
		}

		public PlaybackQualityStats GetPlaybackQualityStats()
		{
			return null;
		}

		public TextCue GetCurrentTextCue()
		{
			return null;
		}

		protected bool UpdateTextCue(bool force = false)
		{
			return false;
		}

		internal abstract bool InternalIsChangedTextCue();

		internal abstract string InternalGetCurrentTextCue();

		public VideoTracks GetVideoTracks()
		{
			return null;
		}

		public AudioTracks GetAudioTracks()
		{
			return null;
		}

		public TextTracks GetTextTracks()
		{
			return null;
		}

		public VideoTrack GetActiveVideoTrack()
		{
			return null;
		}

		public AudioTrack GetActiveAudioTrack()
		{
			return null;
		}

		public TextTrack GetActiveTextTrack()
		{
			return null;
		}

		public void SetActiveVideoTrack(VideoTrack track)
		{
		}

		public void SetActiveAudioTrack(AudioTrack track)
		{
		}

		public void SetActiveTextTrack(TextTrack track)
		{
		}

		internal abstract bool InternalIsChangedTracks(TrackType trackType);

		internal abstract int InternalGetTrackCount(TrackType trackType);

		internal abstract bool InternalSetActiveTrack(TrackType trackType, int trackUid);

		internal abstract TrackBase InternalGetTrackInfo(TrackType trackType, int trackIndex, ref bool isActiveTrack);

		private void InitTracks()
		{
		}

		protected void UpdateTracks()
		{
		}

		private void PopulateTrackCollection(TrackCollection collection)
		{
		}

		private void SetActiveTrack(TrackCollection collection, TrackBase track)
		{
		}
	}
}
