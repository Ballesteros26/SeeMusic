namespace MakeIt.Random
{
	public static class RandomString
	{
		public enum Casing
		{
			Lower = 0,
			Upper = 1,
			Any = 2
		}

		public enum Base64CharacterPairs
		{
			PlusSlash = 0,
			HyphenUnderscore = 1,
			PeriodUnderscore = 2,
			PeriodHyphen = 3,
			UnderscoreColon = 4,
			UnderscoreHyphen = 5,
			BangHyphen = 6,
			TildeHyphen = 7
		}

		private static char[] _lowerHexadecimalCharacters;

		private static char[] _upperHexadecimalCharacters;

		private static char[] _base64PlusSlashCharacters;

		private static char[] _base64HyphenUnderscoreCharacters;

		private static char[] _base64PeriodUnderscoreCharacters;

		private static char[] _base64PeriodHyphenCharacters;

		private static char[] _base64UnderscoreColonCharacters;

		private static char[] _base64UnderscoreHyphenCharacters;

		private static char[] _base64BangHyphenCharacters;

		private static char[] _base64TildeHyphenCharacters;

		private static char[] _alphaNumericCharacters;

		private static char[] _lowerAlphaNumericCharacters;

		private static char[] _upperAlphaNumericCharacters;

		private static char[] _alphabeticCharacters;

		private static char[] _lowerAlphabeticCharacters;

		private static char[] _upperAlphabeticCharacters;

		public static string String(this IRandom random, int length, char[] characters)
		{
			return null;
		}

		public static string String(this IRandom random, int length, char[] characters, char separator, float separatorProbability, bool allowSeparatorAtEnd = false, bool allowSeparatorAtBegin = false, bool forceSeparatorAtBegin = false)
		{
			return null;
		}

		public static void Characters(this IRandom random, char[] buffer, int start, int length, char[] characters)
		{
		}

		public static void Characters(this IRandom random, char[] buffer, int start, int length, char[] characters, char separator, float separatorProbability, bool allowSeparatorAtEnd = false, bool allowSeparatorAtBegin = false, bool forceSeparatorAtBegin = false)
		{
		}

		public static string BinaryString(this IRandom random, int length)
		{
			return null;
		}

		public static string OctalString(this IRandom random, int length)
		{
			return null;
		}

		public static string DecimalString(this IRandom random, int length)
		{
			return null;
		}

		private static char[] GetHexadecimalCharacters(Casing casing)
		{
			return null;
		}

		public static string HexadecimalString(this IRandom random, int length)
		{
			return null;
		}

		public static string HexadecimalString(this IRandom random, int length, Casing casing)
		{
			return null;
		}

		public static string Base64String(this IRandom random, int length)
		{
			return null;
		}

		public static string Base64String(this IRandom random, int length, Base64CharacterPairs characterPairs)
		{
			return null;
		}

		private static string Base64String(this IRandom random, int length, char[] characters)
		{
			return null;
		}

		private static char[] GetAlphaNumericCharacters(Casing casing)
		{
			return null;
		}

		public static string AlphaNumericString(this IRandom random, int length)
		{
			return null;
		}

		public static string AlphaNumericString(this IRandom random, int length, char separator, float separatorProbability)
		{
			return null;
		}

		public static string AlphaNumericString(this IRandom random, int length, Casing casing)
		{
			return null;
		}

		public static string AlphaNumericString(this IRandom random, int length, Casing casing, char separator, float separatorProbability)
		{
			return null;
		}

		private static char[] GetAlphabeticCharacters(Casing casing)
		{
			return null;
		}

		public static string AlphabeticString(this IRandom random, int length)
		{
			return null;
		}

		public static string AlphabeticString(this IRandom random, int length, char separator, float separatorProbability)
		{
			return null;
		}

		public static string AlphabeticString(this IRandom random, int length, Casing casing)
		{
			return null;
		}

		public static string AlphabeticString(this IRandom random, int length, Casing casing, char separator, float separatorProbability)
		{
			return null;
		}

		private static char[] GetIdentifierFirstCharacters(Casing casing)
		{
			return null;
		}

		private static char[] GetIdentifierCharacters(Casing casing)
		{
			return null;
		}

		public static string Identifier(this IRandom random, int length)
		{
			return null;
		}

		public static string Identifier(this IRandom random, int length, float underscoreProbability)
		{
			return null;
		}

		public static string Identifier(this IRandom random, int length, Casing casing)
		{
			return null;
		}

		public static string Identifier(this IRandom random, int length, Casing casing, float underscoreProbability)
		{
			return null;
		}
	}
}
