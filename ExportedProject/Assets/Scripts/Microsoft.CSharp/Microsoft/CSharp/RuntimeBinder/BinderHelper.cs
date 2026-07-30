using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal static class BinderHelper
	{
		private static MethodInfo s_DoubleIsNaN;

		private static MethodInfo s_SingleIsNaN;

		internal static DynamicMetaObject Bind(ICSharpBinder action, RuntimeBinder binder, DynamicMetaObject[] args, IEnumerable<CSharpArgumentInfo> arginfos, DynamicMetaObject onBindingError)
		{
			return null;
		}

		public static void ValidateBindArgument(DynamicMetaObject argument, string paramName)
		{
		}

		public static void ValidateBindArgument(DynamicMetaObject[] arguments, string paramName)
		{
		}

		private static bool IsTypeOfStaticCall(int parameterIndex, ICSharpInvokeOrInvokeMemberBinder callPayload)
		{
			return false;
		}

		private static bool IsComObject(object obj)
		{
			return false;
		}

		private static bool IsTransparentProxy(object obj)
		{
			return false;
		}

		private static bool IsDynamicallyTypedRuntimeProxy(DynamicMetaObject argument, CSharpArgumentInfo info)
		{
			return false;
		}

		private static BindingRestrictions DeduceArgumentRestriction(int parameterIndex, ICSharpInvokeOrInvokeMemberBinder callPayload, DynamicMetaObject argument, CSharpArgumentInfo info)
		{
			return null;
		}

		private static Expression ConvertResult(Expression binding, ICSharpBinder action)
		{
			return null;
		}

		private static Type GetTypeForErrorMetaObject(ICSharpBinder action, DynamicMetaObject[] args)
		{
			return null;
		}

		private static bool IsIncrementOrDecrementActionOnLocal(ICSharpBinder action)
		{
			return false;
		}

		internal static T[] Cons<T>(T sourceHead, T[] sourceTail)
		{
			return null;
		}

		internal static T[] Cons<T>(T sourceHead, T[] sourceMiddle, T sourceLast)
		{
			return null;
		}

		internal static T[] ToArray<T>(IEnumerable<T> source)
		{
			return null;
		}

		internal static CallInfo CreateCallInfo(ref IEnumerable<CSharpArgumentInfo> argInfos, int discard)
		{
			return null;
		}

		internal static string GetCLROperatorName(this ExpressionType p)
		{
			return null;
		}
	}
}
