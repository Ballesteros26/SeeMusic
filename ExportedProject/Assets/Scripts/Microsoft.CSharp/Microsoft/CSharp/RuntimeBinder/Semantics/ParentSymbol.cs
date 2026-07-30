namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal abstract class ParentSymbol : Symbol
	{
		public Symbol firstChild;

		private Symbol _lastChild;

		public void AddToChildList(Symbol sym)
		{
		}
	}
}
