namespace Mono.Security
{
	internal class Uri
	{
		private struct UriScheme
		{
			public string scheme;

			public string delimiter;

			public int defaultPort;

			public UriScheme(string s, string d, int p)
			{
				scheme = null;
				delimiter = null;
				defaultPort = 0;
			}
		}

		private bool isUnixFilePath;

		private string source;

		private string scheme;

		private string host;

		private int port;

		private string path;

		private string query;

		private string fragment;

		private string userinfo;

		private bool isUnc;

		private bool isOpaquePart;

		private bool userEscaped;

		private string cachedToString;

		private string cachedLocalPath;

		private int cachedHashCode;

		private bool reduce;

		private static readonly string hexUpperChars;

		public static readonly string SchemeDelimiter;

		public static readonly string UriSchemeFile;

		public static readonly string UriSchemeFtp;

		public static readonly string UriSchemeGopher;

		public static readonly string UriSchemeHttp;

		public static readonly string UriSchemeHttps;

		public static readonly string UriSchemeMailto;

		public static readonly string UriSchemeNews;

		public static readonly string UriSchemeNntp;

		private static UriScheme[] schemes;

		public string AbsolutePath => null;

		public bool IsFile => false;

		public bool IsUnc => false;

		public string LocalPath => null;

		public Uri(string uriString)
		{
		}

		public Uri(string uriString, bool dontEscape)
		{
		}

		public override bool Equals(object comparant)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public string GetLeftPart(UriPartial part)
		{
			return null;
		}

		public static int FromHex(char digit)
		{
			return 0;
		}

		public static string HexEscape(char character)
		{
			return null;
		}

		public static char HexUnescape(string pattern, ref int index)
		{
			return '\0';
		}

		public static bool IsHexDigit(char digit)
		{
			return false;
		}

		public static bool IsHexEncoding(string pattern, int index)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		protected static string EscapeString(string str)
		{
			return null;
		}

		internal static string EscapeString(string str, bool escapeReserved, bool escapeHex, bool escapeBrackets)
		{
			return null;
		}

		protected void Parse()
		{
		}

		protected string Unescape(string str)
		{
			return null;
		}

		internal string Unescape(string str, bool excludeSharp)
		{
			return null;
		}

		private void ParseAsWindowsUNC(string uriString)
		{
		}

		private void ParseAsWindowsAbsoluteFilePath(string uriString)
		{
		}

		private void ParseAsUnixAbsoluteFilePath(string uriString)
		{
		}

		private void Parse(string uriString)
		{
		}

		private static string Reduce(string path)
		{
			return null;
		}

		internal static string GetSchemeDelimiter(string scheme)
		{
			return null;
		}

		internal static int GetDefaultPort(string scheme)
		{
			return 0;
		}

		private string GetOpaqueWiseSchemeDelimiter()
		{
			return null;
		}

		private static bool IsPredefinedScheme(string scheme)
		{
			return false;
		}
	}
}
