using System.Collections.Generic;
using NJsonSchema.References;
using NJsonSchema.Visitors;
using Newtonsoft.Json.Serialization;

namespace NJsonSchema
{
	public static class JsonSchemaReferenceUtilities
	{
		private sealed class JsonReferencePathUpdater : JsonReferenceVisitorBase
		{
			private readonly object _rootObject;

			private readonly Dictionary<IJsonReference, IJsonReference> _schemaReferences;

			private readonly bool _removeExternalReferences;

			private readonly IContractResolver _contractResolver;

			public JsonReferencePathUpdater(object rootObject, Dictionary<IJsonReference, IJsonReference> schemaReferences, bool removeExternalReferences, IContractResolver contractResolver)
				: base(null)
			{
			}

			protected override IJsonReference VisitJsonReference(IJsonReference reference, string path, string typeNameHint)
			{
				return null;
			}
		}

		public static void UpdateSchemaReferencePaths(object rootObject, bool removeExternalReferences, IContractResolver contractResolver)
		{
		}
	}
}
