using System.Collections;

namespace System.Diagnostics
{
	/// <summary>Defines size and enumerators for a collection of <see cref="T:System.Diagnostics.EventLogEntry" /> instances.</summary>
	/// <filterpriority>2</filterpriority>
	public class EventLogEntryCollection : ICollection, IEnumerable
	{
		/// <summary>Gets the number of entries in the event log (that is, the number of elements in the <see cref="T:System.Diagnostics.EventLogEntry" /> collection).</summary>
		/// <returns>The number of entries currently in the event log.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public int Count => 0;

		/// <summary>Gets an entry in the event log, based on an index that starts at 0 (zero).</summary>
		/// <returns>The event log entry at the location that is specified by the <paramref name="index" /> parameter.</returns>
		/// <param name="index">The zero-based index that is associated with the event log entry. </param>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public virtual EventLogEntry this[int index] => null;

		/// <summary>Gets a value that indicates whether access to the <see cref="T:System.Diagnostics.EventLogEntryCollection" /> is synchronized (thread-safe).</summary>
		/// <returns>false if access to the collection is not synchronized (thread-safe).</returns>
		bool ICollection.IsSynchronized => false;

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Diagnostics.EventLogEntryCollection" /> object.</summary>
		/// <returns>An object that can be used to synchronize access to the collection.</returns>
		object ICollection.SyncRoot => null;

		internal EventLogEntryCollection()
		{
		}

		/// <summary>Copies the elements of the <see cref="T:System.Diagnostics.EventLogEntryCollection" /> to an array of <see cref="T:System.Diagnostics.EventLogEntry" /> instances, starting at a particular array index.</summary>
		/// <param name="entries">The one-dimensional array of <see cref="T:System.Diagnostics.EventLogEntry" /> instances that is the destination of the elements copied from the collection. The array must have zero-based indexing. </param>
		/// <param name="index">The zero-based index in the array at which copying begins. </param>
		/// <filterpriority>2</filterpriority>
		public void CopyTo(EventLogEntry[] entries, int index)
		{
		}

		/// <summary>Supports a simple iteration over the <see cref="T:System.Diagnostics.EventLogEntryCollection" /> object.</summary>
		/// <returns>An object that can be used to iterate over the collection.</returns>
		/// <filterpriority>2</filterpriority>
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		/// <summary>Copies the elements of the collection to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements that are copied from the collection. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		void ICollection.CopyTo(Array array, int index)
		{
		}
	}
}
