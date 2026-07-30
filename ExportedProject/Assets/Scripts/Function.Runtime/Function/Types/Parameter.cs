using System;
using Function.Internal;

namespace Function.Types
{
	[Serializable]
	[Preserve]
	public class Parameter
	{
		public string? name;

		public Dtype? type;

		public string? description;

		public bool? optional;

		public float[]? range;

		public EnumerationMember[]? enumeration;

		public Value? defaultValue;
	}
}
