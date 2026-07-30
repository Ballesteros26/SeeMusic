namespace System
{
	/// <summary>Describes the console key that was pressed, including the character represented by the console key and the state of the SHIFT, ALT, and CTRL modifier keys.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	public readonly struct ConsoleKeyInfo
	{
		private readonly char _keyChar;

		private readonly ConsoleKey _key;

		private readonly ConsoleModifiers _mods;

		/// <summary>Gets the Unicode character represented by the current <see cref="T:System.ConsoleKeyInfo" /> object.</summary>
		/// <returns>An object that corresponds to the console key represented by the current <see cref="T:System.ConsoleKeyInfo" /> object.</returns>
		/// <filterpriority>1</filterpriority>
		public char KeyChar => '\0';

		/// <summary>Gets the console key represented by the current <see cref="T:System.ConsoleKeyInfo" /> object.</summary>
		/// <returns>A value that identifies the console key that was pressed.</returns>
		/// <filterpriority>1</filterpriority>
		public ConsoleKey Key => default(ConsoleKey);

		/// <summary>Initializes a new instance of the <see cref="T:System.ConsoleKeyInfo" /> structure using the specified character, console key, and modifier keys.</summary>
		/// <param name="keyChar">The Unicode character that corresponds to the <paramref name="key" /> parameter. </param>
		/// <param name="key">The console key that corresponds to the <paramref name="keyChar" /> parameter. </param>
		/// <param name="shift">true to indicate that a SHIFT key was pressed; otherwise, false. </param>
		/// <param name="alt">true to indicate that an ALT key was pressed; otherwise, false. </param>
		/// <param name="control">true to indicate that a CTRL key was pressed; otherwise, false. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The numeric value of the <paramref name="key" /> parameter is less than 0 or greater than 255.</exception>
		public ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control)
		{
			_keyChar = '\0';
			_key = default(ConsoleKey);
			_mods = default(ConsoleModifiers);
		}

		/// <summary>Gets a value indicating whether the specified object is equal to the current <see cref="T:System.ConsoleKeyInfo" /> object.</summary>
		/// <returns>true if <paramref name="value" /> is a <see cref="T:System.ConsoleKeyInfo" /> object and is equal to the current <see cref="T:System.ConsoleKeyInfo" /> object; otherwise, false.</returns>
		/// <param name="value">An object to compare to the current <see cref="T:System.ConsoleKeyInfo" /> object.</param>
		public override bool Equals(object value)
		{
			return false;
		}

		/// <summary>Gets a value indicating whether the specified <see cref="T:System.ConsoleKeyInfo" /> object is equal to the current <see cref="T:System.ConsoleKeyInfo" /> object.</summary>
		/// <returns>true if <paramref name="obj" /> is equal to the current <see cref="T:System.ConsoleKeyInfo" /> object; otherwise, false.</returns>
		/// <param name="obj">An object to compare to the current <see cref="T:System.ConsoleKeyInfo" /> object.</param>
		public bool Equals(ConsoleKeyInfo obj)
		{
			return false;
		}

		/// <summary>Returns the hash code for the current <see cref="T:System.ConsoleKeyInfo" /> object.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		public override int GetHashCode()
		{
			return 0;
		}
	}
}
