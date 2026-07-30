namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class LocalVariableSymbol : VariableSymbol
	{
		public ExprWrap wrap;

		public void SetType(CType pType)
		{
		}

		public new CType GetType()
		{
			return null;
		}
	}
}
