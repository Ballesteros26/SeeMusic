using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[VFXBinder("Input/Button")]
	[AddComponentMenu("VFX/Property Binders/Input Button Binder")]
	internal class VFXInputButtonBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "System.Boolean" })]
		[SerializeField]
		[FormerlySerializedAs("m_ButtonParameter")]
		protected ExposedProperty m_ButtonProperty;

		[VFXPropertyBinding(new string[] { "System.Single" })]
		[SerializeField]
		[FormerlySerializedAs("m_ButtonSmoothParameter")]
		protected ExposedProperty m_ButtonSmoothProperty;

		public string ButtonName;

		public float SmoothSpeed;

		public bool UseButtonSmooth;

		private float m_CachedSmoothValue;

		public string ButtonProperty
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ButtonSmoothProperty
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

		private void Start()
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
