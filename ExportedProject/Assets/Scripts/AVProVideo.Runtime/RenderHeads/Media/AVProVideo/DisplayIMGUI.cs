using UnityEngine;
using UnityEngine.Serialization;

namespace RenderHeads.Media.AVProVideo
{
	[ExecuteInEditMode]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	[AddComponentMenu("AVPro Video/Display IMGUI", 200)]
	public class DisplayIMGUI : MonoBehaviour
	{
		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[SerializeField]
		private ScaleMode _scaleMode;

		[SerializeField]
		private Color _color;

		[FormerlySerializedAs("_alphaBlend")]
		[SerializeField]
		private bool _allowTransparency;

		[SerializeField]
		private bool _useDepth;

		[SerializeField]
		private int _depth;

		[SerializeField]
		[FormerlySerializedAs("_fullScreen")]
		[Header("Area")]
		private bool _isAreaFullScreen;

		[SerializeField]
		[Range(0f, 1f)]
		[FormerlySerializedAs("_x")]
		private float _areaX;

		[FormerlySerializedAs("_y")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _areaY;

		[SerializeField]
		[Range(0f, 1f)]
		[FormerlySerializedAs("_width")]
		private float _areaWidth;

		[Range(0f, 1f)]
		[SerializeField]
		[FormerlySerializedAs("_height")]
		private float _areaHeight;

		[SerializeField]
		[FormerlySerializedAs("_displayInEditor")]
		private bool _showAreaInEditor;

		private static Shader _shaderAlphaPacking;

		private Material _material;

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

		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool AllowTransparency
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseDepth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int Depth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsAreaFullScreen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float AreaX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AreaY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AreaWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AreaHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool ShowAreaInEditor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private Shader GetRequiredShader()
		{
			return null;
		}

		private void SetupMaterial()
		{
		}

		private void OnGUI()
		{
		}

		public Rect GetAreaRect()
		{
			return default(Rect);
		}
	}
}
