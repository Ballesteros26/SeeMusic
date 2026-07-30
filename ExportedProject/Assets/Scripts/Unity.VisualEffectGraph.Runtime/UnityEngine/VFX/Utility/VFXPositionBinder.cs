using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[VFXBinder("Transform/Position")]
	[AddComponentMenu("VFX/Property Binders/Position Binder")]
	internal class VFXPositionBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Position", "UnityEngine.Vector3" })]
		[FormerlySerializedAs("m_Parameter")]
		[SerializeField]
		protected ExposedProperty m_Property;

		public Transform Target;

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
