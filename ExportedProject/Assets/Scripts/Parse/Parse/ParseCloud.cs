using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Parse.Core.Internal;

namespace Parse
{
	public static class ParseCloud
	{
		internal static IParseCloudCodeController CloudCodeController => null;

		public static Task<T> CallFunctionAsync<T>(string name, IDictionary<string, object> parameters)
		{
			return null;
		}

		public static Task<T> CallFunctionAsync<T>(string name, IDictionary<string, object> parameters, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
