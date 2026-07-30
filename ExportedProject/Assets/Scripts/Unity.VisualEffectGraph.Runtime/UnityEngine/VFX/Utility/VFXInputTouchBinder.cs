using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[VFXBinder("Input/Touch")]
	[AddComponentMenu("VFX/Property Binders/Input Touch Binder")]
	internal class VFXInputTouchBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "System.Boolean" })]
		[SerializeField]
		[FormerlySerializedAs("m_TouchEnabledParameter")]
		protected ExposedProperty m_TouchEnabledProperty;

		[SerializeField]
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Position", "UnityEngine.Vector3" })]
		protected ExposedProperty m_Parameter;

		[VFXPropertyBinding(new string[] { "UnityEngine.Vector3" })]
		[SerializeField]
		protected ExposedProperty m_VelocityParameter;

		public int TouchIndex;

		public Camera Target;

		public float Distance;

		public bool SetVelocity;

		private Vector3 m_PreviousPosition;

		private bool m_PreviousTouch;

		public string TouchEnabledProperty
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Parameter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string VelocityParameter
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

		private int GetTouchCount()
		{
			return 0;
		}

		private Vector2 GetTouchPosition(int touchIndex)
		{
			return default(Vector2);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
