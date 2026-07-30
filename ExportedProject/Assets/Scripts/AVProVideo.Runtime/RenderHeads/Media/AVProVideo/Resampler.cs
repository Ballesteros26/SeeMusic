using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public class Resampler
	{
		private class TimestampedRenderTexture
		{
			public RenderTexture texture;

			public long timestamp;

			public bool used;
		}

		public enum ResampleMode
		{
			POINT = 0,
			LINEAR = 1
		}

		private List<TimestampedRenderTexture[]> _buffer;

		private MediaPlayer _mediaPlayer;

		private RenderTexture[] _outputTexture;

		private int _start;

		private int _end;

		private int _bufferSize;

		private long _baseTimestamp;

		private float _elapsedTimeSinceBase;

		private Material _blendMat;

		private ResampleMode _resampleMode;

		private string _name;

		private long _lastTimeStamp;

		private int _droppedFrames;

		private long _lastDisplayedTimestamp;

		private int _frameDisplayedTimer;

		private long _currentDisplayedTimestamp;

		private const string ShaderPropT = "_t";

		private const string ShaderPropAftertex = "_AfterTex";

		private int _propAfterTex;

		private int _propT;

		private float _videoFrameRate;

		public int DroppedFrames => 0;

		public int FrameDisplayedTimer => 0;

		public long BaseTimestamp
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public float ElapsedTimeSinceBase
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float LastT { get; private set; }

		public long TextureTimeStamp { get; private set; }

		public Texture[] OutputTexture => null;

		public void OnVideoEvent(MediaPlayer mp, MediaPlayerEvent.EventType et, ErrorCode errorCode)
		{
		}

		public Resampler(MediaPlayer player, string name, int bufferSize = 2, ResampleMode resampleMode = ResampleMode.LINEAR)
		{
		}

		public void Reset()
		{
		}

		public void Release()
		{
		}

		private void ReleaseRenderTextures()
		{
		}

		private void ConstructRenderTextures()
		{
		}

		private bool CheckRenderTexturesValid()
		{
			return false;
		}

		private int FindBeforeFrameIndex(int frameIdx)
		{
			return 0;
		}

		private int FindClosestFrame(int frameIdx)
		{
			return 0;
		}

		private void PointUpdate()
		{
		}

		private void SampleFrame(int frameIdx, int bufferIdx)
		{
		}

		private void SampleFrames(int bufferIdx, int frameIdx1, int frameIdx2, float t)
		{
		}

		private void LinearUpdate()
		{
		}

		private void InvalidateBuffer()
		{
		}

		private float GuessFrameRate()
		{
			return 0f;
		}

		public void Update()
		{
		}

		public void UpdateTimestamp()
		{
		}
	}
}
