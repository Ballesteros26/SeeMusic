using System.Text.RegularExpressions;

namespace Parse
{
	[ParseClassName("_Role")]
	public class ParseRole : ParseObject
	{
		private static readonly Regex namePattern;

		[ParseFieldName("name")]
		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[ParseFieldName("users")]
		public ParseRelation<ParseUser> Users => null;

		[ParseFieldName("roles")]
		public ParseRelation<ParseRole> Roles => null;

		public static ParseQuery<ParseRole> Query => null;

		public ParseRole()
		{
		}

		public ParseRole(string name, ParseACL acl)
		{
		}

		internal override void OnSettingValue(ref string key, ref object value)
		{
		}
	}
}
