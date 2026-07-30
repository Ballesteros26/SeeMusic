using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[UsedByNativeCode]
	public struct VisibleReflectionProbe : IEquatable<VisibleReflectionProbe>
	{
		private Bounds m_Bounds;

		private Matrix4x4 m_LocalToWorldMatrix;

		private Vector4 m_HdrData;

		private Vector3 m_Center;

		private float m_BlendDistance;

		private int m_Importance;

		private int m_BoxProjection;

		private int m_InstanceId;

		private int m_TextureId;

		public bool Equals(VisibleReflectionProbe other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
