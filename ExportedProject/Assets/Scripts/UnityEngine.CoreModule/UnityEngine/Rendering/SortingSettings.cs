using System;

namespace UnityEngine.Rendering
{
	public struct SortingSettings : IEquatable<SortingSettings>
	{
		private Matrix4x4 m_WorldToCameraMatrix;

		private Vector3 m_CameraPosition;

		private Vector3 m_CustomAxis;

		private SortingCriteria m_Criteria;

		private DistanceMetric m_DistanceMetric;

		private Matrix4x4 m_PreviousVPMatrix;

		private Matrix4x4 m_NonJitteredVPMatrix;

		public Vector3 customAxis
		{
			set
			{
			}
		}

		public SortingCriteria criteria
		{
			get
			{
				return default(SortingCriteria);
			}
			set
			{
			}
		}

		public DistanceMetric distanceMetric
		{
			set
			{
			}
		}

		public SortingSettings(Camera camera)
		{
			m_WorldToCameraMatrix = default(Matrix4x4);
			m_CameraPosition = default(Vector3);
			m_CustomAxis = default(Vector3);
			m_Criteria = default(SortingCriteria);
			m_DistanceMetric = default(DistanceMetric);
			m_PreviousVPMatrix = default(Matrix4x4);
			m_NonJitteredVPMatrix = default(Matrix4x4);
		}

		public bool Equals(SortingSettings other)
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
