using System.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Interfaces
{
	internal interface ISkuDetailsConverter
	{
		List<ProductDescription> ConvertOnQuerySkuDetailsResponse(IEnumerable<AndroidJavaObject> skus);
	}
}
