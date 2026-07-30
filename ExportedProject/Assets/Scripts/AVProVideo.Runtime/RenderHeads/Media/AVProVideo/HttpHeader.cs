using System;

namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	public struct HttpHeader
	{
		public string name;

		public string value;

		public HttpHeader(string name, string value)
		{
			this.name = null;
			this.value = null;
		}

		public bool IsComplete()
		{
			return false;
		}

		public string ToValidatedString()
		{
			return null;
		}

		public static bool IsValid(string text)
		{
			return false;
		}

		private static bool IsAscii(string text)
		{
			return false;
		}

		private bool IsValid()
		{
			return false;
		}
	}
}
