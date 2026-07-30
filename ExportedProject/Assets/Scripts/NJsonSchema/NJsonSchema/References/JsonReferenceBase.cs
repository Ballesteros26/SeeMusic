using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace NJsonSchema.References
{
	public abstract class JsonReferenceBase<T> : IJsonReferenceBase, IDocumentPathProvider where T : class, IJsonReference
	{
		private T _reference;

		[JsonIgnore]
		public string DocumentPath { get; }

		[JsonProperty("$ref", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
		string IJsonReferenceBase.ReferencePath
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonIgnore]
		public virtual T Reference
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
		IJsonReference IJsonReferenceBase.Reference => null;
	}
}
