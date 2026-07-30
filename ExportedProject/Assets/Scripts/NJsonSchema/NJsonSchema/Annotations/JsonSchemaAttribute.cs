using System;

namespace NJsonSchema.Annotations
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class JsonSchemaAttribute : Attribute
	{
		public string Name { get; }

		public JsonObjectType Type { get; }

		public string Format { get; }

		public Type ArrayItem { get; }
	}
}
