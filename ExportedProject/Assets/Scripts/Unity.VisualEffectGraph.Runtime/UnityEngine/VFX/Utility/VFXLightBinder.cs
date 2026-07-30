using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[VFXBinder("Utility/Light")]
	[AddComponentMenu("VFX/Property Binders/Light Binder")]
	internal class VFXLightBinder : VFXBinderBase
	{
		[SerializeField]
		[VFXPropertyBinding(new string[] { "UnityEngine.Color" })]
		[FormerlySerializedAs("m_ColorParameter")]
		protected ExposedProperty m_ColorProperty;

		[VFXPropertyBinding(new string[] { "System.Single" })]
		[SerializeField]
		[FormerlySerializedAs("m_BrightnessParameter")]
		protected ExposedProperty m_BrightnessProperty;

		[SerializeField]
		[FormerlySerializedAs("m_RadiusParameter")]
		[VFXPropertyBinding(new string[] { "System.Single" })]
		protected ExposedProperty m_RadiusProperty;

		public Light Target;

		public bool BindColor;

		public bool BindBrightness;

		public bool BindRadius;

		public string ColorProperty
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string BrightnessProperty
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string RadiusProperty
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

		public override void UpdateBinding(VisualEffect component)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
