namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class NamespaceSymbol : NamespaceOrAggregateSymbol
	{
		public static readonly NamespaceSymbol Root;

		private static NamespaceSymbol GetRootNamespaceSymbol()
		{
			return null;
		}
	}
}
