namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprZeroInit : ExprWithType
	{
		public override object Object => null;

		public ExprZeroInit(CType type)
			: base(default(ExpressionKind), null)
		{
		}
	}
}
