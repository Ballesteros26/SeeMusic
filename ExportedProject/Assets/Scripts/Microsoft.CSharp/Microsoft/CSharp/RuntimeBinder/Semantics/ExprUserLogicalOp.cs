namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprUserLogicalOp : ExprWithType
	{
		public Expr TrueFalseCall { get; set; }

		public ExprCall OperatorCall { get; set; }

		public Expr FirstOperandToExamine { get; set; }

		public ExprUserLogicalOp(CType type, Expr trueFalseCall, ExprCall operatorCall)
			: base(default(ExpressionKind), null)
		{
		}
	}
}
