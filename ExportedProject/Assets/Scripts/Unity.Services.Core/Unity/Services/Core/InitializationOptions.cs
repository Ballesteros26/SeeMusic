using System.Collections.Generic;

namespace Unity.Services.Core
{
	public class InitializationOptions
	{
		internal IDictionary<string, object> Values { get; }

		public InitializationOptions()
		{
		}

		internal InitializationOptions(IDictionary<string, object> values)
		{
		}

		internal InitializationOptions(InitializationOptions source)
		{
		}
	}
}
