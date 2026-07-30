namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprLocal : Expr
	{
		public LocalVariableSymbol Local { get; }

		public ExprLocal(LocalVariableSymbol local)
			: base(default(ExpressionKind))
		{
		}
	}
}
