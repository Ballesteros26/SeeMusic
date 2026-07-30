using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	[AddComponentMenu("AVPro Video/Apply To Material", 300)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public sealed class ApplyToMaterial : ApplyToBase
	{
		[Header("Display")]
		[Space(8f)]
		[Tooltip("Default texture to display when the video texture is preparing")]
		[SerializeField]
		private Texture2D _defaultTexture;

		[Space(8f)]
		[SerializeField]
		[Header("Material Target")]
		private Material _material;

		[SerializeField]
		private string _texturePropertyName;

		[SerializeField]
		private Vector2 _offset;

		[SerializeField]
		private Vector2 _scale;

		private Texture _lastTextureApplied;

		private LazyShaderProperty _propTexture;

		private Texture _originalTexture;

		private Vector2 _originalScale;

		private Vector2 _originalOffset;

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

		public Material Material
		{
			get
			{
				return null;
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

		private void LateUpdate()
		{
		}

		public override void Apply()
		{
		}

		private void ApplyMapping(Texture texture, bool requiresYFlip, int plane = 0)
		{
		}

		protected override void SaveProperties()
		{
		}

		protected override void RestoreProperties()
		{
		}
	}
}
