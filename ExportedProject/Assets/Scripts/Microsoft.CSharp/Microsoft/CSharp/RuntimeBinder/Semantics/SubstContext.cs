namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class SubstContext
	{
		public readonly CType[] ClassTypes;

		public readonly CType[] MethodTypes;

		public readonly bool DenormMeth;

		public bool IsNop => false;

		public SubstContext(TypeArray typeArgsCls, TypeArray typeArgsMeth, bool denormMeth)
		{
		}

		public SubstContext(AggregateType type)
		{
		}

		public SubstContext(AggregateType type, TypeArray typeArgsMeth)
		{
		}

		private SubstContext(AggregateType type, TypeArray typeArgsMeth, bool denormMeth)
		{
		}
	}
}
