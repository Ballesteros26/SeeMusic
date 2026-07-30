namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class MethWithInst : MethPropWithInst
	{
		public MethWithInst(MethodSymbol meth, AggregateType ats)
		{
		}

		public MethWithInst(MethodSymbol meth, AggregateType ats, TypeArray typeArgs)
		{
		}

		public MethWithInst(MethPropWithInst mpwi)
		{
		}
	}
}
