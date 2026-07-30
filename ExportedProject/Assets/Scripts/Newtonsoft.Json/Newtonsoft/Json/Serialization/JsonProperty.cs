using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class JsonProperty
	{
		internal Required? _required;

		internal bool _hasExplicitDefaultValue;

		private object? _defaultValue;

		private bool _hasGeneratedDefaultValue;

		private string? _propertyName;

		internal bool _skipPropertyNameEscape;

		private Type? _propertyType;

		[CompilerGenerated]
		private IAttributeProvider? _003CAttributeProvider_003Ek__BackingField;

		internal JsonContract? PropertyContract { get; set; }

		public string? PropertyName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Type? DeclaringType { get; set; }

		public int? Order { get; set; }

		public string? UnderlyingName { get; set; }

		public IValueProvider? ValueProvider { get; set; }

		public IAttributeProvider? AttributeProvider
		{
			[CompilerGenerated]
			set
			{
				_003CAttributeProvider_003Ek__BackingField = value;
			}
		}

		public Type? PropertyType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public JsonConverter? Converter { get; set; }

		public bool Ignored { get; set; }

		public bool Readable { get; set; }

		public bool Writable { get; set; }

		public bool HasMemberAttribute { get; set; }

		public object? DefaultValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Required Required
		{
			get
			{
				return default(Required);
			}
			set
			{
			}
		}

		public bool? IsReference { get; set; }

		public NullValueHandling? NullValueHandling { get; set; }

		public DefaultValueHandling? DefaultValueHandling { get; set; }

		public ReferenceLoopHandling? ReferenceLoopHandling { get; set; }

		public ObjectCreationHandling? ObjectCreationHandling { get; set; }

		public TypeNameHandling? TypeNameHandling { get; set; }

		public Predicate<object>? ShouldSerialize { get; set; }

		public Predicate<object>? ShouldDeserialize { get; set; }

		public Predicate<object>? GetIsSpecified { get; set; }

		public Action<object, object?>? SetIsSpecified { get; set; }

		public JsonConverter? ItemConverter { get; set; }

		public bool? ItemIsReference { get; set; }

		public TypeNameHandling? ItemTypeNameHandling { get; set; }

		public ReferenceLoopHandling? ItemReferenceLoopHandling { get; set; }

		internal object? GetResolvedDefaultValue()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		internal void WritePropertyName(JsonWriter writer)
		{
		}
	}
}
