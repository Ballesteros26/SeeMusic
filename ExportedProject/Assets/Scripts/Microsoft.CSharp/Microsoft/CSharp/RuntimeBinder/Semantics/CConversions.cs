namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class CConversions
	{
		public static bool FImpRefConv(CType typeSrc, CType typeDst)
		{
			return false;
		}

		public static bool FExpRefConv(CType typeSrc, CType typeDst)
		{
			return false;
		}

		public static bool HasGenericDelegateExplicitReferenceConversion(CType source, CType target)
		{
			return false;
		}

		public static bool HasGenericDelegateExplicitReferenceConversion(CType pSource, AggregateType pTarget)
		{
			return false;
		}

		public static bool FWrappingConv(CType typeSrc, CType typeDst)
		{
			return false;
		}

		public static bool FUnwrappingConv(CType typeSrc, CType typeDst)
		{
			return false;
		}
	}
}
