using System;
using System.Collections.Generic;

namespace Parse.Push.Internal
{
	public class MutablePushState : IPushState
	{
		public ParseQuery<ParseInstallation> Query { get; set; }

		public IEnumerable<string> Channels { get; set; }

		public DateTime? Expiration { get; set; }

		public TimeSpan? ExpirationInterval { get; set; }

		public DateTime? PushTime { get; set; }

		public IDictionary<string, object> Data { get; set; }

		public string Alert { get; set; }

		public IPushState MutatedClone(Action<MutablePushState> func)
		{
			return null;
		}

		protected virtual MutablePushState MutableClone()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
