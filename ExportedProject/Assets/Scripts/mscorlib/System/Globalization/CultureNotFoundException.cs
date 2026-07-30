using System.Runtime.Serialization;

namespace System.Globalization
{
	/// <summary>The exception thrown when a method is invoked which attempts to construct a culture that is not available on the machine.</summary>
	[Serializable]
	public class CultureNotFoundException : ArgumentException
	{
		private string _invalidCultureName;

		private int? _invalidCultureId;

		/// <summary>Gets the Culture ID that cannot be found.</summary>
		/// <returns>The invalid Culture ID.</returns>
		public virtual int? InvalidCultureId => null;

		/// <summary>Gets the Culture Name that cannot be found.</summary>
		/// <returns>The invalid Culture Name.</returns>
		public virtual string InvalidCultureName => null;

		private static string DefaultMessage => null;

		private string FormatedInvalidCultureId => null;

		/// <summary>Gets the error message that explains the reason for the exception.</summary>
		/// <returns>A text string describing the details of the exception.</returns>
		public override string Message => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureNotFoundException" /> class with its message string set to a system-supplied message.</summary>
		public CultureNotFoundException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureNotFoundException" /> class with a specified error message and the name of the parameter that is the cause this exception.</summary>
		/// <param name="paramName">The name of the parameter that is the cause of the current exception.</param>
		/// <param name="message">The error message to display with this exception.</param>
		public CultureNotFoundException(string paramName, string message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureNotFoundException" /> class using the specified serialization data and context.</summary>
		/// <param name="info">The object that holds the serialized object data.</param>
		/// <param name="context">The contextual information about the source or destination.</param>
		protected CultureNotFoundException(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the parameter name and additional exception information.</summary>
		/// <param name="info">The object that holds the serialized object data.</param>
		/// <param name="context">The contextual information about the source or destination.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null.</exception>
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
