using System;
using System.Runtime.Serialization;

namespace Microsoft.CSharp.RuntimeBinder
{
	/// <summary>Represents an error that occurs when a dynamic bind in the C# runtime binder is processed.</summary>
	[Serializable]
	public class RuntimeBinderException : Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:Microsoft.CSharp.RuntimeBinder.RuntimeBinderException" /> class.</summary>
		public RuntimeBinderException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:Microsoft.CSharp.RuntimeBinder.RuntimeBinderException" /> class that has a specified error message.</summary>
		/// <param name="message">The message that describes the exception. The caller of this constructor is required to ensure that this string has been localized for the current system culture.</param>
		public RuntimeBinderException(string message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:Microsoft.CSharp.RuntimeBinder.RuntimeBinderException" /> class that has serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data about the exception being thrown.. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		protected RuntimeBinderException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
