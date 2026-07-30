using System;

namespace NJsonSchema.Annotations
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class JsonSchemaPatternPropertiesAttribute : Attribute
	{
		public string RegularExpression { get; }

		public Type Type { get; }
	}
}
