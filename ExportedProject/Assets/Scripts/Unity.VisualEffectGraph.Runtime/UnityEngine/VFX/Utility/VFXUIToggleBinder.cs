using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UnityEngine.VFX.Utility
{
	[VFXBinder("UI/Toggle")]
	[AddComponentMenu("VFX/Property Binders/UI Toggle Binder")]
	internal class VFXUIToggleBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "System.Boolean" })]
		[SerializeField]
		[FormerlySerializedAs("m_Parameter")]
		protected ExposedProperty m_Property;

		public Toggle Target;

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
