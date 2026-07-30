using System;
using Namotion.Reflection;

namespace NJsonSchema.Generation
{
	public class DefaultSchemaNameGenerator : ISchemaNameGenerator
	{
		public virtual string Generate(Type type)
		{
			return null;
		}

		private static string GetName(CachedType cType)
		{
			return null;
		}

		private static string GetNullableDisplayName(CachedType type, string actual)
		{
			return null;
		}
	}
}
