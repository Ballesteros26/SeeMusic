using Namotion.Reflection;
using Newtonsoft.Json;

namespace NJsonSchema.Generation
{
	public class DefaultReflectionService : IReflectionService
	{
		public JsonTypeDescription GetDescription(ContextualType contextualType, JsonSchemaGeneratorSettings settings)
		{
			return null;
		}

		public virtual JsonTypeDescription GetDescription(ContextualType contextualType, ReferenceTypeNullHandling defaultReferenceTypeNullHandling, JsonSchemaGeneratorSettings settings)
		{
			return null;
		}

		public virtual bool IsNullable(ContextualType contextualType, ReferenceTypeNullHandling defaultReferenceTypeNullHandling)
		{
			return false;
		}

		public virtual bool IsStringEnum(ContextualType contextualType, JsonSerializerSettings serializerSettings)
		{
			return false;
		}

		protected virtual bool IsBinary(ContextualType contextualType)
		{
			return false;
		}

		private bool IsIAsyncEnumerableType(ContextualType contextualType)
		{
			return false;
		}

		protected virtual bool IsArrayType(ContextualType contextualType)
		{
			return false;
		}

		protected virtual bool IsDictionaryType(ContextualType contextualType)
		{
			return false;
		}

		private bool HasStringEnumConverter(ContextualType contextualType)
		{
			return false;
		}
	}
}
