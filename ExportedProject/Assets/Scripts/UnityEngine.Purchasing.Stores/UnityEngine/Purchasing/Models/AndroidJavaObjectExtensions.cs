using System.Collections.Generic;
using UnityEngine.Purchasing.Utils;

namespace UnityEngine.Purchasing.Models
{
	internal static class AndroidJavaObjectExtensions
	{
		internal static IEnumerable<T> Enumerate<T>(this AndroidJavaObject androidJavaList)
		{
			return null;
		}

		internal static IEnumerable<IAndroidJavaObjectWrapper> EnumerateAndWrap(this AndroidJavaObject androidJavaList)
		{
			return null;
		}

		internal static IEnumerable<IAndroidJavaObjectWrapper> Wrap(this IEnumerable<AndroidJavaObject> androidJavaList)
		{
			return null;
		}

		internal static IAndroidJavaObjectWrapper Wrap(this AndroidJavaObject androidJavaObject)
		{
			return null;
		}
	}
}
