using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace NJsonSchema.Infrastructure
{
	public class PropertyRenameAndIgnoreSerializerContractResolver : DefaultContractResolver
	{
		private readonly Dictionary<string, HashSet<string>> _ignores;

		private readonly Dictionary<string, Dictionary<string, string>> _renames;

		public void RenameProperty(Type type, string propertyName, string newJsonPropertyName)
		{
		}

		protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			return null;
		}

		private bool IsIgnored(Type type, string jsonPropertyName)
		{
			return false;
		}

		private bool IsRenamed(Type type, string jsonPropertyName, out string newJsonPropertyName)
		{
			newJsonPropertyName = null;
			return false;
		}
	}
}
