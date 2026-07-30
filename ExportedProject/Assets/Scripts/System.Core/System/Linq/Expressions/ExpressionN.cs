using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions
{
	internal class ExpressionN<TDelegate> : Expression<TDelegate>
	{
		private IReadOnlyList<ParameterExpression> _parameters;

		internal override int ParameterCount => 0;

		public ExpressionN(Expression body, IReadOnlyList<ParameterExpression> parameters)
			: base((Expression)null)
		{
		}

		internal override ParameterExpression GetParameter(int index)
		{
			return null;
		}

		internal override ReadOnlyCollection<ParameterExpression> GetOrMakeParameters()
		{
			return null;
		}

		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}
	}
}
