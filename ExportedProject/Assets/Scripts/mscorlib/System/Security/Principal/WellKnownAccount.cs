using System.Runtime.CompilerServices;

namespace System.Security.Principal
{
	internal class WellKnownAccount
	{
		[CompilerGenerated]
		private WellKnownSidType _003CWellKnownValue_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CRid_003Ek__BackingField;

		private static readonly WellKnownAccount[] accounts;

		public WellKnownSidType WellKnownValue
		{
			[CompilerGenerated]
			set
			{
				_003CWellKnownValue_003Ek__BackingField = value;
			}
		}

		public bool IsAbsolute { get; set; }

		public string Sid { get; set; }

		public string Rid
		{
			[CompilerGenerated]
			set
			{
				_003CRid_003Ek__BackingField = value;
			}
		}

		public string Name { get; set; }

		public string SddlForm { get; set; }

		public static WellKnownAccount LookupBySid(string s)
		{
			return null;
		}

		public static WellKnownAccount LookupByName(string s)
		{
			return null;
		}

		public static WellKnownAccount LookupBySddlForm(string s)
		{
			return null;
		}
	}
}
