using System;

namespace NJsonSchema.Converters
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
	public class JsonInheritanceAttribute : Attribute
	{
		public string Key { get; }

		public Type Type { get; }
	}
}
