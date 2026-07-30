using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
	internal sealed class TypedDynamicExpression4 : DynamicExpression4
	{
		public sealed override Type Type { get; }

		internal TypedDynamicExpression4(Type retType, Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
			: base(null, null, null, null, null, null)
		{
		}
	}
}
