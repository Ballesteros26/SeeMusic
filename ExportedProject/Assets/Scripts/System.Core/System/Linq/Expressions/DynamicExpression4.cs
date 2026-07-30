using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
	internal class DynamicExpression4 : DynamicExpression, IArgumentProvider
	{
		private object _arg0;

		private readonly Expression _arg1;

		private readonly Expression _arg2;

		private readonly Expression _arg3;

		int IArgumentProvider.ArgumentCount => 0;

		internal DynamicExpression4(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
			: base(null, null)
		{
		}

		Expression IArgumentProvider.GetArgument(int index)
		{
			return null;
		}

		internal override ReadOnlyCollection<Expression> GetOrMakeArguments()
		{
			return null;
		}

		internal override DynamicExpression Rewrite(Expression[] args)
		{
			return null;
		}
	}
}
