using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Parse.Core.Internal;

namespace Parse
{
	[ParseClassName("_Session")]
	public class ParseSession : ParseObject
	{
		private static readonly HashSet<string> readOnlyKeys;

		[ParseFieldName("sessionToken")]
		public string SessionToken => null;

		public static ParseQuery<ParseSession> Query => null;

		internal static IParseSessionController SessionController => null;

		protected override bool IsKeyMutable(string key)
		{
			return false;
		}

		public static Task<ParseSession> GetCurrentSessionAsync()
		{
			return null;
		}

		public static Task<ParseSession> GetCurrentSessionAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task RevokeAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task<string> UpgradeToRevocableSessionAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
