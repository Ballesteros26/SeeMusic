using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	public struct RectInt : IEquatable<RectInt>, IFormattable
	{
		private int m_XMin;

		private int m_YMin;

		private int m_Width;

		private int m_Height;

		public int x
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int y
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Vector2 center => default(Vector2);

		public Vector2Int max => default(Vector2Int);

		public int width
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int height
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int xMin => 0;

		public int yMin => 0;

		public int xMax => 0;

		public int yMax => 0;

		public Vector2Int size => default(Vector2Int);

		public RectInt(int xMin, int yMin, int width, int height)
		{
			m_XMin = 0;
			m_YMin = 0;
			m_Width = 0;
			m_Height = 0;
		}

		public bool Overlaps(RectInt other)
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

		public bool Equals(RectInt other)
		{
			return false;
		}
	}
}
