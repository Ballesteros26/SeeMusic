namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class CSemanticChecker
	{
		public static void CheckForStaticClass(CType type)
		{
		}

		public static ACCESSERROR CheckAccess2(Symbol symCheck, AggregateType atsCheck, Symbol symWhere, CType typeThru)
		{
			return default(ACCESSERROR);
		}

		public static bool CheckTypeAccess(CType type, Symbol symWhere)
		{
			return false;
		}

		private static ACCESSERROR CheckAccessCore(Symbol symCheck, AggregateType atsCheck, Symbol symWhere, CType typeThru)
		{
			return default(ACCESSERROR);
		}

		public static bool CheckBogus(Symbol sym)
		{
			return false;
		}

		public static RuntimeBinderException ReportAccessError(SymWithType swtBad, Symbol symWhere, CType typeQual)
		{
			return null;
		}

		public static bool CheckAccess(Symbol symCheck, AggregateType atsCheck, Symbol symWhere, CType typeThru)
		{
			return false;
		}
	}
}
