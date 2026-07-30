namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprConstant : ExprWithType
	{
		public Expr OptionalConstructorCall { get; set; }

		public bool IsZero => false;

		public ConstVal Val { get; }

		public ulong UInt64Value => 0uL;

		public long Int64Value => 0L;

		public override object Object => null;

		public ExprConstant(CType type, ConstVal value)
			: base(default(ExpressionKind), null)
		{
		}
	}
}
