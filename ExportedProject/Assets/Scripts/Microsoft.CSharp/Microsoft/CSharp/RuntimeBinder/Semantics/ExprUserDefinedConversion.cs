namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprUserDefinedConversion : Expr
	{
		private Expr _userDefinedCall;

		public Expr Argument { get; set; }

		public Expr UserDefinedCall
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MethWithInst UserDefinedCallMethod { get; }

		public ExprUserDefinedConversion(Expr argument, Expr call, MethWithInst method)
			: base(default(ExpressionKind))
		{
		}
	}
}
