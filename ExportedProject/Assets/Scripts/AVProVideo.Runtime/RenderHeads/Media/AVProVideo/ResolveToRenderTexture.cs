using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	[AddComponentMenu("AVPro Video/Resolve To RenderTexture", 330)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class ResolveToRenderTexture : MonoBehaviour
	{
		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[SerializeField]
		private VideoResolveOptions _options;

		[SerializeField]
		private VideoRender.ResolveFlags _resolveFlags;

		[SerializeField]
		private RenderTexture _externalTexture;

		private Material _materialResolve;

		private bool _isMaterialSetup;

		private bool _isMaterialDirty;

		private bool _isMaterialOES;

		private RenderTexture _internalTexture;

		private int _textureFrameCount;

		private Material _materialBlit;

		private int _srcTexId;

		public MediaPlayer MediaPlayer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VideoResolveOptions VideoResolveOptions
		{
			get
			{
				return default(VideoResolveOptions);
			}
			set
			{
			}
		}

		public RenderTexture ExternalTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RenderTexture TargetTexture => null;

		public void SetMaterialDirty()
		{
		}

		private void ChangeMediaPlayer(MediaPlayer mediaPlayer)
		{
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public void Resolve()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
