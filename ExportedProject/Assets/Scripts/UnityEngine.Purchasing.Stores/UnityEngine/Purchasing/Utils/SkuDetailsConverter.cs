using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing.Utils
{
	internal class SkuDetailsConverter : ISkuDetailsConverter
	{
		public List<ProductDescription> ConvertOnQuerySkuDetailsResponse(IEnumerable<AndroidJavaObject> skus)
		{
			return null;
		}

		private static ProductDescription ToProductDescription(AndroidJavaObject skusDetails)
		{
			return null;
		}

		internal static ProductDescription BuildProductDescription(IAndroidJavaObjectWrapper skuDetails)
		{
			return null;
		}
	}
}
