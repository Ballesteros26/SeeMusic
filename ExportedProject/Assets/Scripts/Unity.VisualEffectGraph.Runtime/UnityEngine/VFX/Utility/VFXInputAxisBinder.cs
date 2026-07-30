using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[VFXBinder("Input/Axis")]
	[AddComponentMenu("VFX/Property Binders/Input Axis Binder")]
	internal class VFXInputAxisBinder : VFXBinderBase
	{
		[SerializeField]
		[FormerlySerializedAs("m_AxisParameter")]
		[VFXPropertyBinding(new string[] { "System.Single" })]
		protected ExposedProperty m_AxisProperty;

		public string AxisName;

		public float AccumulateSpeed;

		public bool Accumulate;

		public string AxisProperty
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
