using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace NJsonSchema
{
	public class JsonSchemaProperty : JsonSchema
	{
		private object _parent;

		[CompilerGenerated]
		private bool _003CIsReadOnly_003Ek__BackingField;

		[JsonIgnore]
		public string Name { get; internal set; }

		[JsonIgnore]
		public override object Parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public bool IsRequired
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[JsonIgnore]
		internal bool InitialIsRequired { get; set; }

		[JsonProperty("x-readOnly", DefaultValueHandling = DefaultValueHandling.Ignore)]
		[DefaultValue(false)]
		public bool IsReadOnly
		{
			[CompilerGenerated]
			set
			{
				_003CIsReadOnly_003Ek__BackingField = value;
			}
		}

		public override bool IsNullable(SchemaType schemaType)
		{
			return false;
		}
	}
}
