using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore
{
	[Serializable]
	[UsedByNativeCode]
	public struct FaceInfo
	{
		[SerializeField]
		[NativeName("faceIndex")]
		private int m_FaceIndex;

		[SerializeField]
		[NativeName("familyName")]
		private string m_FamilyName;

		[NativeName("styleName")]
		[SerializeField]
		private string m_StyleName;

		[NativeName("pointSize")]
		[SerializeField]
		private int m_PointSize;

		[SerializeField]
		[NativeName("scale")]
		private float m_Scale;

		[NativeName("unitsPerEM")]
		[SerializeField]
		private int m_UnitsPerEM;

		[SerializeField]
		[NativeName("lineHeight")]
		private float m_LineHeight;

		[NativeName("ascentLine")]
		[SerializeField]
		private float m_AscentLine;

		[NativeName("capLine")]
		[SerializeField]
		private float m_CapLine;

		[NativeName("meanLine")]
		[SerializeField]
		private float m_MeanLine;

		[SerializeField]
		[NativeName("baseline")]
		private float m_Baseline;

		[SerializeField]
		[NativeName("descentLine")]
		private float m_DescentLine;

		[NativeName("superscriptOffset")]
		[SerializeField]
		private float m_SuperscriptOffset;

		[NativeName("superscriptSize")]
		[SerializeField]
		private float m_SuperscriptSize;

		[NativeName("subscriptOffset")]
		[SerializeField]
		private float m_SubscriptOffset;

		[SerializeField]
		[NativeName("subscriptSize")]
		private float m_SubscriptSize;

		[SerializeField]
		[NativeName("underlineOffset")]
		private float m_UnderlineOffset;

		[NativeName("underlineThickness")]
		[SerializeField]
		private float m_UnderlineThickness;

		[NativeName("strikethroughOffset")]
		[SerializeField]
		private float m_StrikethroughOffset;

		[NativeName("strikethroughThickness")]
		[SerializeField]
		private float m_StrikethroughThickness;

		[SerializeField]
		[NativeName("tabWidth")]
		private float m_TabWidth;

		internal int faceIndex => 0;

		public string familyName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string styleName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int pointSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float lineHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ascentLine
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float capLine
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float meanLine
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float baseline
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float descentLine
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float superscriptOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float superscriptSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float subscriptOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float subscriptSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float underlineOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float underlineThickness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float strikethroughOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float strikethroughThickness
		{
			set
			{
			}
		}

		public float tabWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
