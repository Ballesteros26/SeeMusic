using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
	internal class DynamicExpression1 : DynamicExpression, IArgumentProvider
	{
		private object _arg0;

		int IArgumentProvider.ArgumentCount => 0;

		internal DynamicExpression1(Type delegateType, CallSiteBinder binder, Expression arg0)
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
