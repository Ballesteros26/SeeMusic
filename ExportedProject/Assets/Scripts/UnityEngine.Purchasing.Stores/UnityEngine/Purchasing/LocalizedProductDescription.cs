using System;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class LocalizedProductDescription
	{
		public TranslationLocale googleLocale;

		[SerializeField]
		private string title;

		[SerializeField]
		private string description;

		public string Title => null;

		public string Description => null;

		private static string DecodeNonLatinCharacters(string s)
		{
			return null;
		}
	}
}
