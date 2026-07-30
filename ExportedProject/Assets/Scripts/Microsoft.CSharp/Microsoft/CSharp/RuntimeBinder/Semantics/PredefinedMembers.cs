using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class PredefinedMembers
	{
		private static readonly MethodSymbol[] _methods;

		private static readonly PropertySymbol[] _properties;

		private static readonly PredefinedPropertyInfo[] s_predefinedProperties;

		private static readonly PredefinedMethodInfo[] s_predefinedMethods;

		private static PropertySymbol LoadProperty(PREDEFPROP property)
		{
			return null;
		}

		private static PropertySymbol LoadProperty(PREDEFPROP predefProp, Name propertyName, PREDEFMETH propertyGetter)
		{
			return null;
		}

		private static AggregateSymbol GetPredefAgg(PredefinedType pt)
		{
			return null;
		}

		private static CType LoadTypeFromSignature(int[] signature, ref int indexIntoSignatures, TypeArray classTyVars)
		{
			return null;
		}

		private static TypeArray LoadTypeArrayFromSignature(int[] signature, ref int indexIntoSignatures, TypeArray classTyVars)
		{
			return null;
		}

		public static PropertySymbol GetProperty(PREDEFPROP property)
		{
			return null;
		}

		public static MethodSymbol GetMethod(PREDEFMETH method)
		{
			return null;
		}

		private static MethodSymbol LoadMethod(AggregateSymbol type, int[] signature, int cMethodTyVars, Name methodName, ACCESS methodAccess, bool isStatic, bool isVirtual)
		{
			return null;
		}

		private static MethodSymbol LookupMethodWhileLoading(AggregateSymbol type, int cMethodTyVars, Name methodName, ACCESS methodAccess, bool isStatic, bool isVirtual, CType returnType, TypeArray argumentTypes)
		{
			return null;
		}

		private static MethodSymbol LoadMethod(PREDEFMETH method)
		{
			return null;
		}

		private static PREDEFMETH GetPropGetter(PREDEFPROP property)
		{
			return default(PREDEFMETH);
		}

		private static PredefinedType GetPropPredefType(PREDEFPROP property)
		{
			return default(PredefinedType);
		}

		private static PredefinedPropertyInfo GetPropInfo(PREDEFPROP property)
		{
			return null;
		}

		private static PredefinedMethodInfo GetMethInfo(PREDEFMETH method)
		{
			return null;
		}
	}
}
