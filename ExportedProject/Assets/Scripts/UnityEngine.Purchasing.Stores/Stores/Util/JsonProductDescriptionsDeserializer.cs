using System.Collections.Generic;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Stores.Util
{
	internal class JsonProductDescriptionsDeserializer
	{
		public List<ProductDescription> DeserializeProductDescriptions(string json)
		{
			return null;
		}

		internal virtual ProductMetadata DeserializeMetadata(Dictionary<string, object> data)
		{
			return null;
		}
	}
}
