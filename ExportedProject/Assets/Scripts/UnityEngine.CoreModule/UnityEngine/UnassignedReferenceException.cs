using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
	[Serializable]
	public class UnassignedReferenceException : Exception
	{
		public UnassignedReferenceException()
		{
		}

		public UnassignedReferenceException(string message)
		{
		}

		protected UnassignedReferenceException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
