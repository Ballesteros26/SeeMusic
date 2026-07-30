using System.Collections.Generic;

namespace System.IO
{
	/// <summary>Exposes static methods for creating, moving, and enumerating through directories and subdirectories. This class cannot be inherited.</summary>
	/// <filterpriority>1</filterpriority>
	public static class Directory
	{
		/// <summary>Retrieves the parent directory of the specified path, including both absolute and relative paths.</summary>
		/// <returns>The parent directory, or null if <paramref name="path" /> is the root directory, including the root of a UNC server or share name.</returns>
		/// <param name="path">The path for which to retrieve the parent directory. </param>
		/// <exception cref="T:System.IO.IOException">The directory specified by <paramref name="path" /> is read-only. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> is null. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path was not found. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static DirectoryInfo GetParent(string path)
		{
			return null;
		}

		/// <summary>Creates all directories and subdirectories in the specified path.</summary>
		/// <returns>An object that represents the directory for the specified path.</returns>
		/// <param name="path">The directory path to create. </param>
		/// <exception cref="T:System.IO.IOException">The directory specified by <paramref name="path" /> is a file.-or-The network name is not known.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.-or-<paramref name="path" /> is prefixed with, or contains only a colon character (:).</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> is null. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> contains a colon character (:) that is not part of a drive label ("C:\").</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static DirectoryInfo CreateDirectory(string path)
		{
			return null;
		}

		/// <summary>Determines whether the given path refers to an existing directory on disk.</summary>
		/// <returns>true if <paramref name="path" /> refers to an existing directory; otherwise, false.</returns>
		/// <param name="path">The path to test. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static bool Exists(string path)
		{
			return false;
		}

		/// <summary>Returns the names of files (including their paths) in the specified directory.</summary>
		/// <returns>An array of the full names (including paths) for the files in the specified directory.</returns>
		/// <param name="path">The directory from which to retrieve the files. </param>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> is a file name.-or-A network error has occurred. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> is null. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static string[] GetFiles(string path)
		{
			return null;
		}

		/// <summary>Returns the names of files (including their paths) that match the specified search pattern in the specified directory.</summary>
		/// <returns>An array of the full names (including paths) for the files in the specified directory that match the specified search pattern.</returns>
		/// <param name="path">The directory to search. </param>
		/// <param name="searchPattern">The search string to match against the names of files in <paramref name="path" />. The parameter cannot end in two periods ("..") or contain two periods ("..") followed by <see cref="F:System.IO.Path.DirectorySeparatorChar" /> or <see cref="F:System.IO.Path.AltDirectorySeparatorChar" />, nor can it contain any of the characters in <see cref="F:System.IO.Path.InvalidPathChars" />. </param>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> is a file name.-or-A network error has occurred. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />.-or- <paramref name="searchPattern" /> does not contain a valid pattern. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> or <paramref name="searchPattern" /> is null. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static string[] GetFiles(string path, string searchPattern)
		{
			return null;
		}

		/// <summary>Returns the names of files (including their paths) that match the specified search pattern in the specified directory, using a value to determine whether to search subdirectories.</summary>
		/// <returns>An array of the full names (including paths) for the files in the specified directory that match the specified search pattern and option.</returns>
		/// <param name="path">The directory to search. </param>
		/// <param name="searchPattern">The search string to match against the names of files in <paramref name="path" />. The parameter cannot end in two periods ("..") or contain two periods ("..") followed by <see cref="F:System.IO.Path.DirectorySeparatorChar" /> or <see cref="F:System.IO.Path.AltDirectorySeparatorChar" />, nor can it contain any of the characters in <see cref="F:System.IO.Path.InvalidPathChars" />. </param>
		/// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include all subdirectories or only the current directory.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. -or- <paramref name="searchPattern" /> does not contain a valid pattern.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> or <paramref name="searchpattern" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> is a file name.-or-A network error has occurred. </exception>
		public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			return null;
		}

		public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return null;
		}

		internal static IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
		{
			return null;
		}

		/// <summary>Returns an enumerable collection of directory names that match a search pattern in a specified path, and optionally searches subdirectories.</summary>
		/// <returns>An enumerable collection of the full names (including paths) for the directories in the directory specified by <paramref name="path" /> and that match the specified search pattern and option.</returns>
		/// <param name="path">The directory to search. </param>
		/// <param name="searchPattern">The search string to match against the names of directories in <paramref name="path" />.  </param>
		/// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or should include all subdirectories.The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path " />is a zero-length string, contains only white space, or contains invalid characters as defined by <see cref="M:System.IO.Path.GetInvalidPathChars" />.- or -<paramref name="searchPattern" /> does not contain a valid pattern.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> is null.-or-<paramref name="searchPattern" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///   <paramref name="path" /> is invalid, such as referring to an unmapped drive. </exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> is a file name.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or combined exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
		public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
		{
			return null;
		}

		public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return null;
		}

		/// <summary>Returns an enumerable collection of file names that match a search pattern in a specified path, and optionally searches subdirectories.</summary>
		/// <returns>An enumerable collection of the full names (including paths) for the files in the directory specified by <paramref name="path" /> and that match the specified search pattern and option.</returns>
		/// <param name="path">The directory to search. </param>
		/// <param name="searchPattern">The search string to match against the names of directories in <paramref name="path" />.  </param>
		/// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or should include all subdirectories.The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path " />is a zero-length string, contains only white space, or contains invalid characters as defined by <see cref="M:System.IO.Path.GetInvalidPathChars" />.- or -<paramref name="searchPattern" /> does not contain a valid pattern.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> is null.-or-<paramref name="searchPattern" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///   <paramref name="path" /> is invalid, such as referring to an unmapped drive. </exception>
		/// <exception cref="T:System.IO.IOException">
		///   <paramref name="path" /> is a file name.</exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or combined exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
		public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
		{
			return null;
		}

		public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			return null;
		}

		internal static string InternalGetDirectoryRoot(string path)
		{
			return null;
		}

		/// <summary>Gets the current working directory of the application.</summary>
		/// <returns>A string that contains the path of the current working directory, and does not end with a backslash (\).</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.NotSupportedException">The operating system is Windows CE, which does not have current directory functionality.This method is available in the .NET Compact Framework, but is not currently supported.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static string GetCurrentDirectory()
		{
			return null;
		}

		/// <summary>Moves a file or a directory and its contents to a new location.</summary>
		/// <param name="sourceDirName">The path of the file or directory to move. </param>
		/// <param name="destDirName">The path to the new location for <paramref name="sourceDirName" />. If <paramref name="sourceDirName" /> is a file, then <paramref name="destDirName" /> must also be a file name.</param>
		/// <exception cref="T:System.IO.IOException">An attempt was made to move a directory to a different volume. -or- <paramref name="destDirName" /> already exists. -or- The <paramref name="sourceDirName" /> and <paramref name="destDirName" /> parameters refer to the same file or directory. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="sourceDirName" /> or <paramref name="destDirName" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="sourceDirName" /> or <paramref name="destDirName" /> is null. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">The path specified by <paramref name="sourceDirName" /> is invalid (for example, it is on an unmapped drive). </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void Move(string sourceDirName, string destDirName)
		{
		}

		/// <summary>Deletes an empty directory from a specified path.</summary>
		/// <param name="path">The name of the empty directory to remove. This directory must be writable and empty. </param>
		/// <exception cref="T:System.IO.IOException">A file with the same name and location specified by <paramref name="path" /> exists.-or-The directory is the application's current working directory.-or-The directory specified by <paramref name="path" /> is not empty.-or-The directory is read-only or contains a read-only file.-or-The directory is being used by another process.-or-There is an open handle on the directory, and the operating system is Windows XP or earlier. This open handle can result from directories. For more information, see How to: Enumerate Directories and Files.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> is null. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///   <paramref name="path" /> does not exist or could not be found.-or-<paramref name="path" /> refers to a file instead of a directory.-or-The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void Delete(string path)
		{
		}

		/// <summary>Deletes the specified directory and, if indicated, any subdirectories and files in the directory. </summary>
		/// <param name="path">The name of the directory to remove. </param>
		/// <param name="recursive">true to remove directories, subdirectories, and files in <paramref name="path" />; otherwise, false. </param>
		/// <exception cref="T:System.IO.IOException">A file with the same name and location specified by <paramref name="path" /> exists.-or-The directory specified by <paramref name="path" /> is read-only, or <paramref name="recursive" /> is false and <paramref name="path" /> is not an empty directory. -or-The directory is the application's current working directory. -or-The directory contains a read-only file.-or-The directory is being used by another process.There is an open handle on the directory or on one of its files, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories and files. For more information, see How to: Enumerate Directories and Files.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> is null. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters and file names must be less than 260 characters. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///   <paramref name="path" /> does not exist or could not be found.-or-<paramref name="path" /> refers to a file instead of a directory.-or-The specified path is invalid (for example, it is on an unmapped drive). </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void Delete(string path, bool recursive)
		{
		}

		/// <summary>Retrieves the names of the logical drives on this computer in the form "&lt;drive letter&gt;:\".</summary>
		/// <returns>The logical drives on this computer.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occured (for example, a disk error). </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static string[] GetLogicalDrives()
		{
			return null;
		}

		internal static string InsecureGetCurrentDirectory()
		{
			return null;
		}
	}
}
