using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[VFXBinder("Transform/Velocity")]
	[AddComponentMenu("VFX/Property Binders/Velocity Binder")]
	internal class VFXVelocityBinder : VFXBinderBase
	{
		[FormerlySerializedAs("m_Parameter")]
		[SerializeField]
		[VFXPropertyBinding(new string[] { "UnityEngine.Vector3" })]
		public ExposedProperty m_Property;

		public Transform Target;

		private static readonly float invalidPreviousTime;

		private float m_PreviousTime;

		private Vector3 m_PreviousPosition;

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

		public override void Reset()
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
