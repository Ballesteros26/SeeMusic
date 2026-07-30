using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	internal static class ImmutableCollectionsUtils
	{
		internal class ImmutableCollectionTypeInfo
		{
			public string ContractTypeName { get; set; }

			public string CreatedTypeName { get; set; }

			public string BuilderTypeName { get; set; }

			public ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName)
			{
			}
		}

		private static readonly IList<ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions;

		private static readonly IList<ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions;

		internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, [NotNullWhen(true)] out Type? createdType, [NotNullWhen(true)] out ObjectConstructor<object>? parameterizedCreator)
		{
			createdType = null;
			parameterizedCreator = null;
			return false;
		}

		internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, [NotNullWhen(true)] out Type? createdType, [NotNullWhen(true)] out ObjectConstructor<object>? parameterizedCreator)
		{
			createdType = null;
			parameterizedCreator = null;
			return false;
		}
	}
}
