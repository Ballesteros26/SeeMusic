using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	/// <summary>Represents a warning value used by the Warning header.</summary>
	public class WarningHeaderValue : ICloneable
	{
		/// <summary>Gets the host that attached the warning.</summary>
		/// <returns>Returns <see cref="T:System.String" />.The host that attached the warning.</returns>
		public string Agent { get; private set; }

		/// <summary>Gets the specific warning code.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.The specific warning code.</returns>
		public int Code { get; private set; }

		/// <summary>Gets the date/time stamp of the warning.</summary>
		/// <returns>Returns <see cref="T:System.DateTimeOffset" />.The date/time stamp of the warning.</returns>
		public DateTimeOffset? Date { get; private set; }

		/// <summary>Gets a quoted-string containing the warning text.</summary>
		/// <returns>Returns <see cref="T:System.String" />.A quoted-string containing the warning text.</returns>
		public string Text { get; private set; }

		private WarningHeaderValue()
		{
		}

		private static bool IsCodeValid(int code)
		{
			return false;
		}

		/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Net.Http.Headers.WarningHeaderValue" /> instance.</summary>
		/// <returns>Returns <see cref="T:System.Object" />.Returns a copy of the current instance.</returns>
		object ICloneable.Clone()
		{
			return null;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Net.Http.Headers.WarningHeaderValue" /> object.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if the specified <see cref="T:System.Object" /> is equal to the current object; otherwise, false.</returns>
		/// <param name="obj">The object to compare with the current object.</param>
		public override bool Equals(object obj)
		{
			return false;
		}

		/// <summary>Serves as a hash function for an <see cref="T:System.Net.Http.Headers.WarningHeaderValue" /> object.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.A hash code for the current object.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		internal static bool TryParse(string input, int minimalCount, out List<WarningHeaderValue> result)
		{
			result = null;
			return false;
		}

		private static bool TryParseElement(Lexer lexer, out WarningHeaderValue parsedValue, out Token t)
		{
			parsedValue = null;
			t = default(Token);
			return false;
		}

		/// <summary>Returns a string that represents the current <see cref="T:System.Net.Http.Headers.WarningHeaderValue" /> object.</summary>
		/// <returns>Returns <see cref="T:System.String" />.A string that represents the current object.</returns>
		public override string ToString()
		{
			return null;
		}
	}
}
