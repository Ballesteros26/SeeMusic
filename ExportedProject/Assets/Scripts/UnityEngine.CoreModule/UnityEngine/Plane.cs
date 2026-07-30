using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	public struct Plane : IFormattable
	{
		internal const int size = 16;

		private Vector3 m_Normal;

		private float m_Distance;

		public Vector3 normal => default(Vector3);

		public float distance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Plane(Vector3 inNormal, Vector3 inPoint)
		{
			m_Normal = default(Vector3);
			m_Distance = 0f;
		}

		public bool Raycast(Ray ray, out float enter)
		{
			enter = default(float);
			return false;
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
