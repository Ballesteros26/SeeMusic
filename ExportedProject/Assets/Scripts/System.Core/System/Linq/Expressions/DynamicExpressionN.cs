using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
	internal class DynamicExpressionN : DynamicExpression, IArgumentProvider
	{
		private IReadOnlyList<Expression> _arguments;

		int IArgumentProvider.ArgumentCount => 0;

		internal DynamicExpressionN(Type delegateType, CallSiteBinder binder, IReadOnlyList<Expression> arguments)
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
