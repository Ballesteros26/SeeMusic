using System;

namespace NJsonSchema.Annotations
{
	[AttributeUsage(AttributeTargets.Property)]
	public class MultipleOfAttribute : Attribute
	{
		public decimal MultipleOf { get; }
	}
}
