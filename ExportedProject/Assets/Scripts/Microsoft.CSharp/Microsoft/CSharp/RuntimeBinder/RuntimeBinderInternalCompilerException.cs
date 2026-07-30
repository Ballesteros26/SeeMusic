using System;
using System.Runtime.Serialization;

namespace Microsoft.CSharp.RuntimeBinder
{
	/// <summary>Represents an error that occurs when a dynamic bind in the C# runtime binder is processed.</summary>
	[Serializable]
	public class RuntimeBinderInternalCompilerException : Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:Microsoft.CSharp.RuntimeBinder.RuntimeBinderInternalCompilerException" /> class with a system-supplied message that describes the error.</summary>
		public RuntimeBinderInternalCompilerException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:Microsoft.CSharp.RuntimeBinder.RuntimeBinderInternalCompilerException" /> class with a specified message that describes the error.</summary>
		/// <param name="message">The message that describes the exception. The caller of this constructor is required to ensure that this string has been localized for the current system culture.</param>
		public RuntimeBinderInternalCompilerException(string message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:Microsoft.CSharp.RuntimeBinder.RuntimeBinderInternalCompilerException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
		protected RuntimeBinderInternalCompilerException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
