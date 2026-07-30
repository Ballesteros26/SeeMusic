using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[AddComponentMenu("VFX/Property Binders/Sphere Collider Binder")]
	[VFXBinder("Collider/Sphere")]
	internal class VFXSphereBinder : VFXBinderBase
	{
		[SerializeField]
		[FormerlySerializedAs("m_Parameter")]
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Sphere", "UnityEditor.VFX.TSphere" })]
		protected ExposedProperty m_Property;

		public SphereCollider Target;

		private ExposedProperty m_Old_Center;

		private ExposedProperty m_New_Center;

		private ExposedProperty m_Radius;

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

		public float GetSphereColliderScale(Vector3 scale)
		{
			return 0f;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
