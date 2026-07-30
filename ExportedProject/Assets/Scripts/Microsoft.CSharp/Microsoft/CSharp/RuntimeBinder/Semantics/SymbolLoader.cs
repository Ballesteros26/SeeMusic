using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class SymbolLoader
	{
		public static AggregateSymbol GetPredefAgg(PredefinedType pt)
		{
			return null;
		}

		public static AggregateType GetPredefindType(PredefinedType pt)
		{
			return null;
		}

		public static Symbol LookupAggMember(Name name, AggregateSymbol agg, symbmask_t mask)
		{
			return null;
		}

		private static bool IsBaseInterface(AggregateType atsDer, AggregateType pBase)
		{
			return false;
		}

		public static bool IsBaseClassOfClass(CType pDerived, CType pBase)
		{
			return false;
		}

		private static bool IsBaseClass(CType pDerived, CType pBase)
		{
			return false;
		}

		private static bool HasCovariantArrayConversion(ArrayType pSource, ArrayType pDest)
		{
			return false;
		}

		public static bool HasIdentityOrImplicitReferenceConversion(CType pSource, CType pDest)
		{
			return false;
		}

		private static bool AreTypesEqualForConversion(CType pType1, CType pType2)
		{
			return false;
		}

		private static bool HasArrayConversionToInterface(ArrayType pSource, CType pDest)
		{
			return false;
		}

		private static bool HasImplicitReferenceConversion(CType pSource, CType pDest)
		{
			return false;
		}

		private static bool HasAnyBaseInterfaceConversion(CType pDerived, CType pBase)
		{
			return false;
		}

		private static bool HasInterfaceConversion(AggregateType pSource, AggregateType pDest)
		{
			return false;
		}

		private static bool HasDelegateConversion(AggregateType pSource, AggregateType pDest)
		{
			return false;
		}

		private static bool HasVariantConversion(AggregateType pSource, AggregateType pDest)
		{
			return false;
		}

		private static bool HasImplicitBoxingConversion(CType pSource, CType pDest)
		{
			return false;
		}

		public static bool HasBaseConversion(CType pSource, CType pDest)
		{
			return false;
		}

		public static bool IsBaseAggregate(AggregateSymbol derived, AggregateSymbol @base)
		{
			return false;
		}
	}
}
