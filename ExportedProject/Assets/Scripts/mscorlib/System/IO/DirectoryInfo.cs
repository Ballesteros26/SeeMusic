using System.Collections.Generic;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>Exposes instance methods for creating, moving, and enumerating through directories and subdirectories. This class cannot be inherited.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	public sealed class DirectoryInfo : FileSystemInfo
	{
		/// <summary>Gets the parent directory of a specified subdirectory.</summary>
		/// <returns>The parent directory, or null if the path is null or if the file path denotes a root (such as "\", "C:", or * "\\server\share").</returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public DirectoryInfo Parent => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.DirectoryInfo" /> class on the specified path.</summary>
		/// <param name="path">A string specifying the path on which to create the DirectoryInfo. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> is null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> contains invalid characters such as ", &lt;, &gt;, or |. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. The specified path, file name, or both are too long.</exception>
		public DirectoryInfo(string path)
		{
		}

		internal DirectoryInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
		}

		private void Init(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
		}

		/// <summary>Creates a subdirectory or subdirectories on the specified path. The specified path can be relative to this instance of the <see cref="T:System.IO.DirectoryInfo" /> class.</summary>
		/// <returns>The last directory specified in <paramref name="path" />.</returns>
		/// <param name="path">The specified path. This cannot be a different disk volume or Universal Naming Convention (UNC) name. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> does not specify a valid file path or contains invalid DirectoryInfo characters. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> is null. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception>
		/// <exception cref="T:System.IO.IOException">The subdirectory cannot be created.-or- A file or directory already has the name specified by <paramref name="path" />. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. The specified path, file name, or both are too long.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have code access permission to create the directory.-or-The caller does not have code access permission to read the directory described by the returned <see cref="T:System.IO.DirectoryInfo" /> object.  This can occur when the <paramref name="path" /> parameter describes an existing directory.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> contains a colon character (:) that is not part of a drive label ("C:\").</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public DirectoryInfo CreateSubdirectory(string path)
		{
			return null;
		}

		/// <summary>Returns a file list from the current directory.</summary>
		/// <returns>An array of type <see cref="T:System.IO.FileInfo" />.</returns>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The path is invalid, such as being on an unmapped drive. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public FileInfo[] GetFiles()
		{
			return null;
		}

		/// <summary>Returns a file list from the current directory matching the given search pattern.</summary>
		/// <returns>An array of type <see cref="T:System.IO.FileInfo" />.</returns>
		/// <param name="searchPattern">The search string, such as "*.txt". </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="searchPattern " />contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="searchPattern" /> is null. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The path is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public FileInfo[] GetFiles(string searchPattern)
		{
			return null;
		}

		public FileInfo[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return null;
		}

		/// <summary>Returns the subdirectories of the current directory.</summary>
		/// <returns>An array of <see cref="T:System.IO.DirectoryInfo" /> objects.</returns>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid, such as being on an unmapped drive. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public DirectoryInfo[] GetDirectories()
		{
			return null;
		}

		public DirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return null;
		}

		/// <summary>Returns an enumerable collection of file information in the current directory.</summary>
		/// <returns>An enumerable collection of the files in the current directory.</returns>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.FileInfo" /> object is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		public IEnumerable<FileInfo> EnumerateFiles()
		{
			return null;
		}

		public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions)
		{
			return null;
		}

		internal static IEnumerable<FileSystemInfo> InternalEnumerateInfos(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
		{
			return null;
		}

		/// <summary>Deletes this <see cref="T:System.IO.DirectoryInfo" /> if it is empty.</summary>
		/// <exception cref="T:System.UnauthorizedAccessException">The directory contains a read-only file.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The directory described by this <see cref="T:System.IO.DirectoryInfo" /> object does not exist or could not be found.</exception>
		/// <exception cref="T:System.IO.IOException">The directory is not empty. -or-The directory is the application's current working directory.-or-There is an open handle on the directory, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories. For more information, see How to: Enumerate Directories and Files.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public override void Delete()
		{
		}

		/// <summary>Deletes this instance of a <see cref="T:System.IO.DirectoryInfo" />, specifying whether to delete subdirectories and files.</summary>
		/// <param name="recursive">true to delete this directory, its subdirectories, and all files; otherwise, false. </param>
		/// <exception cref="T:System.UnauthorizedAccessException">The directory contains a read-only file.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The directory described by this <see cref="T:System.IO.DirectoryInfo" /> object does not exist or could not be found.</exception>
		/// <exception cref="T:System.IO.IOException">The directory is read-only.-or- The directory contains one or more files or subdirectories and <paramref name="recursive" /> is false.-or-The directory is the application's current working directory. -or-There is an open handle on the directory or on one of its files, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories and files. For more information, see How to: Enumerate Directories and Files.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public void Delete(bool recursive)
		{
		}

		private DirectoryInfo(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
