using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class SerializableEnum
	{
		[SerializeField]
		private string m_EnumValueAsString;

		[SerializeField]
		private Type m_EnumType;

		public Enum value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SerializableEnum(Type enumType)
		{
		}
	}
}
