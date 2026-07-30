using System;
using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	[AddComponentMenu("AVPro Video/Playlist Media Player (BETA)", -80)]
	public class PlaylistMediaPlayer : MediaPlayer, ITextureProducer
	{
		public enum Transition
		{
			None = 0,
			Fade = 1,
			Black = 2,
			White = 3,
			Transparent = 4,
			Horiz = 5,
			Vert = 6,
			Diag = 7,
			MirrorH = 8,
			MirrorV = 9,
			MirrorD = 10,
			ScrollV = 11,
			ScrollH = 12,
			Circle = 13,
			Diamond = 14,
			Blinds = 15,
			Arrows = 16,
			SlideH = 17,
			SlideV = 18,
			Zoom = 19,
			RectV = 20,
			Random = 21
		}

		public enum PlaylistLoopMode
		{
			None = 0,
			Loop = 1
		}

		public enum StartMode
		{
			Immediate = 0,
			Manual = 1
		}

		public enum ProgressMode
		{
			OnFinish = 0,
			BeforeFinish = 1,
			Manual = 2
		}

		[Serializable]
		public class Easing
		{
			public enum Preset
			{
				Step = 0,
				Linear = 1,
				InQuad = 2,
				OutQuad = 3,
				InOutQuad = 4,
				InCubic = 5,
				OutCubic = 6,
				InOutCubic = 7,
				InQuint = 8,
				OutQuint = 9,
				InOutQuint = 10,
				InQuart = 11,
				OutQuart = 12,
				InOutQuart = 13,
				InExpo = 14,
				OutExpo = 15,
				InOutExpo = 16,
				Random = 17,
				RandomNotStep = 18
			}

			public Preset preset;

			public static Func<float, float> GetFunction(Preset preset)
			{
				return null;
			}

			public static float PowerEaseIn(float t, float power)
			{
				return 0f;
			}

			public static float PowerEaseOut(float t, float power)
			{
				return 0f;
			}

			public static float PowerEaseInOut(float t, float power)
			{
				return 0f;
			}

			public static float Step(float t)
			{
				return 0f;
			}

			public static float Linear(float t)
			{
				return 0f;
			}

			public static float InQuad(float t)
			{
				return 0f;
			}

			public static float OutQuad(float t)
			{
				return 0f;
			}

			public static float InOutQuad(float t)
			{
				return 0f;
			}

			public static float InCubic(float t)
			{
				return 0f;
			}

			public static float OutCubic(float t)
			{
				return 0f;
			}

			public static float InOutCubic(float t)
			{
				return 0f;
			}

			public static float InQuart(float t)
			{
				return 0f;
			}

			public static float OutQuart(float t)
			{
				return 0f;
			}

			public static float InOutQuart(float t)
			{
				return 0f;
			}

			public static float InQuint(float t)
			{
				return 0f;
			}

			public static float OutQuint(float t)
			{
				return 0f;
			}

			public static float InOutQuint(float t)
			{
				return 0f;
			}

			public static float InExpo(float t)
			{
				return 0f;
			}

			public static float OutExpo(float t)
			{
				return 0f;
			}

			public static float InOutExpo(float t)
			{
				return 0f;
			}
		}

		[SerializeField]
		private Shader _transitionShader;

		[SerializeField]
		private MediaPlayer _playerA;

		[SerializeField]
		private MediaPlayer _playerB;

		[SerializeField]
		private bool _playlistAutoProgress;

		[Tooltip("Close the video on the other MediaPlayer when it is not visible any more.  This is useful for freeing up memory and GPU decoding resources.")]
		[SerializeField]
		private bool _autoCloseVideo;

		[SerializeField]
		private PlaylistLoopMode _playlistLoopMode;

		[SerializeField]
		private MediaPlaylist _playlist;

		[Tooltip("Pause the previously playing video. This is useful for systems that will struggle to play 2 videos at once")]
		[SerializeField]
		private bool _pausePreviousOnTransition;

		[SerializeField]
		private Transition _defaultTransition;

		[SerializeField]
		private float _defaultTransitionDuration;

		[SerializeField]
		private Easing.Preset _defaultTransitionEasing;

		private static readonly LazyShaderProperty PropFromTex;

		private static readonly LazyShaderProperty PropFade;

		private bool _isPaused;

		private int _playlistIndex;

		private MediaPlayer _nextPlayer;

		private Material _material;

		private Transition _currentTransition;

		private string _currentTransitionName;

		private float _currentTransitionDuration;

		private Easing.Preset _currentTransitionEasing;

		private float _textureTimer;

		private float _transitionTimer;

		private Func<float, float> _easeFunc;

		private RenderTexture _rt;

		private MediaPlaylist.MediaItem _currentItem;

		private MediaPlaylist.MediaItem _nextItem;

		[SerializeField]
		[Range(0f, 1f)]
		private float _playlistAudioVolume;

		[SerializeField]
		private bool _playlistAudioMuted;

		public MediaPlayer CurrentPlayer => null;

		public MediaPlayer NextPlayer => null;

		public MediaPlaylist Playlist => null;

		public int PlaylistIndex => 0;

		public MediaPlaylist.MediaItem PlaylistItem => null;

		public Transition DefaultTransition
		{
			get
			{
				return default(Transition);
			}
			set
			{
			}
		}

		public float DefaultTransitionDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Easing.Preset DefaultTransitionEasing
		{
			get
			{
				return default(Easing.Preset);
			}
			set
			{
			}
		}

		public bool AutoCloseVideo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public PlaylistLoopMode LoopMode
		{
			get
			{
				return default(PlaylistLoopMode);
			}
			set
			{
			}
		}

		public bool AutoProgress
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override IMediaInfo Info => null;

		public override IMediaControl Control => null;

		public override ITextureProducer TextureProducer => null;

		public override float AudioVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override bool AudioMuted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override void Play()
		{
		}

		public override void Pause()
		{
		}

		public bool IsPaused()
		{
			return false;
		}

		private void SwapPlayers()
		{
		}

		private Texture GetCurrentTexture()
		{
			return null;
		}

		private Texture GetNextTexture()
		{
			return null;
		}

		private void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void Start()
		{
		}

		public void OnVideoEvent(MediaPlayer mp, MediaPlayerEvent.EventType et, ErrorCode errorCode)
		{
		}

		public bool PrevItem()
		{
			return false;
		}

		public bool NextItem()
		{
			return false;
		}

		public bool CanJumpToItem(int index)
		{
			return false;
		}

		public bool JumpToItem(int index)
		{
			return false;
		}

		public void OpenVideoFile(MediaPlaylist.MediaItem mediaItem)
		{
		}

		private bool IsTransitioning()
		{
			return false;
		}

		private void SetTransition(Transition transition, float duration, Easing.Preset easing)
		{
		}

		protected override void Update()
		{
		}

		public Texture GetTexture(int index = 0)
		{
			return null;
		}

		public int GetTextureCount()
		{
			return 0;
		}

		public int GetTextureFrameCount()
		{
			return 0;
		}

		public bool SupportsTextureFrameCount()
		{
			return false;
		}

		public long GetTextureTimeStamp()
		{
			return 0L;
		}

		public float GetTexturePixelAspectRatio()
		{
			return 0f;
		}

		public bool RequiresVerticalFlip()
		{
			return false;
		}

		public Matrix4x4 GetYpCbCrTransform()
		{
			return default(Matrix4x4);
		}

		public StereoPacking GetTextureStereoPacking()
		{
			return default(StereoPacking);
		}

		public TransparencyMode GetTextureTransparency()
		{
			return default(TransparencyMode);
		}

		public AlphaPacking GetTextureAlphaPacking()
		{
			return default(AlphaPacking);
		}

		public float[] GetAffineTransform()
		{
			return null;
		}

		public Matrix4x4 GetTextureMatrix()
		{
			return default(Matrix4x4);
		}

		private static string GetTransitionName(Transition transition)
		{
			return null;
		}
	}
}
