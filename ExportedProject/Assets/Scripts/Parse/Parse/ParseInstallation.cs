using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Parse.Push.Internal;

namespace Parse
{
	[ParseClassName("_Installation")]
	public class ParseInstallation : ParseObject
	{
		private static readonly HashSet<string> readOnlyKeys;

		internal static readonly Dictionary<string, string> TimeZoneNameMap;

		internal static readonly Dictionary<TimeSpan, string> TimeZoneOffsetMap;

		internal static IParseCurrentInstallationController CurrentInstallationController => null;

		internal static IDeviceInfoController DeviceInfoController => null;

		public static ParseInstallation CurrentInstallation => null;

		public static ParseQuery<ParseInstallation> Query => null;

		[ParseFieldName("installationId")]
		public Guid InstallationId
		{
			get
			{
				return default(Guid);
			}
			internal set
			{
			}
		}

		[ParseFieldName("deviceType")]
		public string DeviceType
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		[ParseFieldName("appName")]
		public string AppName
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		[ParseFieldName("appVersion")]
		public string AppVersion
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		[ParseFieldName("appIdentifier")]
		public string AppIdentifier
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		[ParseFieldName("timeZone")]
		public string TimeZone
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		[ParseFieldName("localeIdentifier")]
		public string LocaleIdentifier
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		[ParseFieldName("parseVersion")]
		public Version ParseVersion
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		[ParseFieldName("channels")]
		public IList<string> Channels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal static void ClearInMemoryInstallation()
		{
		}

		private string GetLocaleIdentifier()
		{
			return null;
		}

		protected override bool IsKeyMutable(string key)
		{
			return false;
		}

		protected override Task SaveAsync(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}

		private Version GetParseVersion()
		{
			return null;
		}
	}
}
