using System.Collections.Generic;
using Parse.Common.Internal;

namespace Parse
{
	public class ParseACL : IJsonConvertible
	{
		private enum AccessKind
		{
			Read = 0,
			Write = 1
		}

		private const string publicName = "*";

		private readonly ICollection<string> readers;

		private readonly ICollection<string> writers;

		public bool PublicReadAccess
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool PublicWriteAccess
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal ParseACL(IDictionary<string, object> jsonObject)
		{
		}

		public ParseACL()
		{
		}

		public ParseACL(ParseUser owner)
		{
		}

		IDictionary<string, object> IJsonConvertible.ToJSON()
		{
			return null;
		}

		private void SetAccess(AccessKind kind, string userId, bool allowed)
		{
		}

		private bool GetAccess(AccessKind kind, string userId)
		{
			return false;
		}

		public void SetReadAccess(string userId, bool allowed)
		{
		}

		public void SetReadAccess(ParseUser user, bool allowed)
		{
		}

		public void SetWriteAccess(string userId, bool allowed)
		{
		}

		public void SetWriteAccess(ParseUser user, bool allowed)
		{
		}

		public bool GetReadAccess(string userId)
		{
			return false;
		}

		public bool GetReadAccess(ParseUser user)
		{
			return false;
		}

		public bool GetWriteAccess(string userId)
		{
			return false;
		}

		public bool GetWriteAccess(ParseUser user)
		{
			return false;
		}

		public void SetRoleReadAccess(string roleName, bool allowed)
		{
		}

		public void SetRoleReadAccess(ParseRole role, bool allowed)
		{
		}

		public bool GetRoleReadAccess(string roleName)
		{
			return false;
		}

		public bool GetRoleReadAccess(ParseRole role)
		{
			return false;
		}

		public void SetRoleWriteAccess(string roleName, bool allowed)
		{
		}

		public void SetRoleWriteAccess(ParseRole role, bool allowed)
		{
		}

		public bool GetRoleWriteAccess(string roleName)
		{
			return false;
		}

		public bool GetRoleWriteAccess(ParseRole role)
		{
			return false;
		}
	}
}
