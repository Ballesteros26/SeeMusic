using System;

namespace UnityEngine
{
	public struct Ray : IFormattable
	{
		private Vector3 m_Origin;

		private Vector3 m_Direction;

		public Vector3 origin => default(Vector3);

		public Vector3 direction => default(Vector3);

		public Ray(Vector3 origin, Vector3 direction)
		{
			m_Origin = default(Vector3);
			m_Direction = default(Vector3);
		}

		public Vector3 GetPoint(float distance)
		{
			return default(Vector3);
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
}
