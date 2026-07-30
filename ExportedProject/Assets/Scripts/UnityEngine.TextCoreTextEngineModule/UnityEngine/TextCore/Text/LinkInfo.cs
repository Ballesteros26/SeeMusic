namespace UnityEngine.TextCore.Text
{
	internal struct LinkInfo
	{
		public int hashCode;

		public int linkIdFirstCharacterIndex;

		public int linkIdLength;

		public int linkTextfirstCharacterIndex;

		public int linkTextLength;

		internal char[] linkId;

		internal void SetLinkId(char[] text, int startIndex, int length)
		{
		}
	}
}
