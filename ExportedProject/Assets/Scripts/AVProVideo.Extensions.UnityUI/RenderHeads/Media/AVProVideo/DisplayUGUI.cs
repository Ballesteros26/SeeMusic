using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace RenderHeads.Media.AVProVideo
{
	[HelpURL("http://renderheads.com/products/avpro-video/")]
	[AddComponentMenu("AVPro Video/Display uGUI", 200)]
	public class DisplayUGUI : MaskableGraphic
	{
		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[Tooltip("Default texture to display when the video texture is preparing")]
		[SerializeField]
		private Texture _defaultTexture;

		[SerializeField]
		[FormerlySerializedAs("m_UVRect")]
		private Rect _uvRect;

		[SerializeField]
		private bool _setNativeSize;

		[SerializeField]
		private ScaleMode _scaleMode;

		[SerializeField]
		private bool _noDefaultDisplay;

		[SerializeField]
		private bool _displayInEditor;

		private int _lastWidth;

		private int _lastHeight;

		private Orientation _lastOrientation;

		private bool _flipY;

		private Texture _lastTexture;

		private static Shader _shaderStereoPacking;

		private static Shader _shaderAlphaPacking;

		private static Shader _shaderAndroidOES;

		private static Shader _shaderAndroidOESAlphaPacking;

		private bool _isUserMaterial;

		private Material _material;

		private List<UIVertex> _vertices;

		private static List<int> QuadIndices;

		public MediaPlayer Player
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture DefaultTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Rect UVRect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public bool ApplyNativeSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ScaleMode ScaleMode
		{
			get
			{
				return default(ScaleMode);
			}
			set
			{
			}
		}

		public bool NoDefaultDisplay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DisplayInEditor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override Texture mainTexture => null;

		public MediaPlayer CurrentMediaPlayer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Rect uvRect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private void OnMediaPlayerEvent(MediaPlayer mp, MediaPlayerEvent.EventType et, ErrorCode errorCode)
		{
		}

		private void ChangeMediaPlayer(MediaPlayer player)
		{
		}

		private static Shader EnsureShader(Shader shader, string name)
		{
			return null;
		}

		private static Shader EnsureAlphaPackingShader()
		{
			return null;
		}

		private static Shader EnsureStereoPackingShader()
		{
			return null;
		}

		private Shader EnsureAndroidOESShader()
		{
			return null;
		}

		private static Shader EnsureAndroidOESAlphaPackingShader()
		{
			return null;
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private Shader GetRequiredShader()
		{
			return null;
		}

		public bool HasValidTexture()
		{
			return false;
		}

		private void UpdateInternalMaterial()
		{
		}

		private void LateUpdate()
		{
		}

		[ContextMenu("Set Native Size")]
		public override void SetNativeSize()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		private void _OnFillVBO(List<UIVertex> vbo)
		{
		}

		private Vector4 GetDrawingDimensions(ScaleMode scaleMode, ref Rect uvRect)
		{
			return default(Vector4);
		}
	}
}
