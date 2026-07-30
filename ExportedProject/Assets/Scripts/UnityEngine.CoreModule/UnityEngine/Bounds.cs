using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeClass("AABB")]
	[NativeHeader("Runtime/Geometry/Intersection.h")]
	[NativeHeader("Runtime/Geometry/Ray.h")]
	[NativeType(Header = "Runtime/Geometry/AABB.h")]
	[NativeHeader("Runtime/Geometry/AABB.h")]
	public struct Bounds : IEquatable<Bounds>, IFormattable
	{
		private Vector3 m_Center;

		[NativeName("m_Extent")]
		private Vector3 m_Extents;

		public Vector3 center
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 extents
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 min
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 max
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Bounds(Vector3 center, Vector3 size)
		{
			m_Center = default(Vector3);
			m_Extents = default(Vector3);
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(Bounds other)
		{
			return false;
		}

		public static bool operator ==(Bounds lhs, Bounds rhs)
		{
			return false;
		}

		public static bool operator !=(Bounds lhs, Bounds rhs)
		{
			return false;
		}

		public void SetMinMax(Vector3 min, Vector3 max)
		{
		}

		public void Encapsulate(Vector3 point)
		{
		}

		public void Encapsulate(Bounds bounds)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[FreeFunction("BoundsScripting::SqrDistance", HasExplicitThis = true, IsThreadSafe = true)]
		public float SqrDistance(Vector3 point)
		{
			return 0f;
		}

		private static float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point)
		{
			return 0f;
		}
	}
}
