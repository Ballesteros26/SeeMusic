using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Controls code access permissions for event logging.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	public sealed class EventLogPermission : ResourcePermissionBase
	{
		/// <summary>Gets the collection of permission entries for this permissions request.</summary>
		/// <returns>A collection that contains the permission entries for this permissions request.</returns>
		/// <filterpriority>2</filterpriority>
		public EventLogPermissionEntryCollection PermissionEntries => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLogPermission" /> class.</summary>
		public EventLogPermission()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLogPermission" /> class with the specified access levels and the name of the computer to use.</summary>
		/// <param name="permissionAccess">One of the enumeration values that specifies an access level. </param>
		/// <param name="machineName">The name of the computer on which to read or write events. </param>
		public EventLogPermission(EventLogPermissionAccess permissionAccess, string machineName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLogPermission" /> class with the specified permission entries.</summary>
		/// <param name="permissionAccessEntries">An array of  objects that represent permission entries. The <see cref="P:System.Diagnostics.EventLogPermission.PermissionEntries" /> property is set to this value. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="permissionAccessEntries" /> is null.</exception>
		public EventLogPermission(EventLogPermissionEntry[] permissionAccessEntries)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLogPermission" /> class with the specified permission state.</summary>
		/// <param name="state">One of the enumeration values that specifies the permission state (full access or no access to resources). </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="state" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.PermissionState" />. </exception>
		public EventLogPermission(PermissionState state)
		{
		}
	}
}
