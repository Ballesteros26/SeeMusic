using System;
using Function.Internal;

namespace Function.Types
{
	[Serializable]
	[Preserve]
	public class EnvironmentVariable
	{
		public string name;

		public string? value;
	}
}
