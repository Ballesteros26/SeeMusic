using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[VFXBinder("Utility/Plane")]
	[AddComponentMenu("VFX/Property Binders/Plane Binder")]
	internal class VFXPlaneBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Plane" })]
		[SerializeField]
		[FormerlySerializedAs("m_Parameter")]
		protected ExposedProperty m_Property;

		public Transform Target;

		private ExposedProperty Position;

		private ExposedProperty Normal;

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

		protected override void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void UpdateSubProperties()
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
