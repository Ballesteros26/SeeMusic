using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Parse.Core.Internal;

namespace Parse
{
	[ParseClassName("_User")]
	public class ParseUser : ParseObject
	{
		private static readonly IDictionary<string, IParseAuthenticationProvider> authProviders;

		private static readonly HashSet<string> readOnlyKeys;

		private static readonly object isRevocableSessionEnabledMutex;

		private static bool isRevocableSessionEnabled;

		internal static IParseUserController UserController => null;

		internal static IParseCurrentUserController CurrentUserController => null;

		public bool IsAuthenticated => false;

		public string SessionToken => null;

		internal static string CurrentSessionToken => null;

		[ParseFieldName("username")]
		public string Username
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[ParseFieldName("password")]
		public string Password
		{
			private get
			{
				return null;
			}
			set
			{
			}
		}

		[ParseFieldName("email")]
		public string Email
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static ParseUser CurrentUser => null;

		public static ParseQuery<ParseUser> Query => null;

		internal static bool IsRevocableSessionEnabled => false;

		internal IDictionary<string, IDictionary<string, object>> AuthData
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public override void Remove(string key)
		{
		}

		protected override bool IsKeyMutable(string key)
		{
			return false;
		}

		internal override void HandleSave(IObjectState serverState)
		{
		}

		internal static Task<string> GetCurrentSessionTokenAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal Task SetSessionTokenAsync(string newSessionToken)
		{
			return null;
		}

		internal Task SetSessionTokenAsync(string newSessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task SignUpAsync(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task SignUpAsync()
		{
			return null;
		}

		public Task SignUpAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<ParseUser> LogInAsync(string username, string password)
		{
			return null;
		}

		public static Task<ParseUser> LogInAsync(string username, string password, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<ParseUser> BecomeAsync(string sessionToken)
		{
			return null;
		}

		public static Task<ParseUser> BecomeAsync(string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		protected override Task SaveAsync(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		internal override Task<ParseObject> FetchAsyncInternal(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		public static void LogOut()
		{
		}

		public static Task LogOutAsync()
		{
			return null;
		}

		public static Task LogOutAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task LogOutAsync(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		private static void LogOutWithProviders()
		{
		}

		internal static Task<ParseUser> GetCurrentUserAsync()
		{
			return null;
		}

		internal static Task<ParseUser> GetCurrentUserAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		private static Task SaveCurrentUserAsync(ParseUser user)
		{
			return null;
		}

		private static Task SaveCurrentUserAsync(ParseUser user, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static void ClearInMemoryUser()
		{
		}

		public static Task EnableRevocableSessionAsync()
		{
			return null;
		}

		public static Task EnableRevocableSessionAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		internal static void DisableRevocableSession()
		{
		}

		internal Task UpgradeToRevocableSessionAsync()
		{
			return null;
		}

		internal Task UpgradeToRevocableSessionAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task UpgradeToRevocableSessionAsync(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task RequestPasswordResetAsync(string email)
		{
			return null;
		}

		public static Task RequestPasswordResetAsync(string email, CancellationToken cancellationToken)
		{
			return null;
		}

		private static IParseAuthenticationProvider GetProvider(string providerName)
		{
			return null;
		}

		private void CleanupAuthData()
		{
		}

		private void SynchronizeAllAuthData()
		{
		}

		private void SynchronizeAuthData(IParseAuthenticationProvider provider)
		{
		}

		internal Task LinkWithAsync(string authType, IDictionary<string, object> data, CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task LinkWithAsync(string authType, CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task UnlinkFromAsync(string authType, CancellationToken cancellationToken)
		{
			return null;
		}

		internal bool IsLinked(string authType)
		{
			return false;
		}

		internal static Task<ParseUser> LogInWithAsync(string authType, IDictionary<string, object> data, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task<ParseUser> LogInWithAsync(string authType, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static void RegisterProvider(IParseAuthenticationProvider provider)
		{
		}
	}
}
