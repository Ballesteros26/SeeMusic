using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[VFXBinder("GameObject/Enabled")]
	[AddComponentMenu("VFX/Property Binders/Enabled Binder")]
	internal class VFXEnabledBinder : VFXBinderBase
	{
		public enum Check
		{
			ActiveInHierarchy = 0,
			ActiveSelf = 1
		}

		public Check check;

		[SerializeField]
		[FormerlySerializedAs("m_Parameter")]
		[VFXPropertyBinding(new string[] { "System.Boolean" })]
		protected ExposedProperty m_Property;

		public GameObject Target;

		public string Property
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
