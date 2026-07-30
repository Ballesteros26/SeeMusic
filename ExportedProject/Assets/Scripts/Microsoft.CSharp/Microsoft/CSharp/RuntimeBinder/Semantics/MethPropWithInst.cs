namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal class MethPropWithInst : MethPropWithType
	{
		public TypeArray TypeArgs { get; private set; }

		public MethPropWithInst()
		{
		}

		public MethPropWithInst(MethodOrPropertySymbol mps, AggregateType ats)
		{
		}

		public MethPropWithInst(MethodOrPropertySymbol mps, AggregateType ats, TypeArray typeArgs)
		{
		}

		public override void Clear()
		{
		}

		public void Set(MethodOrPropertySymbol mps, AggregateType ats, TypeArray typeArgs)
		{
		}
	}
}
