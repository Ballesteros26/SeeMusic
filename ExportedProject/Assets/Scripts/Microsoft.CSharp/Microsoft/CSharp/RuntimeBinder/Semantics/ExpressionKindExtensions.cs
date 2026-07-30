namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class ExpressionKindExtensions
	{
		public static bool IsRelational(this ExpressionKind kind)
		{
			return false;
		}

		public static bool IsUnaryOperator(this ExpressionKind kind)
		{
			return false;
		}
	}
}
