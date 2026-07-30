using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UnityEngine.VFX.Utility
{
	[VFXBinder("UI/Dropdown")]
	[AddComponentMenu("VFX/Property Binders/UI Dropdown Binder")]
	internal class VFXUIDropdownBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "System.Int32" })]
		[SerializeField]
		[FormerlySerializedAs("m_Parameter")]
		protected ExposedProperty m_Property;

		public Dropdown Target;

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
