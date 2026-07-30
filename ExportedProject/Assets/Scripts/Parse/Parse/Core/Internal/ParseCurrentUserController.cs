using System.Threading;
using System.Threading.Tasks;
using Parse.Common.Internal;

namespace Parse.Core.Internal
{
	public class ParseCurrentUserController : IParseCurrentUserController, IParseObjectCurrentController<ParseUser>
	{
		private readonly object mutex;

		private readonly TaskQueue taskQueue;

		private IStorageController storageController;

		private ParseUser currentUser;

		public ParseUser CurrentUser
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ParseCurrentUserController(IStorageController storageController)
		{
		}

		public Task SetAsync(ParseUser user, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<ParseUser> GetAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public bool IsCurrent(ParseUser user)
		{
			return false;
		}

		public void ClearFromMemory()
		{
		}

		public void ClearFromDisk()
		{
		}

		public Task<string> GetCurrentSessionTokenAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public Task LogOutAsync(CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
