using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[VFXBinder("Input/Mouse")]
	[AddComponentMenu("VFX/Property Binders/Input Mouse Binder")]
	internal class VFXInputMouseBinder : VFXBinderBase
	{
		[SerializeField]
		[FormerlySerializedAs("m_MouseLeftClickParameter")]
		[VFXPropertyBinding(new string[] { "System.Boolean" })]
		protected ExposedProperty m_MouseLeftClickProperty;

		[VFXPropertyBinding(new string[] { "System.Boolean" })]
		[SerializeField]
		[FormerlySerializedAs("m_MouseRightClickParameter")]
		protected ExposedProperty m_MouseRightClickProperty;

		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Position", "UnityEngine.Vector3" })]
		[SerializeField]
		[FormerlySerializedAs("m_PositionParameter")]
		protected ExposedProperty m_PositionProperty;

		[VFXPropertyBinding(new string[] { "UnityEngine.Vector3" })]
		[SerializeField]
		[FormerlySerializedAs("m_VelocityParameter")]
		protected ExposedProperty m_VelocityProperty;

		public Camera Target;

		public float Distance;

		public bool SetVelocity;

		public bool CheckLeftClick;

		public bool CheckRightClick;

		private Vector3 m_PreviousPosition;

		public string MouseLeftClickProperty
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string MouseRightClickProperty
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PositionProperty
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string VelocityProperty
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

		private bool IsRightClickPressed()
		{
			return false;
		}

		private bool IsLeftClickPressed()
		{
			return false;
		}

		private Vector2 GetMousePosition()
		{
			return default(Vector2);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
