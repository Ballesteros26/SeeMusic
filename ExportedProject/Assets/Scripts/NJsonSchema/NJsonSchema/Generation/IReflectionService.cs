using Namotion.Reflection;
using Newtonsoft.Json;

namespace NJsonSchema.Generation
{
	public interface IReflectionService
	{
		JsonTypeDescription GetDescription(ContextualType contextualType, ReferenceTypeNullHandling defaultReferenceTypeNullHandling, JsonSchemaGeneratorSettings settings);

		JsonTypeDescription GetDescription(ContextualType contextualType, JsonSchemaGeneratorSettings settings);

		bool IsStringEnum(ContextualType contextualType, JsonSerializerSettings serializerSettings);
	}
}
