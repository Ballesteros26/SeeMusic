namespace System.ComponentModel
{
	/// <summary>Provides a simple list of delegates. This class cannot be inherited.</summary>
	public sealed class EventHandlerList
	{
		private sealed class ListEntry
		{
			internal ListEntry _next;

			internal object _key;

			internal Delegate _handler;
		}

		private ListEntry _head;

		private Component _parent;

		/// <summary>Gets or sets the delegate for the specified object.</summary>
		/// <returns>The delegate for the specified key, or null if a delegate does not exist.</returns>
		/// <param name="key">An object to find in the list. </param>
		public Delegate this[object key] => null;

		private ListEntry Find(object key)
		{
			return null;
		}
	}
}
