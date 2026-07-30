namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprCast : ExprWithType
	{
		public Expr Argument { get; set; }

		public bool IsBoxingCast => false;

		public override object Object => null;

		public ExprCast(EXPRFLAG flags, CType type, Expr argument)
			: base(default(ExpressionKind), null)
		{
		}
	}
}
