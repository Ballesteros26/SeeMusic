using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
	internal static class ExpressionExtension
	{
		public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, params Expression[] arguments)
		{
			return null;
		}

		public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, IEnumerable<Expression> arguments)
		{
			return null;
		}

		public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0)
		{
			return null;
		}

		public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1)
		{
			return null;
		}

		public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2)
		{
			return null;
		}

		public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
			return null;
		}

		private static MethodInfo GetValidMethodForDynamic(Type delegateType)
		{
			return null;
		}

		private static void ValidateDynamicArgument(Expression arg, string paramName)
		{
		}

		private static void ValidateDynamicArgument(Expression arg, string paramName, int index)
		{
		}
	}
}
