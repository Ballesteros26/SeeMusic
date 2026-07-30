using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	internal class JSONSerializer
	{
		public static string SerializeProductDef(ProductDefinition product)
		{
			return null;
		}

		public static string SerializeProductDefs(IEnumerable<ProductDefinition> products)
		{
			return null;
		}

		public static string SerializeProductDescs(IEnumerable<ProductDescription> products)
		{
			return null;
		}

		public static Dictionary<string, string> DeserializeSubscriptionDescriptions(string json)
		{
			return null;
		}

		public static PurchaseFailureDescription DeserializeFailureReason(string json)
		{
			return null;
		}

		private static string BuildPurchaseFailureDescriptionMessage(Dictionary<string, object> dic)
		{
			return null;
		}

		private static Dictionary<string, object> EncodeProductDef(ProductDefinition product)
		{
			return null;
		}

		private static Dictionary<string, object> EncodeProductDesc(ProductDescription product)
		{
			return null;
		}

		private static Dictionary<string, object> EncodeProductMeta(ProductMetadata product)
		{
			return null;
		}
	}
}
