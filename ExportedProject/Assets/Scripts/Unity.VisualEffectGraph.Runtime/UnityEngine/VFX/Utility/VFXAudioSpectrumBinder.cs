using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[AddComponentMenu("VFX/Property Binders/Audio Spectrum Binder")]
	[VFXBinder("Audio/Audio Spectrum to AttributeMap")]
	internal class VFXAudioSpectrumBinder : VFXBinderBase
	{
		public enum AudioSourceMode
		{
			AudioSource = 0,
			AudioListener = 1
		}

		[FormerlySerializedAs("m_CountParameter")]
		[VFXPropertyBinding(new string[] { "System.UInt32" })]
		[SerializeField]
		protected ExposedProperty m_CountProperty;

		[FormerlySerializedAs("m_TextureParameter")]
		[SerializeField]
		[VFXPropertyBinding(new string[] { "UnityEngine.Texture2D" })]
		protected ExposedProperty m_TextureProperty;

		public FFTWindow FFTWindow;

		public uint Samples;

		public AudioSourceMode Mode;

		public AudioSource AudioSource;

		private Texture2D m_Texture;

		private float[] m_AudioCache;

		private Color[] m_ColorCache;

		public string CountProperty
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TextureProperty
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool IsValid(VisualEffect component)
		{
			return false;
		}

		private void UpdateTexture()
		{
		}

		public override void UpdateBinding(VisualEffect component)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
