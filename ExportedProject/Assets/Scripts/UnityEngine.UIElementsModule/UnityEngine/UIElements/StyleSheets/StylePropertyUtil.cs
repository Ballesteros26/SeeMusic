using System.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	internal static class StylePropertyUtil
	{
		private static readonly HashSet<StylePropertyId> s_AnimatablePropertiesHash;

		internal static readonly Dictionary<string, StylePropertyId> s_NameToId;

		internal static readonly Dictionary<StylePropertyId, string> s_IdToName;

		internal static readonly StylePropertyId[] s_AnimatableProperties;

		static StylePropertyUtil()
		{
		}

		public static bool IsAnimatable(StylePropertyId id)
		{
			return false;
		}

		public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue)
		{
			intValue = default(int);
			return false;
		}

		public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id)
		{
			return false;
		}
	}
}
