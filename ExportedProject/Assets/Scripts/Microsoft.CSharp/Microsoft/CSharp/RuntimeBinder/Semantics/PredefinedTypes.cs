using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class PredefinedTypes
	{
		private static readonly AggregateSymbol[] s_predefSymbols;

		private static AggregateSymbol DelayLoadPredefSym(PredefinedType pt)
		{
			return null;
		}

		internal static AggregateSymbol InitializePredefinedType(AggregateSymbol sym, PredefinedType pt)
		{
			return null;
		}

		public static AggregateSymbol GetPredefinedAggregate(PredefinedType pt)
		{
			return null;
		}

		private static string GetNiceName(PredefinedType pt)
		{
			return null;
		}

		public static string GetNiceName(AggregateSymbol type)
		{
			return null;
		}
	}
}
