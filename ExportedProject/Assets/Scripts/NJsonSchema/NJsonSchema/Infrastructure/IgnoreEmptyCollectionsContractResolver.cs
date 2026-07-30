using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace NJsonSchema.Infrastructure
{
	internal sealed class IgnoreEmptyCollectionsContractResolver : PropertyRenameAndIgnoreSerializerContractResolver
	{
		protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			return null;
		}
	}
}
