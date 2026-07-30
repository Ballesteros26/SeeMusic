namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprWrap : Expr
	{
		public Expr OptionalExpression { get; }

		public ExprWrap(Expr expression)
			: base(default(ExpressionKind))
		{
		}
	}
}
