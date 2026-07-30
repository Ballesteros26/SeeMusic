using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace NJsonSchema
{
	public class JsonXmlObject
	{
		[CompilerGenerated]
		private JsonSchema _003CParentSchema_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CWrapped_003Ek__BackingField;

		[CompilerGenerated]
		private string _003CNamespace_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CAttribute_003Ek__BackingField;

		[JsonIgnore]
		internal JsonSchema ParentSchema
		{
			[CompilerGenerated]
			set
			{
				_003CParentSchema_003Ek__BackingField = value;
			}
		}

		[JsonProperty("name", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		public string Name { get; internal set; }

		[JsonProperty("wrapped", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		internal bool Wrapped
		{
			[CompilerGenerated]
			set
			{
				_003CWrapped_003Ek__BackingField = value;
			}
		}

		[JsonProperty("namespace", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		internal string Namespace
		{
			[CompilerGenerated]
			set
			{
				_003CNamespace_003Ek__BackingField = value;
			}
		}

		[JsonProperty("attribute", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		internal bool Attribute
		{
			[CompilerGenerated]
			set
			{
				_003CAttribute_003Ek__BackingField = value;
			}
		}
	}
}
