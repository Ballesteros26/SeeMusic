using System;
using Namotion.Reflection;

namespace NJsonSchema.Infrastructure
{
	public static class XmlObjectExtension
	{
		public static void GenerateXmlObjectForType(this JsonSchema schema, Type type)
		{
		}

		public static void GenerateXmlObjectForArrayType(this JsonSchema schema)
		{
		}

		public static void GenerateXmlObjectForItemType(this JsonSchema schema, CachedType type)
		{
		}

		public static void GenerateXmlObjectForProperty(this JsonSchemaProperty propertySchema, ContextualType type, string propertyName)
		{
		}

		private static void GenerateXmlObject(string name, string @namespace, bool wrapped, bool isAttribute, JsonSchema schema)
		{
		}

		private static string GetXmlItemName(Type type)
		{
			return null;
		}
	}
}
