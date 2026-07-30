namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class TypeBind
	{
		public static bool CheckConstraints(CType type, CheckConstraintsFlags flags)
		{
			return false;
		}

		public static void CheckMethConstraints(MethWithInst mwi)
		{
		}

		private static bool CheckConstraintsCore(Symbol symErr, TypeArray typeVars, TypeArray typeArgs, TypeArray typeArgsCls, TypeArray typeArgsMeth, CheckConstraintsFlags flags)
		{
			return false;
		}

		private static bool CheckSingleConstraint(Symbol symErr, TypeParameterType var, CType arg, TypeArray typeArgsCls, TypeArray typeArgsMeth, CheckConstraintsFlags flags)
		{
			return false;
		}

		private static bool SatisfiesBound(CType arg, CType typeBnd)
		{
			return false;
		}
	}
}
