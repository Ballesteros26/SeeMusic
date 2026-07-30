using System.Collections.Generic;

namespace NJsonSchema
{
	public class DefaultTypeNameGenerator : ITypeNameGenerator
	{
		public IEnumerable<string> ReservedTypeNames { get; }

		public IDictionary<string, string> TypeNameMappings { get; }

		public virtual string Generate(JsonSchema schema, string typeNameHint, IEnumerable<string> reservedTypeNames)
		{
			return null;
		}

		protected virtual string Generate(JsonSchema schema, string typeNameHint)
		{
			return null;
		}

		private string GenerateAnonymousTypeName(string typeNameHint, IEnumerable<string> reservedTypeNames)
		{
			return null;
		}

		private static string RemoveIllegalCharacters(string typeName)
		{
			return null;
		}

		private static string DoRemoveIllegalCharacters(string typeName)
		{
			return null;
		}

		private static bool IsEnglishLetterOrUnderScore(char c)
		{
			return false;
		}
	}
}
