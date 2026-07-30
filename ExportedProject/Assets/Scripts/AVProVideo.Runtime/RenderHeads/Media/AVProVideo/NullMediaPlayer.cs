using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public sealed class NullMediaPlayer : BaseMediaPlayer
	{
		private bool _isPlaying;

		private bool _isPaused;

		private double _currentTime;

		private float _volume;

		private float _playbackRate;

		private bool _bLoop;

		private int _Width;

		private int _height;

		private Texture2D _texture;

		private Texture2D _texture_AVPro;

		private Texture2D _texture_AVPro1;

		private float _fakeFlipTime;

		private int _frameCount;

		private const float FrameRate = 10f;

		public override string GetVersion()
		{
			return null;
		}

		public override string GetExpectedVersion()
		{
			return null;
		}

		public override bool OpenMedia(string path, long offset, string httpHeader, MediaHints mediaHints, int forceFileFormat = 0, bool startWithHighestBitrate = false)
		{
			return false;
		}

		public override void CloseMedia()
		{
		}

		public override void SetLooping(bool bLooping)
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

		public override bool CanPlay()
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

		public override float GetVideoDisplayRate()
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

		internal override StereoPacking InternalGetTextureStereoPacking()
		{
			return default(StereoPacking);
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

		public override float GetVideoFrameRate()
		{
			return 0f;
		}

		public override void Update()
		{
		}

		public override void Render()
		{
		}

		public override void Dispose()
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

		internal override TrackBase InternalGetTrackInfo(TrackType trackType, int index, ref bool isActiveTrack)
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
	}
}
