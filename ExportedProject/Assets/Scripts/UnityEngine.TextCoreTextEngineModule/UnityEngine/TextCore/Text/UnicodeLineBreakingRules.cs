using System;
using System.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	[Serializable]
	public class UnicodeLineBreakingRules
	{
		private static UnicodeLineBreakingRules s_Instance;

		[SerializeField]
		private UnityEngine.TextAsset m_UnicodeLineBreakingRules;

		[SerializeField]
		private UnityEngine.TextAsset m_LeadingCharacters;

		[SerializeField]
		private UnityEngine.TextAsset m_FollowingCharacters;

		[SerializeField]
		private bool m_UseModernHangulLineBreakingRules;

		private static HashSet<uint> s_LeadingCharactersLookup;

		private static HashSet<uint> s_FollowingCharactersLookup;

		internal HashSet<uint> leadingCharactersLookup => null;

		internal HashSet<uint> followingCharactersLookup => null;

		internal static void LoadLineBreakingRules()
		{
		}

		private static HashSet<uint> GetCharacters(UnityEngine.TextAsset file)
		{
			return null;
		}
	}
}
