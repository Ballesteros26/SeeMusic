using System;
using System.Reflection;

namespace UnityEngine.Purchasing
{
	internal class UdpIapBridgeInterface
	{
		private static Type s_typeCache;

		internal static Type GetClassType()
		{
			return null;
		}

		internal static MethodInfo GetInitMethod()
		{
			return null;
		}

		internal static MethodInfo GetPurchaseMethod()
		{
			return null;
		}

		internal static MethodInfo GetRetrieveProductsMethod()
		{
			return null;
		}

		internal static MethodInfo GetFinishTransactionMethod()
		{
			return null;
		}
	}
}
