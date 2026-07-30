using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Parse.Common.Internal;
using Parse.Core.Internal;

namespace Parse
{
	public class ParseConfig : IJsonConvertible
	{
		private IDictionary<string, object> properties;

		public static ParseConfig CurrentConfig => null;

		private static IParseConfigController ConfigController => null;

		public virtual object this[string key] => null;

		internal static void ClearCurrentConfig()
		{
		}

		internal static void ClearCurrentConfigInMemory()
		{
		}

		internal ParseConfig()
		{
		}

		internal ParseConfig(IDictionary<string, object> fetchedConfig)
		{
		}

		public static Task<ParseConfig> GetAsync()
		{
			return null;
		}

		public static Task<ParseConfig> GetAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public T Get<T>(string key)
		{
			return default(T);
		}

		public bool TryGetValue<T>(string key, out T result)
		{
			result = default(T);
			return false;
		}

		IDictionary<string, object> IJsonConvertible.ToJSON()
		{
			return null;
		}
	}
}
