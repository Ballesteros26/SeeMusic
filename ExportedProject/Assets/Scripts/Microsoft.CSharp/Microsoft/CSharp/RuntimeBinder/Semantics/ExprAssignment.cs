namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprAssignment : Expr
	{
		private Expr _lhs;

		public Expr LHS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Expr RHS { get; set; }

		public ExprAssignment(Expr lhs, Expr rhs)
			: base(default(ExpressionKind))
		{
		}
	}
}
