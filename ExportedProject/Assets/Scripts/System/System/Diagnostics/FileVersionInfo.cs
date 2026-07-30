using System.Text;

namespace System.Diagnostics
{
	/// <summary>Provides version information for a physical file on disk.</summary>
	/// <filterpriority>2</filterpriority>
	public sealed class FileVersionInfo
	{
		private string comments;

		private string companyname;

		private string filedescription;

		private string filename;

		private string fileversion;

		private string internalname;

		private string language;

		private string legalcopyright;

		private string legaltrademarks;

		private string originalfilename;

		private string privatebuild;

		private string productname;

		private string productversion;

		private string specialbuild;

		private bool isdebug;

		private bool ispatched;

		private bool isprerelease;

		private bool isprivatebuild;

		private bool isspecialbuild;

		private int filemajorpart;

		private int fileminorpart;

		private int filebuildpart;

		private int fileprivatepart;

		private int productmajorpart;

		private int productminorpart;

		private int productbuildpart;

		private int productprivatepart;

		/// <summary>Gets the comments associated with the file.</summary>
		/// <returns>The comments associated with the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public string Comments => null;

		/// <summary>Gets the name of the company that produced the file.</summary>
		/// <returns>The name of the company that produced the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public string CompanyName => null;

		/// <summary>Gets the build number of the file.</summary>
		/// <returns>A value representing the build number of the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public int FileBuildPart => 0;

		/// <summary>Gets the description of the file.</summary>
		/// <returns>The description of the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public string FileDescription => null;

		/// <summary>Gets the major part of the version number.</summary>
		/// <returns>A value representing the major part of the version number or 0 (zero) if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public int FileMajorPart => 0;

		/// <summary>Gets the minor part of the version number of the file.</summary>
		/// <returns>A value representing the minor part of the version number of the file or 0 (zero) if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public int FileMinorPart => 0;

		/// <summary>Gets the name of the file that this instance of <see cref="T:System.Diagnostics.FileVersionInfo" /> describes.</summary>
		/// <returns>The name of the file described by this instance of <see cref="T:System.Diagnostics.FileVersionInfo" />.</returns>
		/// <filterpriority>2</filterpriority>
		public string FileName => null;

		/// <summary>Gets the file private part number.</summary>
		/// <returns>A value representing the file private part number or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public int FilePrivatePart => 0;

		/// <summary>Gets the file version number.</summary>
		/// <returns>The version number of the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public string FileVersion => null;

		/// <summary>Gets the internal name of the file, if one exists.</summary>
		/// <returns>The internal name of the file. If none exists, this property will contain the original name of the file without the extension.</returns>
		/// <filterpriority>2</filterpriority>
		public string InternalName => null;

		/// <summary>Gets a value that specifies whether the file contains debugging information or is compiled with debugging features enabled.</summary>
		/// <returns>true if the file contains debugging information or is compiled with debugging features enabled; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		public bool IsDebug => false;

		/// <summary>Gets a value that specifies whether the file has been modified and is not identical to the original shipping file of the same version number.</summary>
		/// <returns>true if the file is patched; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		public bool IsPatched => false;

		/// <summary>Gets a value that specifies whether the file is a development version, rather than a commercially released product.</summary>
		/// <returns>true if the file is prerelease; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		public bool IsPreRelease => false;

		/// <summary>Gets a value that specifies whether the file was built using standard release procedures.</summary>
		/// <returns>true if the file is a private build; false if the file was built using standard release procedures or if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public bool IsPrivateBuild => false;

		/// <summary>Gets a value that specifies whether the file is a special build.</summary>
		/// <returns>true if the file is a special build; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		public bool IsSpecialBuild => false;

		/// <summary>Gets the default language string for the version info block.</summary>
		/// <returns>The description string for the Microsoft Language Identifier in the version resource or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public string Language => null;

		/// <summary>Gets all copyright notices that apply to the specified file.</summary>
		/// <returns>The copyright notices that apply to the specified file.</returns>
		/// <filterpriority>2</filterpriority>
		public string LegalCopyright => null;

		/// <summary>Gets the trademarks and registered trademarks that apply to the file.</summary>
		/// <returns>The trademarks and registered trademarks that apply to the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public string LegalTrademarks => null;

		/// <summary>Gets the name the file was created with.</summary>
		/// <returns>The name the file was created with or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public string OriginalFilename => null;

		/// <summary>Gets information about a private version of the file.</summary>
		/// <returns>Information about a private version of the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public string PrivateBuild => null;

		/// <summary>Gets the build number of the product this file is associated with.</summary>
		/// <returns>A value representing the build number of the product this file is associated with or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public int ProductBuildPart => 0;

		/// <summary>Gets the major part of the version number for the product this file is associated with.</summary>
		/// <returns>A value representing the major part of the product version number or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public int ProductMajorPart => 0;

		/// <summary>Gets the minor part of the version number for the product the file is associated with.</summary>
		/// <returns>A value representing the minor part of the product version number or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public int ProductMinorPart => 0;

		/// <summary>Gets the name of the product this file is distributed with.</summary>
		/// <returns>The name of the product this file is distributed with or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public string ProductName => null;

		/// <summary>Gets the private part number of the product this file is associated with.</summary>
		/// <returns>A value representing the private part number of the product this file is associated with or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public int ProductPrivatePart => 0;

		/// <summary>Gets the version of the product this file is distributed with.</summary>
		/// <returns>The version of the product this file is distributed with or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public string ProductVersion => null;

		/// <summary>Gets the special build information for the file.</summary>
		/// <returns>The special build information for the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		public string SpecialBuild => null;

		private FileVersionInfo()
		{
		}

		private unsafe void GetVersionInfo_icall(char* fileName, int fileName_length)
		{
		}

		private void GetVersionInfo_internal(string fileName)
		{
		}

		/// <summary>Returns a <see cref="T:System.Diagnostics.FileVersionInfo" /> representing the version information associated with the specified file.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.FileVersionInfo" /> containing information about the file. If the file did not contain version information, the <see cref="T:System.Diagnostics.FileVersionInfo" /> contains only the name of the file requested.</returns>
		/// <param name="fileName">The fully qualified path and name of the file to retrieve the version information for. </param>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified cannot be found. </exception>
		/// <filterpriority>1</filterpriority>
		public static FileVersionInfo GetVersionInfo(string fileName)
		{
			return null;
		}

		private static void AppendFormat(StringBuilder sb, string format, params object[] args)
		{
		}

		/// <summary>Returns a partial list of properties in the <see cref="T:System.Diagnostics.FileVersionInfo" /> and their values.</summary>
		/// <returns>A list of the following properties in this class and their values: <see cref="P:System.Diagnostics.FileVersionInfo.FileName" />, <see cref="P:System.Diagnostics.FileVersionInfo.InternalName" />, <see cref="P:System.Diagnostics.FileVersionInfo.OriginalFilename" />, <see cref="P:System.Diagnostics.FileVersionInfo.FileVersion" />, <see cref="P:System.Diagnostics.FileVersionInfo.FileDescription" />, <see cref="P:System.Diagnostics.FileVersionInfo.ProductName" />, <see cref="P:System.Diagnostics.FileVersionInfo.ProductVersion" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsDebug" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsPatched" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsPreRelease" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsPrivateBuild" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsSpecialBuild" />,<see cref="P:System.Diagnostics.FileVersionInfo.Language" />.If the file did not contain version information, this list will contain only the name of the requested file. Boolean values will be false, and all other entries will be null.</returns>
		/// <filterpriority>2</filterpriority>
		public override string ToString()
		{
			return null;
		}
	}
}
