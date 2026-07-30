using System.Text.RegularExpressions;

namespace Better.StreamingAssets
{
	public static class PathUtil
	{
		private enum NormalizeState
		{
			PrevSlash = 0,
			PrevDot = 1,
			PrevDoubleDot = 2,
			NothingSpecial = 3
		}

		public static bool IsDirectorySeparator(char c)
		{
			return false;
		}

		public static string FixTrailingDirectorySeparators(string path)
		{
			return null;
		}

		public static string CombineSlash(string a, string b)
		{
			return null;
		}

		public static string NormalizeRelativePath(string relative, bool forceTrailingSlash = false)
		{
			return null;
		}

		public static bool IsValidCharacter(char c)
		{
			return false;
		}

		public static Regex WildcardToRegex(string pattern)
		{
			return null;
		}
	}
}
