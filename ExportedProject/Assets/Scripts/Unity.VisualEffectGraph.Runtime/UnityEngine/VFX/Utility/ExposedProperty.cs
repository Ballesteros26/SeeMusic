using System;

namespace UnityEngine.VFX.Utility
{
	[Serializable]
	public class ExposedProperty
	{
		[SerializeField]
		private string m_Name;

		private int m_Id;

		public static implicit operator ExposedProperty(string name)
		{
			return null;
		}

		public static explicit operator string(ExposedProperty parameter)
		{
			return null;
		}

		public static implicit operator int(ExposedProperty parameter)
		{
			return 0;
		}

		public static ExposedProperty operator +(ExposedProperty self, ExposedProperty other)
		{
			return null;
		}

		public ExposedProperty()
		{
		}

		private ExposedProperty(string name)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
