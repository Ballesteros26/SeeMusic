using System;
using System.Reflection;

namespace UnityEngine.Purchasing
{
	internal class InventoryInterface
	{
		private static Type s_typeCache;

		internal static Type GetClassType()
		{
			return null;
		}

		internal static MethodInfo GetProductListMethod()
		{
			return null;
		}

		internal static MethodInfo GetPurchaseInfoMethod()
		{
			return null;
		}

		internal static MethodInfo HasPurchaseMethod()
		{
			return null;
		}
	}
}
