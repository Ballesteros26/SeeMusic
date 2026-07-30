using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprNamedArgumentSpecification : Expr
	{
		private Expr _value;

		public Name Name { get; }

		public Expr Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ExprNamedArgumentSpecification(Name name, Expr value)
			: base(default(ExpressionKind))
		{
		}
	}
}
