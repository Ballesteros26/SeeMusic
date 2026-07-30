using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[VFXBinder("Transform/Transform")]
	[AddComponentMenu("VFX/Property Binders/Transform Binder")]
	internal class VFXTransformBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Transform" })]
		[SerializeField]
		[FormerlySerializedAs("m_Parameter")]
		protected ExposedProperty m_Property;

		public Transform Target;

		private ExposedProperty Position;

		private ExposedProperty Angles;

		private ExposedProperty Scale;

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
