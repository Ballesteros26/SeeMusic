using System.Collections.Generic;
using Newtonsoft.Json.Serialization;

namespace NJsonSchema
{
	public static class JsonPathUtilities
	{
		public static string GetJsonPath(object rootObject, object searchedObject, IContractResolver contractResolver)
		{
			return null;
		}

		public static IReadOnlyDictionary<object, string> GetJsonPaths(object rootObject, IEnumerable<object> searchedObjects, IContractResolver contractResolver)
		{
			return null;
		}

		private static bool FindJsonPaths(object obj, Dictionary<object, string> searchedObjects, string basePath, HashSet<object> checkedObjects, IContractResolver contractResolver)
		{
			return false;
		}
	}
}
