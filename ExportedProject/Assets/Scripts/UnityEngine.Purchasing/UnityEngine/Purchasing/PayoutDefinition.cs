using System;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class PayoutDefinition
	{
		[SerializeField]
		private PayoutType m_Type;

		[SerializeField]
		private string m_Subtype;

		[SerializeField]
		private double m_Quantity;

		[SerializeField]
		private string m_Data;

		private PayoutType type
		{
			set
			{
			}
		}

		private string subtype
		{
			set
			{
			}
		}

		private double quantity
		{
			set
			{
			}
		}

		private string data
		{
			set
			{
			}
		}

		public PayoutDefinition()
		{
		}

		public PayoutDefinition(string typeString, string subtype, double quantity, string data)
		{
		}
	}
}
