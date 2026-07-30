namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprUnaryOp : ExprOperator
	{
		public Expr Child { get; set; }

		public ExprUnaryOp(ExpressionKind kind, CType type, Expr operand)
			: base(default(ExpressionKind), null)
		{
		}

		public ExprUnaryOp(ExpressionKind kind, CType type, Expr operand, Expr call, MethPropWithInst userMethod)
			: base(default(ExpressionKind), null)
		{
		}
	}
}
