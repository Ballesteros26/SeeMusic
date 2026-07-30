namespace System.Diagnostics
{
	/// <summary>Defines the smallest unit of a code access security permission that is set for an <see cref="T:System.Diagnostics.EventLog" />.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	public class EventLogPermissionEntry
	{
		/// <summary>Gets the name of the computer on which to read or write events.</summary>
		/// <returns>The name of the computer on which to read or write events.</returns>
		/// <filterpriority>2</filterpriority>
		public string MachineName => null;

		/// <summary>Gets the permission access levels used in the permissions request.</summary>
		/// <returns>A bitwise combination of the <see cref="T:System.Diagnostics.EventLogPermissionAccess" /> values.</returns>
		/// <filterpriority>2</filterpriority>
		public EventLogPermissionAccess PermissionAccess => default(EventLogPermissionAccess);

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLogPermissionEntry" /> class.</summary>
		/// <param name="permissionAccess">A bitwise combination of the <see cref="T:System.Diagnostics.EventLogPermissionAccess" /> values. The <see cref="P:System.Diagnostics.EventLogPermissionEntry.PermissionAccess" /> property is set to this value. </param>
		/// <param name="machineName">The name of the computer on which to read or write events. The <see cref="P:System.Diagnostics.EventLogPermissionEntry.MachineName" /> property is set to this value. </param>
		/// <exception cref="T:System.ArgumentException">The computer name is invalid. </exception>
		public EventLogPermissionEntry(EventLogPermissionAccess permissionAccess, string machineName)
		{
		}
	}
}
