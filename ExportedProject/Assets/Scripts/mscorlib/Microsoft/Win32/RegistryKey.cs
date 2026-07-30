using System;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Win32
{
	/// <summary>Represents a key-level node in the Windows registry. This class is a registry encapsulation.</summary>
	public sealed class RegistryKey : MarshalByRefObject, IDisposable
	{
		[Flags]
		private enum StateFlags
		{
			Dirty = 1,
			SystemKey = 2,
			WriteAccess = 4,
			PerfData = 8
		}

		internal static readonly IntPtr HKEY_CLASSES_ROOT;

		internal static readonly IntPtr HKEY_CURRENT_USER;

		internal static readonly IntPtr HKEY_LOCAL_MACHINE;

		internal static readonly IntPtr HKEY_USERS;

		internal static readonly IntPtr HKEY_PERFORMANCE_DATA;

		internal static readonly IntPtr HKEY_CURRENT_CONFIG;

		internal static readonly IntPtr HKEY_DYN_DATA;

		private static readonly string[] s_hkeyNames;

		private SafeRegistryHandle _hkey;

		private string _keyName;

		private bool _remoteKey;

		private StateFlags _state;

		private RegistryKeyPermissionCheck _checkMode;

		private RegistryView _regView;

		private void ClosePerfDataKey()
		{
		}

		private void FlushCore()
		{
		}

		private RegistryKey CreateSubKeyInternalCore(string subkey, RegistryKeyPermissionCheck permissionCheck, object registrySecurityObj, RegistryOptions registryOptions)
		{
			return null;
		}

		private static RegistryKey OpenBaseKeyCore(RegistryHive hKeyHive, RegistryView view)
		{
			return null;
		}

		private RegistryKey InternalOpenSubKeyCore(string name, bool writable, bool throwOnPermissionFailure)
		{
			return null;
		}

		internal RegistryKey InternalOpenSubKeyWithoutSecurityChecksCore(string name, bool writable)
		{
			return null;
		}

		private int InternalSubKeyCountCore()
		{
			return 0;
		}

		private string[] InternalGetSubKeyNamesCore(int subkeys)
		{
			return null;
		}

		private object InternalGetValueCore(string name, object defaultValue, bool doNotExpand)
		{
			return null;
		}

		private void SetValueCore(string name, object value, RegistryValueKind valueKind)
		{
		}

		private void Win32Error(int errorCode, string str)
		{
		}

		private static int GetRegistryKeyAccess(bool isWritable)
		{
			return 0;
		}

		private RegistryKey(SafeRegistryHandle hkey, bool writable, bool systemkey, bool remoteKey, bool isPerfData, RegistryView view)
		{
		}

		/// <summary>Writes all the attributes of the specified open registry key into the registry.</summary>
		public void Flush()
		{
		}

		/// <summary>Closes the key and flushes it to disk if its contents have been modified.</summary>
		public void Close()
		{
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:Microsoft.Win32.RegistryKey" /> class.</summary>
		public void Dispose()
		{
		}

		/// <summary>Creates a new subkey or opens an existing subkey for write access.  </summary>
		/// <returns>The newly created subkey, or null if the operation failed. If a zero-length string is specified for <paramref name="subkey" />, the current <see cref="T:Microsoft.Win32.RegistryKey" /> object is returned.</returns>
		/// <param name="subkey">The name or path of the subkey to create or open. This string is not case-sensitive.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="subkey" /> is null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have the permissions required to create or open the registry key. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> on which this method is being invoked is closed (closed keys cannot be accessed). </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The <see cref="T:Microsoft.Win32.RegistryKey" /> cannot be written to; for example, it was not opened as a writable key , or the user does not have the necessary access rights. </exception>
		/// <exception cref="T:System.IO.IOException">The nesting level exceeds 510.-or-A system error occurred, such as deletion of the key, or an attempt to create a key in the <see cref="F:Microsoft.Win32.Registry.LocalMachine" /> root.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public RegistryKey CreateSubKey(string subkey)
		{
			return null;
		}

		/// <summary>Creates a new subkey or opens an existing subkey for write access, using the specified permission check option. </summary>
		/// <returns>The newly created subkey, or null if the operation failed. If a zero-length string is specified for <paramref name="subkey" />, the current <see cref="T:Microsoft.Win32.RegistryKey" /> object is returned.</returns>
		/// <param name="subkey">The name or path of the subkey to create or open. This string is not case-sensitive.</param>
		/// <param name="permissionCheck">One of the enumeration values that specifies whether the key is opened for read or read/write access.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="subkey" /> is null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have the permissions required to create or open the registry key. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="permissionCheck" /> contains an invalid value.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> on which this method is being invoked is closed (closed keys cannot be accessed). </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The <see cref="T:Microsoft.Win32.RegistryKey" /> cannot be written to; for example, it was not opened as a writable key, or the user does not have the necessary access rights. </exception>
		/// <exception cref="T:System.IO.IOException">The nesting level exceeds 510.-or-A system error occurred, such as deletion of the key, or an attempt to create a key in the <see cref="F:Microsoft.Win32.Registry.LocalMachine" /> root.</exception>
		public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck)
		{
			return null;
		}

		private RegistryKey CreateSubKeyInternal(string subkey, RegistryKeyPermissionCheck permissionCheck, object registrySecurityObj, RegistryOptions registryOptions)
		{
			return null;
		}

		/// <summary>Opens a new <see cref="T:Microsoft.Win32.RegistryKey" /> that represents the requested key on the local machine with the specified view.</summary>
		/// <returns>The requested registry key.</returns>
		/// <param name="hKey">The HKEY to open.</param>
		/// <param name="view">The registry view to use.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="hKey" /> or <paramref name="view" /> is invalid.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have the permissions required to perform this action.</exception>
		public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view)
		{
			return null;
		}

		/// <summary>Retrieves a subkey as read-only.</summary>
		/// <returns>The subkey requested, or null if the operation failed.</returns>
		/// <param name="name">The name or path of the subkey to open as read-only. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null</exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> is closed (closed keys cannot be accessed). </exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have the permissions required to read the registry key. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" />
		/// </PermissionSet>
		public RegistryKey OpenSubKey(string name)
		{
			return null;
		}

		/// <summary>Retrieves a specified subkey, and specifies whether write access is to be applied to the key. </summary>
		/// <returns>The subkey requested, or null if the operation failed.</returns>
		/// <param name="name">Name or path of the subkey to open. </param>
		/// <param name="writable">Set to true if you need write access to the key. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> is closed (closed keys cannot be accessed). </exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have the permissions required to access the registry key in the specified mode. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public RegistryKey OpenSubKey(string name, bool writable)
		{
			return null;
		}

		internal RegistryKey InternalOpenSubKeyWithoutSecurityChecks(string name, bool writable)
		{
			return null;
		}

		private int InternalSubKeyCount()
		{
			return 0;
		}

		/// <summary>Retrieves an array of strings that contains all the subkey names.</summary>
		/// <returns>An array of strings that contains the names of the subkeys for the current key.</returns>
		/// <exception cref="T:System.Security.SecurityException">The user does not have the permissions required to read from the key. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being manipulated is closed (closed keys cannot be accessed). </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception>
		/// <exception cref="T:System.IO.IOException">A system error occurred, for example the current key has been deleted.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public string[] GetSubKeyNames()
		{
			return null;
		}

		private string[] InternalGetSubKeyNames()
		{
			return null;
		}

		/// <summary>Retrieves the value associated with the specified name. Returns null if the name/value pair does not exist in the registry.</summary>
		/// <returns>The value associated with <paramref name="name" />, or null if <paramref name="name" /> is not found.</returns>
		/// <param name="name">The name of the value to retrieve. This string is not case-sensitive.</param>
		/// <exception cref="T:System.Security.SecurityException">The user does not have the permissions required to read from the registry key. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value is closed (closed keys cannot be accessed). </exception>
		/// <exception cref="T:System.IO.IOException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value has been marked for deletion. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" />
		/// </PermissionSet>
		public object GetValue(string name)
		{
			return null;
		}

		/// <summary>Retrieves the value associated with the specified name and retrieval options. If the name is not found, returns the default value that you provide.</summary>
		/// <returns>The value associated with <paramref name="name" />, processed according to the specified <paramref name="options" />, or <paramref name="defaultValue" /> if <paramref name="name" /> is not found.</returns>
		/// <param name="name">The name of the value to retrieve. This string is not case-sensitive.</param>
		/// <param name="defaultValue">The value to return if <paramref name="name" /> does not exist. </param>
		/// <param name="options">One of the enumeration values that specifies optional processing of the retrieved value.</param>
		/// <exception cref="T:System.Security.SecurityException">The user does not have the permissions required to read from the registry key. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value is closed (closed keys cannot be accessed). </exception>
		/// <exception cref="T:System.IO.IOException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value has been marked for deletion. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> is not a valid <see cref="T:Microsoft.Win32.RegistryValueOptions" /> value; for example, an invalid value is cast to <see cref="T:Microsoft.Win32.RegistryValueOptions" />.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" />
		/// </PermissionSet>
		public object GetValue(string name, object defaultValue, RegistryValueOptions options)
		{
			return null;
		}

		private object InternalGetValue(string name, object defaultValue, bool doNotExpand, bool checkSecurity)
		{
			return null;
		}

		/// <summary>Sets the specified name/value pair.</summary>
		/// <param name="name">The name of the value to store. </param>
		/// <param name="value">The data to be stored. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is an unsupported data type. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value is closed (closed keys cannot be accessed). </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The <see cref="T:Microsoft.Win32.RegistryKey" /> is read-only, and cannot be written to; for example, the key has not been opened with write access. -or-The <see cref="T:Microsoft.Win32.RegistryKey" /> object represents a root-level node, and the operating system is Windows Millennium Edition or Windows 98.</exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have the permissions required to create or modify registry keys. </exception>
		/// <exception cref="T:System.IO.IOException">The <see cref="T:Microsoft.Win32.RegistryKey" /> object represents a root-level node, and the operating system is Windows 2000, Windows XP, or Windows Server 2003.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public void SetValue(string name, object value)
		{
		}

		/// <summary>Sets the value of a name/value pair in the registry key, using the specified registry data type.</summary>
		/// <param name="name">The name of the value to be stored. </param>
		/// <param name="value">The data to be stored. </param>
		/// <param name="valueKind">The registry data type to use when storing the data. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">The type of <paramref name="value" /> did not match the registry data type specified by <paramref name="valueKind" />, therefore the data could not be converted properly. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value is closed (closed keys cannot be accessed). </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The <see cref="T:Microsoft.Win32.RegistryKey" /> is read-only, and cannot be written to; for example, the key has not been opened with write access.-or-The <see cref="T:Microsoft.Win32.RegistryKey" /> object represents a root-level node, and the operating system is Windows Millennium Edition or Windows 98. </exception>
		/// <exception cref="T:System.Security.SecurityException">The user does not have the permissions required to create or modify registry keys. </exception>
		/// <exception cref="T:System.IO.IOException">The <see cref="T:Microsoft.Win32.RegistryKey" /> object represents a root-level node, and the operating system is Windows 2000, Windows XP, or Windows Server 2003.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public void SetValue(string name, object value, RegistryValueKind valueKind)
		{
		}

		private RegistryValueKind CalculateValueKind(object value)
		{
			return default(RegistryValueKind);
		}

		/// <summary>Retrieves a string representation of this key.</summary>
		/// <returns>A string representing the key. If the specified key is invalid (cannot be found) then null is returned.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being accessed is closed (closed keys cannot be accessed). </exception>
		public override string ToString()
		{
			return null;
		}

		private static string FixupName(string name)
		{
			return null;
		}

		private static void FixupPath(StringBuilder path)
		{
		}

		private void EnsureNotDisposed()
		{
		}

		private void EnsureWriteable()
		{
		}

		private RegistryKeyPermissionCheck GetSubKeyPermissionCheck(bool subkeyWritable)
		{
			return default(RegistryKeyPermissionCheck);
		}

		private static void ValidateKeyName(string name)
		{
		}

		private static void ValidateKeyMode(RegistryKeyPermissionCheck mode)
		{
		}

		private static void ValidateKeyOptions(RegistryOptions options)
		{
		}

		private static void ValidateKeyView(RegistryView view)
		{
		}

		private bool IsDirty()
		{
			return false;
		}

		private bool IsSystemKey()
		{
			return false;
		}

		private bool IsWritable()
		{
			return false;
		}

		private bool IsPerfDataKey()
		{
			return false;
		}

		private void SetDirty()
		{
		}
	}
}
