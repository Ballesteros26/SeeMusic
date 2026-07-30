using System.Collections.Generic;

namespace UnityEngine.VFX.Utility
{
	[VFXBinder("Point Cache/Hierarchy to Attribute Map")]
	[AddComponentMenu("VFX/Property Binders/Hierarchy to Attribute Map Binder")]
	internal class VFXHierarchyAttributeMapBinder : VFXBinderBase
	{
		public enum RadiusMode
		{
			Fixed = 0,
			Interpolate = 1
		}

		private struct Bone
		{
			public Transform source;

			public float sourceRadius;

			public Transform target;

			public float targetRadius;
		}

		[VFXPropertyBinding(new string[] { "System.UInt32" })]
		[SerializeField]
		protected ExposedProperty m_BoneCount;

		[VFXPropertyBinding(new string[] { "UnityEngine.Texture2D" })]
		[SerializeField]
		protected ExposedProperty m_PositionMap;

		[SerializeField]
		[VFXPropertyBinding(new string[] { "UnityEngine.Texture2D" })]
		protected ExposedProperty m_TargetPositionMap;

		[VFXPropertyBinding(new string[] { "UnityEngine.Texture2D" })]
		[SerializeField]
		protected ExposedProperty m_RadiusPositionMap;

		public Transform HierarchyRoot;

		public float DefaultRadius;

		public uint MaximumDepth;

		public RadiusMode Radius;

		private Texture2D position;

		private Texture2D targetPosition;

		private Texture2D radius;

		private List<Bone> bones;

		protected override void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void UpdateHierarchy()
		{
		}

		private List<Bone> ChildrenOf(Transform source, uint depth)
		{
			return null;
		}

		private void UpdateData()
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
