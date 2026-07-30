using UnityEngine;
using UnityEngine.Serialization;

namespace RenderHeads.Media.AVProVideo
{
	[AddComponentMenu("AVPro Video/Apply To Mesh", 300)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public sealed class ApplyToMesh : ApplyToBase
	{
		[Tooltip("Default texture to display when the video texture is preparing")]
		[Space(8f)]
		[SerializeField]
		[Header("Display")]
		private Texture2D _defaultTexture;

		[SerializeField]
		[Header("Renderer Target")]
		[FormerlySerializedAs("_mesh")]
		[Space(8f)]
		private Renderer _renderer;

		[SerializeField]
		private int _materialIndex;

		[SerializeField]
		private string _texturePropertyName;

		[SerializeField]
		private Vector2 _offset;

		[SerializeField]
		private Vector2 _scale;

		private Texture _lastTextureApplied;

		private LazyShaderProperty _propTexture;

		public Texture2D DefaultTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Renderer MeshRenderer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int MaterialIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string TexturePropertyName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2 Offset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 Scale
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		private void ChangeDefaultTexture(Texture2D texture)
		{
		}

		private void ChangeRenderer(Renderer renderer)
		{
		}

		private void LateUpdate()
		{
		}

		public override void Apply()
		{
		}

		private void ApplyMapping(Texture texture, bool requiresYFlip, int plane, int materialIndex = -1)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
