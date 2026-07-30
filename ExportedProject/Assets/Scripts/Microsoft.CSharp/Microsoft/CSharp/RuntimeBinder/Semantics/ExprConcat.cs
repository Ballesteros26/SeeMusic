namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprConcat : ExprWithType
	{
		public Expr FirstArgument { get; set; }

		public Expr SecondArgument { get; set; }

		public ExprConcat(Expr first, Expr second)
			: base(default(ExpressionKind), null)
		{
		}

		private static CType TypeFromOperands(Expr first, Expr second)
		{
			return null;
		}
	}
}
