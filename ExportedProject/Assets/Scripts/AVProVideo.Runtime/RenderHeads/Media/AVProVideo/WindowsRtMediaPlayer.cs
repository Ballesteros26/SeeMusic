using System;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public sealed class WindowsRtMediaPlayer : BaseMediaPlayer
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		private struct Native
		{
			public enum SeekMode
			{
				Fast = 0,
				Accurate = 1
			}

			[StructLayout((LayoutKind)0, Pack = 1, Size = 20)]
			public struct VideoTrack
			{
				public int trackIndex;

				public int frameWidth;

				public int frameHeight;

				public float frameRate;

				public uint averageBitRate;
			}

			[StructLayout((LayoutKind)0, Pack = 1, Size = 20)]
			public struct AudioTrack
			{
				public int trackIndex;

				public uint channelCount;

				public uint sampleRate;

				public uint bitsPerSample;

				public uint averageBitRate;
			}

			[StructLayout((LayoutKind)0, Pack = 1, Size = 12)]
			public struct SeekParams
			{
				public double timeSeconds;

				public SeekMode mode;
			}

			[StructLayout((LayoutKind)0, Pack = 1, Size = 28)]
			public struct AuthData
			{
				public string url;

				public string token;

				public IntPtr keyBytes;

				public int keyBytesLength;
			}

			internal enum TimeRangeTypes
			{
				Seekable = 0,
				Buffered = 1
			}

			private static IntPtr _nativeFunction_UnityRenderEvent;

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
			private static extern IntPtr GetPluginVersionStringPointer();

			public static string GetPluginVersion()
			{
				return null;
			}

			[PreserveSig]
			public static extern IntPtr CreatePlayer();

			[PreserveSig]
			public static extern void DestroyPlayer(IntPtr playerInstance);

			[PreserveSig]
			public static extern bool OpenMedia(IntPtr playerInstance, string filePath, string httpHeader, FileFormat overrideFileFormat, bool startWithHighestBitrate, bool use10BitTextures);

			[PreserveSig]
			public static extern void CloseMedia(IntPtr playerInstance);

			[PreserveSig]
			public static extern void Pause(IntPtr playerInstance);

			[PreserveSig]
			public static extern void Play(IntPtr playerInstance);

			[PreserveSig]
			public static extern void SetAudioVolume(IntPtr playerInstance, float volume);

			[PreserveSig]
			public static extern void SetAudioBalance(IntPtr playerInstance, float balance);

			[PreserveSig]
			public static extern void SetPlaybackRate(IntPtr playerInstance, float rate);

			[PreserveSig]
			public static extern void SetAudioMuted(IntPtr playerInstance, bool muted);

			[PreserveSig]
			public static extern float GetAudioVolume(IntPtr playerInstance);

			[PreserveSig]
			public static extern bool IsAudioMuted(IntPtr playerInstance);

			[PreserveSig]
			public static extern float GetAudioBalance(IntPtr playerInstance);

			[PreserveSig]
			public static extern float GetPlaybackRate(IntPtr playerInstance);

			[PreserveSig]
			public static extern void SetLooping(IntPtr playerInstance, bool looping);

			[PreserveSig]
			public static extern bool IsLooping(IntPtr playerInstance);

			[PreserveSig]
			public static extern int GetLastErrorCode(IntPtr playerInstance);

			[PreserveSig]
			public static extern void Update(IntPtr playerInstance);

			[PreserveSig]
			public static extern double GetDuration(IntPtr playerInstance);

			[PreserveSig]
			public static extern StereoPacking GetStereoPacking(IntPtr playerInstance);

			[PreserveSig]
			public static extern double GetCurrentPosition(IntPtr playerInstance);

			[PreserveSig]
			public static extern bool GetLatestFrame(IntPtr playerInstance, out IntPtr leftEyeTexturePointer, out IntPtr rightEyeTexturePointer, out ulong frameTimeStamp, out int width, out int height);

			[PreserveSig]
			public static extern PlaybackState GetPlaybackState(IntPtr playerInstance);

			[PreserveSig]
			public static extern bool GetActiveVideoTrackInfo(IntPtr playerInstance, out VideoTrack videoTrack);

			[PreserveSig]
			public static extern bool GetActiveAudioTrackInfo(IntPtr playerInstance, out AudioTrack audioTrack);

			[PreserveSig]
			public static extern double GetCurrentDateTimeSecondsSince1970(IntPtr playerInstance);

			[PreserveSig]
			public static extern void SetLiveOffset(IntPtr playerInstance, double seconds);

			[PreserveSig]
			public static extern void DebugValues(IntPtr playerInstance, out int isD3D, out int isUnityD3D, out int isTexture, out int isSharedTexture, out int isSurface);

			[PreserveSig]
			public static extern void Seek(IntPtr playerInstance, ref SeekParams seekParams);

			public static void SetNextAuthData(IntPtr playerInstance, RenderHeads.Media.AVProVideo.AuthData srcAuthData)
			{
			}

			[PreserveSig]
			private static extern void SetNextAuthData(IntPtr playerInstance, ref AuthData authData);

			[PreserveSig]
			public static extern int GetTimeRanges(IntPtr playerInstance, [Out] TimeRange[] ranges, int rangeCount, TimeRangeTypes timeRangeType);

			[PreserveSig]
			public static extern IntPtr GetRenderEventFunc();

			public static void IssueRenderThreadEvent_UpdateAllTextures()
			{
			}

			public static void IssueRenderThreadEvent_FreeAllTextures()
			{
			}
		}

		private class EyeTexture
		{
			public Texture2D texture;

			public IntPtr nativePointer;

			public void Dispose()
			{
			}
		}

		private bool _isMediaLoaded;

		private bool _use10BitTextures;

		private bool _useLowLiveLatency;

		private AuthData _nextAuthData;

		private static bool _isInitialised;

		private static string _version;

		private ulong _frameTimeStamp;

		private IntPtr _playerInstance;

		private EyeTexture[] _eyeTextures;

		public AuthData AuthenticationData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public WindowsRtMediaPlayer(MediaPlayer.OptionsWindows options)
		{
		}

		public WindowsRtMediaPlayer(MediaPlayer.OptionsWindowsUWP options)
		{
		}

		public override bool CanPlay()
		{
			return false;
		}

		public override void Dispose()
		{
		}

		public override bool PlayerSupportsLinearColorSpace()
		{
			return false;
		}

		public override double GetCurrentTime()
		{
			return 0.0;
		}

		public override double GetDuration()
		{
			return 0.0;
		}

		public override float GetPlaybackRate()
		{
			return 0f;
		}

		public override Texture GetTexture(int index = 0)
		{
			return null;
		}

		public override int GetTextureCount()
		{
			return 0;
		}

		public override int GetTextureFrameCount()
		{
			return 0;
		}

		internal override StereoPacking InternalGetTextureStereoPacking()
		{
			return default(StereoPacking);
		}

		public override string GetVersion()
		{
			return null;
		}

		public override string GetExpectedVersion()
		{
			return null;
		}

		public override float GetVideoFrameRate()
		{
			return 0f;
		}

		public override int GetVideoWidth()
		{
			return 0;
		}

		public override int GetVideoHeight()
		{
			return 0;
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

		public override bool HasAudio()
		{
			return false;
		}

		public override bool HasMetaData()
		{
			return false;
		}

		public override bool HasVideo()
		{
			return false;
		}

		public override bool IsBuffering()
		{
			return false;
		}

		public override bool IsFinished()
		{
			return false;
		}

		public override bool IsLooping()
		{
			return false;
		}

		public override bool IsMuted()
		{
			return false;
		}

		public override bool IsPaused()
		{
			return false;
		}

		public override bool IsPlaying()
		{
			return false;
		}

		public override bool IsSeeking()
		{
			return false;
		}

		public override void MuteAudio(bool bMuted)
		{
		}

		public override bool OpenMedia(string path, long offset, string httpHeader, MediaHints mediaHints, int forceFileFormat = 0, bool startWithHighestBitrate = false)
		{
			return false;
		}

		public override void CloseMedia()
		{
		}

		public override void Pause()
		{
		}

		public override void Play()
		{
		}

		public override void Render()
		{
		}

		private void Update_Textures()
		{
		}

		public override bool RequiresVerticalFlip()
		{
			return false;
		}

		public override void Seek(double time)
		{
		}

		public override void SeekFast(double time)
		{
		}

		public override void SetLooping(bool bLooping)
		{
		}

		public override void SetPlaybackRate(float rate)
		{
		}

		public override void SetVolume(float volume)
		{
		}

		public override void Stop()
		{
		}

		private void UpdateTimeRanges()
		{
		}

		private void UpdateTimeRange(ref TimeRange[] range, Native.TimeRangeTypes timeRangeType)
		{
		}

		public override DateTime GetProgramDateTime()
		{
			return default(DateTime);
		}

		public override void Update()
		{
		}

		public override void SetKeyServerAuthToken(string token)
		{
		}

		public override void SetOverrideDecryptionKey(byte[] key)
		{
		}

		internal override bool InternalSetActiveTrack(TrackType trackType, int trackUid)
		{
			return false;
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

		internal override bool InternalIsChangedTextCue()
		{
			return false;
		}

		internal override string InternalGetCurrentTextCue()
		{
			return null;
		}

		public static bool InitialisePlatform()
		{
			return false;
		}

		public static void DeinitPlatform()
		{
		}
	}
}
