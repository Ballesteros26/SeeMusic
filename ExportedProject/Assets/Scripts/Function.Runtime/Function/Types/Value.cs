using System;
using Function.Internal;

namespace Function.Types
{
	[Serializable]
	[Preserve]
	public class Value
	{
		public string? data;

		public Dtype type;

		public int[]? shape;
	}
}
