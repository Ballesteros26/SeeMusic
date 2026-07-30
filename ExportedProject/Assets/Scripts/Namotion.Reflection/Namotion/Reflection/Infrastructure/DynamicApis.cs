namespace Namotion.Reflection.Infrastructure
{
	internal static class DynamicApis
	{
		public static bool SupportsFileApis => false;

		public static bool SupportsPathApis => false;

		public static bool SupportsXPathApis => false;

		public static string DirectoryGetCurrentDirectory()
		{
			return null;
		}

		public static bool FileExists(string filePath)
		{
			return false;
		}

		public static string FileReadAllText(string filePath)
		{
			return null;
		}

		public static bool DirectoryExists(string directoryPath)
		{
			return false;
		}

		public static string[] DirectoryGetAllFiles(string path, string searchPattern)
		{
			return null;
		}

		public static string[] DirectoryGetFiles(string path, string searchPattern)
		{
			return null;
		}

		public static string PathCombine(string path1, string path2)
		{
			return null;
		}

		public static string PathGetDirectoryName(string filePath)
		{
			return null;
		}
	}
}
