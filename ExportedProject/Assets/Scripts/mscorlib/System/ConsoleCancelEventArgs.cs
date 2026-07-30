namespace System
{
	/// <summary>Provides data for the <see cref="E:System.Console.CancelKeyPress" /> event. This class cannot be inherited.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	public sealed class ConsoleCancelEventArgs : EventArgs
	{
		private readonly ConsoleSpecialKey _type;

		/// <summary>Gets or sets a value that indicates whether simultaneously pressing the <see cref="F:System.ConsoleModifiers.Control" /> modifier key and the <see cref="F:System.ConsoleKey.C" /> console key (Ctrl+C) or the Ctrl+Break keys terminates the current process. The default is false, which terminates the current process. </summary>
		/// <returns>true if the current process should resume when the event handler concludes; false if the current process should terminate. The default value is false; the current process terminates when the event handler returns. If true, the current process continues. </returns>
		/// <filterpriority>2</filterpriority>
		public bool Cancel { get; }

		internal ConsoleCancelEventArgs(ConsoleSpecialKey type)
		{
		}

		internal ConsoleCancelEventArgs()
		{
		}
	}
}
