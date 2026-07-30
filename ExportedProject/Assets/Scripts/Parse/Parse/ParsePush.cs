using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Parse.Common.Internal;
using Parse.Push.Internal;

namespace Parse
{
	public class ParsePush
	{
		private object mutex;

		private IPushState state;

		internal static readonly SynchronizedEventHandler<ParsePushNotificationEventArgs> parsePushNotificationReceived;

		public ParseQuery<ParseInstallation> Query
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IEnumerable<string> Channels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime? Expiration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime? PushTime
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TimeSpan? ExpirationInterval
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IDictionary<string, object> Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Alert
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private static IParsePushController PushController => null;

		private static IParsePushChannelsController PushChannelsController => null;

		public static event EventHandler<ParsePushNotificationEventArgs> ParsePushNotificationReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		internal IDictionary<string, object> Encode()
		{
			return null;
		}

		private void MutateState(Action<MutablePushState> func)
		{
		}

		public Task SendAsync()
		{
			return null;
		}

		public Task SendAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task SendAlertAsync(string alert)
		{
			return null;
		}

		public static Task SendAlertAsync(string alert, string channel)
		{
			return null;
		}

		public static Task SendAlertAsync(string alert, IEnumerable<string> channels)
		{
			return null;
		}

		public static Task SendAlertAsync(string alert, ParseQuery<ParseInstallation> query)
		{
			return null;
		}

		public static Task SendDataAsync(IDictionary<string, object> data)
		{
			return null;
		}

		public static Task SendDataAsync(IDictionary<string, object> data, string channel)
		{
			return null;
		}

		public static Task SendDataAsync(IDictionary<string, object> data, IEnumerable<string> channels)
		{
			return null;
		}

		public static Task SendDataAsync(IDictionary<string, object> data, ParseQuery<ParseInstallation> query)
		{
			return null;
		}

		public static Task SubscribeAsync(string channel)
		{
			return null;
		}

		public static Task SubscribeAsync(string channel, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task SubscribeAsync(IEnumerable<string> channels)
		{
			return null;
		}

		public static Task SubscribeAsync(IEnumerable<string> channels, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task UnsubscribeAsync(string channel)
		{
			return null;
		}

		public static Task UnsubscribeAsync(string channel, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task UnsubscribeAsync(IEnumerable<string> channels)
		{
			return null;
		}

		public static Task UnsubscribeAsync(IEnumerable<string> channels, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
