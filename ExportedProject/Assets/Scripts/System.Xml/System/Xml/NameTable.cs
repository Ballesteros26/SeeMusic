namespace System.Xml
{
	/// <summary>Implements a single-threaded <see cref="T:System.Xml.XmlNameTable" />.</summary>
	public class NameTable : XmlNameTable
	{
		private class Entry
		{
			internal string str;

			internal int hashCode;

			internal Entry next;

			internal Entry(string str, int hashCode, Entry next)
			{
			}
		}

		private Entry[] entries;

		private int count;

		private int mask;

		private int hashCodeRandomizer;

		/// <summary>Initializes a new instance of the NameTable class.</summary>
		public NameTable()
		{
		}

		/// <summary>Atomizes the specified string and adds it to the NameTable.</summary>
		/// <returns>The atomized string or the existing string if it already exists in the NameTable.</returns>
		/// <param name="key">The string to add. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> is null. </exception>
		public override string Add(string key)
		{
			return null;
		}

		/// <summary>Atomizes the specified string and adds it to the NameTable.</summary>
		/// <returns>The atomized string or the existing string if one already exists in the NameTable. If <paramref name="len" /> is zero, String.Empty is returned.</returns>
		/// <param name="key">The character array containing the string to add. </param>
		/// <param name="start">The zero-based index into the array specifying the first character of the string. </param>
		/// <param name="len">The number of characters in the string. </param>
		/// <exception cref="T:System.IndexOutOfRangeException">0 &gt; <paramref name="start" />-or- <paramref name="start" /> &gt;= <paramref name="key" />.Length -or- <paramref name="len" /> &gt;= <paramref name="key" />.Length The above conditions do not cause an exception to be thrown if <paramref name="len" /> =0. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="len" /> &lt; 0. </exception>
		public override string Add(char[] key, int start, int len)
		{
			return null;
		}

		/// <summary>Gets the atomized string with the specified value.</summary>
		/// <returns>The atomized string object or null if the string has not already been atomized.</returns>
		/// <param name="value">The name to find. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		public override string Get(string value)
		{
			return null;
		}

		private string AddEntry(string str, int hashCode)
		{
			return null;
		}

		private void Grow()
		{
		}

		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
			return false;
		}
	}
}
