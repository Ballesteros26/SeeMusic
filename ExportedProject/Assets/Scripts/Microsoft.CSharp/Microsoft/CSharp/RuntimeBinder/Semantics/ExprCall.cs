namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprCall : ExprWithArgs
	{
		public MethWithInst MethWithInst { get; set; }

		public PREDEFMETH PredefinedMethod { get; set; }

		public NullableCallLiftKind NullableCallLiftKind { get; set; }

		public Expr PConversions { get; set; }

		public Expr CastOfNonLiftedResultToLiftedType { get; set; }

		public ExprCall(CType type, EXPRFLAG flags, Expr arguments, ExprMemberGroup member, MethWithInst method)
			: base(default(ExpressionKind), null)
		{
		}

		public override SymWithType GetSymWithType()
		{
			return null;
		}
	}
}
