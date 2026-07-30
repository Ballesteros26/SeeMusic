namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprBoundLambda : ExprWithType
	{
		public Expr Expression { get; }

		public AggregateType DelegateType => null;

		public Scope ArgumentScope { get; }

		public ExprBoundLambda(AggregateType type, Scope argumentScope, Expr expression)
			: base(default(ExpressionKind), null)
		{
		}
	}
}
