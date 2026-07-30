using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[AddComponentMenu("VFX/Property Binders/Previous Position Binder")]
	[VFXBinder("Transform/Position (Previous)")]
	internal class VFXPreviousPositionBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "UnityEngine.Vector3" })]
		[FormerlySerializedAs("m_Parameter")]
		public ExposedProperty m_Property;

		public Transform Target;

		private Vector3 oldPosition;

		protected override void OnEnable()
		{
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
