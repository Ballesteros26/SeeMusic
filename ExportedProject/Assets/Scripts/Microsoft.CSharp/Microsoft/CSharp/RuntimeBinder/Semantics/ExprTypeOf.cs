namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprTypeOf : ExprWithType
	{
		public CType SourceType { get; }

		public override object Object => null;

		public ExprTypeOf(CType type, CType sourceType)
			: base(default(ExpressionKind), null)
		{
		}
	}
}
