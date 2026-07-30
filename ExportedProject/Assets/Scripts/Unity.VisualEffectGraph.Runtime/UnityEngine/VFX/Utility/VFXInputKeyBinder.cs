using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[AddComponentMenu("VFX/Property Binders/Input Key Press Binder")]
	[VFXBinder("Input/Key")]
	internal class VFXInputKeyBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "System.Boolean" })]
		[SerializeField]
		[FormerlySerializedAs("m_KeyParameter")]
		protected ExposedProperty m_KeyProperty;

		[SerializeField]
		[FormerlySerializedAs("m_KeySmoothParameter")]
		[VFXPropertyBinding(new string[] { "System.Single" })]
		protected ExposedProperty m_KeySmoothProperty;

		public KeyCode Key;

		public float SmoothSpeed;

		public bool UseKeySmooth;

		private float m_CachedSmoothValue;

		public string KeyProperty
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string KeySmoothProperty
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
