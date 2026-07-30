using UnityEngine;

namespace AdvancedColorPicker
{
	[ExecuteInEditMode]
	public abstract class GraphicalColorTypeComponent : GraphicalColorComponent
	{
		[SerializeField]
		private JEFPJABADEA valueType1;

		[SerializeField]
		private JEFPJABADEA valueType2;

		[SerializeField]
		private JEFPJABADEA valueType3;

		[SerializeField]
		private float fixedValue2;

		[SerializeField]
		private float fixedValue3;

		public JEFPJABADEA RangeType
		{
			get
			{
				return default(JEFPJABADEA);
			}
			set
			{
			}
		}

		public JEFPJABADEA ValueType1
		{
			get
			{
				return default(JEFPJABADEA);
			}
			set
			{
			}
		}

		public JEFPJABADEA ValueType2
		{
			get
			{
				return default(JEFPJABADEA);
			}
			set
			{
			}
		}

		public JEFPJABADEA ValueType3
		{
			get
			{
				return default(JEFPJABADEA);
			}
			set
			{
			}
		}

		public float FixedValue2
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float FixedValue3
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float GetValue1()
		{
			return 0f;
		}

		public virtual float GetValue2()
		{
			return 0f;
		}

		private static JEFPJABADEA FFGNKAECMPH(JEFPJABADEA GFMIKEPFCLG)
		{
			return default(JEFPJABADEA);
		}

		public static bool CalculateNewValue(JEFPJABADEA KGPHGEJFOIJ, ref JEFPJABADEA EDHCEALMMPM, ref JEFPJABADEA FOAEDBFBIEK, ref JEFPJABADEA JDNNPOJPIIK)
		{
			return false;
		}

		public virtual float GetValue3()
		{
			return 0f;
		}
	}
}
