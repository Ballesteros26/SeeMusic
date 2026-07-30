using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
	[Serializable]
	public class MissingReferenceException : Exception
	{
		public MissingReferenceException()
		{
		}

		protected MissingReferenceException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
