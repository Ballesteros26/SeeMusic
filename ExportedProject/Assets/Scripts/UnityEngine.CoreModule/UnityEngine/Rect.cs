using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
	[NativeHeader("Runtime/Math/Rect.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	public struct Rect : IEquatable<Rect>, IFormattable
	{
		[NativeName("x")]
		private float m_XMin;

		[NativeName("y")]
		private float m_YMin;

		[NativeName("width")]
		private float m_Width;

		[NativeName("height")]
		private float m_Height;

		public static Rect zero => default(Rect);

		public float x
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float y
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 position
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 center
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 min
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 max
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float width
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float height
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 size
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float xMin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float yMin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float xMax
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float yMax
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Rect(float x, float y, float width, float height)
		{
			m_XMin = 0f;
			m_YMin = 0f;
			m_Width = 0f;
			m_Height = 0f;
		}

		public Rect(Vector2 position, Vector2 size)
		{
			m_XMin = 0f;
			m_YMin = 0f;
			m_Width = 0f;
			m_Height = 0f;
		}

		public Rect(Rect source)
		{
			m_XMin = 0f;
			m_YMin = 0f;
			m_Width = 0f;
			m_Height = 0f;
		}

		public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax)
		{
			return default(Rect);
		}

		public bool Contains(Vector2 point)
		{
			return false;
		}

		public bool Contains(Vector3 point)
		{
			return false;
		}

		private static Rect OrderMinMax(Rect rect)
		{
			return default(Rect);
		}

		public bool Overlaps(Rect other)
		{
			return false;
		}

		public bool Overlaps(Rect other, bool allowInverse)
		{
			return false;
		}

		public static Vector2 PointToNormalized(Rect rectangle, Vector2 point)
		{
			return default(Vector2);
		}

		public static bool operator !=(Rect lhs, Rect rhs)
		{
			return false;
		}

		public static bool operator ==(Rect lhs, Rect rhs)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(Rect other)
		{
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
