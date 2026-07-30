using System;
using System.Diagnostics;

namespace Mono.Util
{
	[Conditional("UNITY")]
	[AttributeUsage(AttributeTargets.Method)]
	[Conditional("MONOTOUCH")]
	[Conditional("FULL_AOT_RUNTIME")]
	internal sealed class MonoPInvokeCallbackAttribute : Attribute
	{
		public MonoPInvokeCallbackAttribute(Type t)
		{
		}
	}
}
