namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprField : ExprWithType
	{
		public Expr OptionalObject { get; set; }

		public FieldWithType FieldWithType { get; }

		public ExprField(CType type, Expr optionalObject, FieldWithType field)
			: base(default(ExpressionKind), null)
		{
		}
	}
}
