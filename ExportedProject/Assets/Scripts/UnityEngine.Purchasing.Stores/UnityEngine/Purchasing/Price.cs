using System;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class Price : ISerializationCallbackReceiver
	{
		public decimal value;

		[SerializeField]
		private int[] data;

		[SerializeField]
		private double num;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
