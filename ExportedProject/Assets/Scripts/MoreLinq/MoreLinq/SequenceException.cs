using System;
using System.Runtime.Serialization;

namespace MoreLinq
{
	[Serializable]
	public class SequenceException : Exception
	{
		public SequenceException()
		{
		}

		public SequenceException(string message)
		{
		}

		public SequenceException(string message, Exception innerException)
		{
		}

		protected SequenceException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
