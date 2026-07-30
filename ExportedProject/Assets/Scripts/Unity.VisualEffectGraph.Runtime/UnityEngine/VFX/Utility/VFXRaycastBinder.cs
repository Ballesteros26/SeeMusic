namespace UnityEngine.VFX.Utility
{
	[VFXBinder("Physics/Raycast")]
	[AddComponentMenu("VFX/Property Binders/Raycast Binder")]
	internal class VFXRaycastBinder : VFXBinderBase
	{
		public enum Space
		{
			Local = 0,
			World = 1
		}

		[SerializeField]
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Position" })]
		protected ExposedProperty m_TargetPosition;

		[SerializeField]
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.DirectionType" })]
		protected ExposedProperty m_TargetNormal;

		[SerializeField]
		[VFXPropertyBinding(new string[] { "System.Boolean" })]
		protected ExposedProperty m_TargetHit;

		protected ExposedProperty m_TargetPosition_position;

		protected ExposedProperty m_TargetNormal_direction;

		public GameObject RaycastSource;

		public Vector3 RaycastDirection;

		public Space RaycastDirectionSpace;

		public LayerMask Layers;

		public float MaxDistance;

		private RaycastHit m_HitInfo;

		public string TargetPosition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TargetNormal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TargetHit
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
